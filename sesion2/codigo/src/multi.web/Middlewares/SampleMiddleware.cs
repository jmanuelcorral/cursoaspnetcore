namespace multi.web
{
  using System;
  using System.Threading.Tasks;
  using Microsoft.AspNetCore.Http;
  using Microsoft.Extensions.Options;
  using multi.utils;

  public class SampleMiddleware
    {
        private readonly RequestDelegate next;
 
        public SampleMiddleware(RequestDelegate next)
        {
            this.next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext context)
        {
           await context.Response.WriteAsync($"Hola"); 
          //Hacemos la nuestra
          //await next(context);
        }
    }    
}