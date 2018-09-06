namespace multi.web
{
  using System;
  using System.Threading.Tasks;
  using Microsoft.AspNetCore.Http;
  using Microsoft.Extensions.Options;
  using multi.utils;


  public class MultiplyMiddleware
    {
        private readonly RequestDelegate next;
        private readonly Calculadora _calc;
 
        public MultiplyMiddleware(RequestDelegate next, Calculadora calc)
        {
          this._calc = calc;
          this.next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext context)
        {
          var request = context.Request;
          int n = 0;
          if (int.TryParse(context.Request.Path.Value.Replace("/", ""), out n))
          {
           
            var results = _calc.Tabla(n);

            await context.Response.WriteAsync($"<html><body><h1>Tabla del {n}</h1><br /><ul>");
            for (int i = 0; i < 11; i++)
            {
              await context.Response.WriteAsync($"<li>{n} x {i} = {results[i]}</li>");
            }

            await context.Response.WriteAsync("</ul></body></html>");
          }
          else
          {
            await context.Response.WriteAsync($"<html><body><h1>Error</h1><br /><p>Valor en url inválido.</p><ul>");
          }

          await next(context);
        }
    }    
}