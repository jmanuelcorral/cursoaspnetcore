namespace multi.web
{
  using System;
  using System.Threading.Tasks;
  using Microsoft.AspNetCore.Http;

  public class FirstMiddlewareWithPipe :  BaseMiddlewareWithPipe<int>
    {
        private readonly RequestDelegate next;
 
        public FirstMiddlewareWithPipe(RequestDelegate next, IPipedMiddlewareParameter<int> pipedParam): base(pipedParam)
        {
          this.next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext context)
        {
          _pipe.value = 5;

          await next(context);
        }
    }    
}