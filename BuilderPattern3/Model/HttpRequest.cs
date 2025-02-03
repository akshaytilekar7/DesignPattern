using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern3.Model;

public class HttpRequest
{
    public string Url { get; set; } = "";
    public string Method { get; set; } = "GET";
    public Dictionary<string, string> Headers { get; set; } = new();
    public string Body { get; set; } = "";

    public override string ToString()
    {
        string headers = string.Join("\n", Headers.Select(h => $"{h.Key}: {h.Value}"));
        return $"Method: {Method}\nURL: {Url}\nHeaders:\n{headers}\nBody:\n{Body}";
    }
}
