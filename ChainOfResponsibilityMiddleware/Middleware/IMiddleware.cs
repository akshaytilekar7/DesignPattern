namespace ChainOfResponsibilityMiddleware.Middleware;

public interface IMiddleware
{
    Task<string> InvokeAsync(string input, Func<string, Task<string>> next);
}