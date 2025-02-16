using ChainOfResponsibilityMiddleware.Middleware;

namespace ChainOfResponsibilityMiddleware;

public class MiddlewarePipeline
{
    private readonly List<IMiddleware> _middlewares = new List<IMiddleware>();

    public void Use(IMiddleware middleware)
    {
        _middlewares.Add(middleware);
    }

    public async Task<string> RunAsync(string input)
    {
        Func<string, Task<string>> next = async (str) => str;

        foreach (var middleware in _middlewares.Reverse<IMiddleware>())
        {
            var prev = next;
            next = AddNext(middleware, prev);
        }

        return await next(input);
    }

    private Func<string, Task<string>> AddNext(IMiddleware middleware, Func<string, Task<string>> prev)
    {
        return new Func<string, Task<string>>(async (str) =>
        {
            return await middleware.InvokeAsync(str, prev);
        });
    }
    //public async Task<string> RunAsync(string input)
    //{
    //    Func<string, Task<string>> next = async (str) => str;

    //    foreach (var middleware in _middlewares.Reverse<IMiddleware>())
    //    {
    //        var previousNext = next;
    //        next = async (str) => await middleware.InvokeAsync(str, previousNext);
    //    }

    //    return await next(input);
    //}
}