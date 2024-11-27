using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMiddleware;

public class RequestTimingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestTimingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(string context)
    {
        var start = DateTime.UtcNow;

        await _next(context);

        var elapsed = DateTime.UtcNow - start;
        Console.WriteLine($"Request took {elapsed.TotalMilliseconds} ms");
    }
}


public class UpperCaseMiddleware
{
    private readonly RequestDelegate _next;

    public UpperCaseMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(string context)
    {
        context = context.ToUpper();
        Console.WriteLine($"UpperCaseMiddleware: {context}");

        await _next(context);
    }
}

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(string context)
    {
        Console.WriteLine($"LoggingMiddleware: Received '{context}'");
        await _next(context);
    }
}