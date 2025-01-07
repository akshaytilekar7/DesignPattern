namespace CustomMiddleware;

public delegate Task RequestDelegate(string context);
public class MiddlewarePipeline
{
    private readonly List<Func<RequestDelegate, RequestDelegate>> _middlewares = new();

    public MiddlewarePipeline UseMiddleware<T>() where T : class
    {
        Func<RequestDelegate, RequestDelegate> middlewareFactory = next =>
        {
            // create instance
            var middleware = Activator.CreateInstance(typeof(T), next);

            // fetch InvokeAsync method
            var method = typeof(T).GetMethod("InvokeAsync");

            //
            RequestDelegate del = z => (Task)method.Invoke(middleware, [z]);
            return del;
        };

        _middlewares.Add(middlewareFactory);

        return this;
    }

    public RequestDelegate Build()
    {
        RequestDelegate dummy = context =>
        {
            Console.WriteLine("End of pipeline reached.");
            return Task.CompletedTask;
        };

        foreach (var middleware in _middlewares.AsEnumerable().Reverse())
            dummy = middleware(dummy);

        return dummy;
    }
}