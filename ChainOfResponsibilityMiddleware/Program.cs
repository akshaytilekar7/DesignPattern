using ChainOfResponsibilityMiddleware.Middleware;

namespace ChainOfResponsibilityMiddleware;

internal class Program
{
    static async Task Main(string[] args)
    {
        var pipeline = new MiddlewarePipeline();

        // Add middleware classes to the pipeline
        pipeline.Use(new UpperCaseMiddleware()); // Capitalize
        pipeline.Use(new ReverseMiddleware()); // Reverse string

        // Initial string
        string x = "Akshasasasasasay";
        Console.WriteLine("Original String: " + x);

        // Run the pipeline
        string result = await pipeline.RunAsync(x);

        // Output the final transformed string
        Console.WriteLine("Final String: " + result); // This will show the final result after all middlewares
        Console.ReadLine();
    }
}
