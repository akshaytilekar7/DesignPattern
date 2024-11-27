namespace CustomMiddleware;

public delegate Task RequestDelegate(string context);
public class MiddlewarePipeline
{
    private readonly List<Func<RequestDelegate, RequestDelegate>> _middlewares = new();

    public MiddlewarePipeline UseMiddleware<T>() where T : class
    {
        _middlewares.Add(next =>
        {
            var middleware = Activator.CreateInstance(typeof(T), next)
                ?? throw new InvalidOperationException($"Failed to create middleware: {typeof(T)}");

            var method = typeof(T).GetMethod("InvokeAsync")
                ?? throw new InvalidOperationException("Middleware must have an InvokeAsync method.");

            return context => (Task)method.Invoke(middleware, new object[] { context });
        });

        return this;
    }

    public RequestDelegate Build()
    {
        RequestDelegate next = context =>
        {
            Console.WriteLine("End of pipeline reached.");
            return Task.CompletedTask;
        };

        foreach (var middleware in _middlewares.AsEnumerable().Reverse())
            next = middleware(next);

        return next;
    }
}