namespace multi.web
{
  using Microsoft.EntityFrameworkCore.Storage;

  public class MiddlewarePipedParameter<T>: IPipedMiddlewareParameter<T>
  {

    public bool HasValue
    {
      get { return (value != null); }
    }

    public T value { get; set; }
  }
}