
namespace COR;
public class UpperCaseMiddleware : IMiddleware
{
    public async Task<string> InvokeAsync(string input, Func<string, Task<string>> next)
    {
        Console.WriteLine($"Middleware executing: {nameof(UpperCaseMiddleware)}");
        input = input.ToUpper(); // Transform input to uppercase.
        return await next(input); // Pass to the next middleware.
    }
}

public class ReverseMiddleware : IMiddleware
{
    public async Task<string> InvokeAsync(string input, Func<string, Task<string>> next)
    {
        Console.WriteLine($"Middleware executing: {nameof(ReverseMiddleware)}");
        input = new string(input.Reverse().ToArray()); // Reverse the string.
        return await next(input); // Pass to the next middleware.
    }
}

