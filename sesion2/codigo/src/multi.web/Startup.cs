using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace multi.web
{
  using utils;

  public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
          services.AddSingleton<IPipedMiddlewareParameter<int>, MiddlewarePipedParameter<int>>();
          services.AddSingleton<Calculadora>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
          //Descomentar para probar la funcionalidad de "piping entre middlewares"
          /*
          app.UseMiddleware<FirstMiddlewareWithPipe>();
          app.UseMiddleware<SecondMiddlewareWithPipe>();
          */
          app.UseMiddleware<MultiplyMiddleware>();
        }
    }
}
