namespace multi.web
{
  using System;
  using System.Threading.Tasks;
  using Microsoft.AspNetCore.Http;

  public class SecondMiddlewareWithPipe : BaseMiddlewareWithPipe<int>
    {
        private readonly RequestDelegate next;
 
        public SecondMiddlewareWithPipe(RequestDelegate next, IPipedMiddlewareParameter<int> pipedParam) : base(pipedParam)
        {
          this.next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext context)
        {
          if (_pipe.HasValue)
          await context.Response.WriteAsync($"El valor que viene del Middleware anterior es {_pipe.value}"); 
          else 
            await context.Response.WriteAsync($"No viene valor en el Middleware anterior"); 
          await next(context);
        }
    }    
}