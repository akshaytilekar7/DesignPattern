using BuilderPattern3.Model;

namespace BuilderPatternC;

internal class Program
{
    static void Main(string[] args)
    {
        // Way 1
        //HttpRequest request1 = BuilderPattern3.HttpRequestBuilder.GetBuilder()
        //    .SetMethod("POST")
        //    .SetUrl("https://api.example.com/orders")
        //    .AddHeader("Authorization", "Bearer abc123")
        //    .AddHeader("Content-Type", "application/json")
        //    .SetBody("{\"product\": \"Laptop\", \"quantity\": 1}")
        //    .Build();

        //Console.WriteLine(request1);

        // Way 2
        var builder = new BuilderPattern3.Version2.HttpRequestBuilder();
        HttpRequest request2 = builder.Configure(options =>
        {
            options.Method = "POST";
            options.Url = "https://api.example.com/orders";
            options.Headers["Authorization"] = "Bearer abc123";
            options.Headers["Content-Type"] = "application/json";
            options.Body = "{\"product\": \"Laptop\", \"quantity\": 1}";
        }).Build();

        // Way 3
        HttpRequest request3 = new HttpRequest()
        {
            Method = "POST",
            Url = "https://api.example.com/orders",
            Body = "{\"product\": \"Laptop\", \"quantity\": 1}",
            Headers = new Dictionary<string, string>()
        };

        Console.WriteLine(request2);

        Console.WriteLine("Hello, World!");
        Console.ReadKey();

    }
}
