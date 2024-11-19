namespace ChainOfResponsibilityMiddleware.Middleware;

public class UpperCaseMiddleware : IMiddleware
{
    public async Task<string> InvokeAsync(string input, Func<string, Task<string>> next)
    {
        Console.WriteLine(nameof(UpperCaseMiddleware));
        input = input.ToUpper(); 
        return await next(input);
    }
}

public class ReverseMiddleware : IMiddleware
{
    public async Task<string> InvokeAsync(string input, Func<string, Task<string>> next)
    {
        Console.WriteLine(nameof(ReverseMiddleware));
        input = new string(input.Reverse().ToArray());
        return await next(input); 
    }
}
