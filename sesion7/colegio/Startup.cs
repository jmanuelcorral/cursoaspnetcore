namespace colegio
{
  using Data;
  using Data.Contexts;
  using Data.Repositories;
  using Microsoft.AspNetCore.Builder;
  using Microsoft.AspNetCore.Hosting;
  using Microsoft.AspNetCore.Http;
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.EntityFrameworkCore;
  using Microsoft.Extensions.Configuration;
  using Microsoft.Extensions.DependencyInjection;
  using Models;
  using Swashbuckle.AspNetCore.Swagger;

  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddScoped<IBaseRepository<Profesor, int>, ProfesorRepository>();
      services.AddScoped<IBaseRepository<Curso, int>, CursoRepository>();
      services.AddScoped<IBaseRepository<Aula, int>, AulaRepository>();
      services.AddScoped<IAlumnoRepository, AlumnoRepository>();
      services.Configure<CookiePolicyOptions>(options =>
      {
        // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
      });

      services.AddDbContext<DataContext>(options =>
      {
        options.UseSqlServer(Configuration.GetConnectionString("Colegio")); });
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
        .AddXmlSerializerFormatters();

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Info {Title = "Colegio API", Version = "v1"});
        //c.IncludeXmlComments(@"c:\projects\colegio\colegio\colegio.xml", true);
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        // Enable middleware to serve generated Swagger as a JSON endpoint.
        app.UseSwagger();

        // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
        // specifying the Swagger JSON endpoint.
        app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
      }

      app.UseStaticFiles();
      app.UseCookiePolicy();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
          "default",
          "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}