namespace multi.web
{
  using System;

  public abstract class BaseMiddlewareWithPipe<T>
    {
      protected readonly IPipedMiddlewareParameter<T> _pipe;

      public BaseMiddlewareWithPipe(IPipedMiddlewareParameter<T> dep)
      {
        _pipe =  dep ?? throw new ArgumentNullException(nameof(dep));;
      }
    }
}