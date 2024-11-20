using PipelineInterceptor.Models;

namespace PipelineInterceptor.Middlewares;

public class CustomSecurityHeadersMiddleware
{
    private readonly Delegate _next;

    public CustomSecurityHeadersMiddleware(Delegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(MyHttpContext context)
    {
        context.Request += 10;
        await _next(context);
    }
}
