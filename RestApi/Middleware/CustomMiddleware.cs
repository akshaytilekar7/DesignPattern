namespace RestApi.Middleware;


using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class CustomMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        
        context.Response.Headers.Append("X-Custom-Header", "MyMiddleware");

        await next(context)

        await context.Response.WriteAsync(" - Processed by CustomMiddleware");
    }
}
