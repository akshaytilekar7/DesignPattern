namespace COR;

public interface IMiddleware
{
    Task<string> InvokeAsync(string input, Func<string, Task<string>> next);
}

public class MiddlewarePipeline
{
    private readonly List<IMiddleware> _middlewares = new List<IMiddleware>();

    public MiddlewarePipeline UseMiddleware<T>() where T : IMiddleware, new()
    {
        _middlewares.Add(new T());
        return this;
    }

    public async Task<string> RunAsync(string input)
    {
        Func<string, Task<string>> next = async (str) => str;

        foreach (var middleware in _middlewares.AsEnumerable().Reverse())
        {
            var current = next;
            next = async (str) => await middleware.InvokeAsync(str, current);
        }

        return await next(input); 
    }
}

