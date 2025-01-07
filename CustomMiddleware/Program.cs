namespace CustomMiddleware;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var pipeline = new MiddlewarePipeline();

        pipeline.UseMiddleware<RequestTimingMiddleware>();
        pipeline.UseMiddleware<LoggingMiddleware>();
        pipeline.UseMiddleware<UpperCaseMiddleware>();



        var executor = pipeline.Build();

        // Execute the pipeline
        await executor("Hello Middleware");
    }
}