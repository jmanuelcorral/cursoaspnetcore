namespace multi.web
{
  public interface IPipedMiddlewareParameter<T>
  {
    bool HasValue { get;  }
    T value { get; set; }
  }

}