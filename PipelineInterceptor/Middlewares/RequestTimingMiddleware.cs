using PipelineInterceptor.Models;
namespace PipelineInterceptor.Middlewares;


public class RequestTimingMiddleware
{
    private readonly Delegate _next;

    public RequestTimingMiddleware(Delegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(MyHttpContext context)
    {
        context.Request += 5;
        await _next(context);
    }
}
