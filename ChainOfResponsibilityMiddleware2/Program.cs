namespace COR;
internal class Program
{
    static async Task Main(string[] args)
    {
        var pipeline = new MiddlewarePipeline();

        // Add middlewares to the pipeline
        pipeline.UseMiddleware<UpperCaseMiddleware>();
        pipeline.UseMiddleware<ReverseMiddleware>();

        string input = "Pragati Tilekar";
        Console.WriteLine($"Original String: {input}");

        string result = await pipeline.RunAsync(input);

        Console.WriteLine($"Final String: {result}");
        Console.ReadLine();
    }


}
