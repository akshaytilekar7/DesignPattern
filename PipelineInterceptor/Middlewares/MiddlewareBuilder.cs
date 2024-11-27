using PipelineInterceptor.Models;
namespace PipelineInterceptor.Middlewares;

public delegate Task Delegate(MyHttpContext context);

public class MiddlewareBuilder
{
    private readonly List<Func<Delegate, Delegate>> _middlewares = new();

    public MiddlewareBuilder Add(Func<Delegate, Delegate> middleware)
    {
        _middlewares.Add(middleware);
        return this;
    }

    public Delegate Build()
    {
        Delegate next = context =>
        {
            Console.WriteLine("End of pipeline");
            return Task.CompletedTask;
        };

        // chain of reponsibility 
        foreach (Func<Delegate, Delegate> middleware in _middlewares.AsEnumerable().Reverse())
            next = middleware(next);

        return next;
    }
}

public static class MyMiddlewareExtensions
{
    public static MiddlewareBuilder UseMiddleware<T>(this MiddlewareBuilder builder) where T : class
    {
        // same as decorator patterns
        builder.Add(next =>
        {
            var middleware = Activator.CreateInstance(typeof(T), next);

            var method = typeof(T).GetMethod("InvokeAsync");

            return async context =>
            {
                await (Task)method.Invoke(middleware, new object[] { context });
            };
        });

        return builder;
    }
}
