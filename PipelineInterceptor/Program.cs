using PipelineInterceptor.Middlewares;
using PipelineInterceptor.Models;

namespace PipelineInterceptor;

internal class Program
{
    static async Task Main(string[] args)
    {
        var builder = new MiddlewareBuilder();
        builder.UseMiddleware<CustomSecurityHeadersMiddleware>();
        builder.UseMiddleware<RequestTimingMiddleware>();

        var pipeline = builder.Build();

        var context = new MyHttpContext() { Request = 200 };

        await pipeline(context);

        Console.WriteLine(context.Request);
        Console.ReadLine();
    }
}
