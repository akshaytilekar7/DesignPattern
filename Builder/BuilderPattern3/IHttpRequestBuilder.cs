using BuilderPattern3.Model;
namespace BuilderPattern3;

public interface IHttpRequestBuilder
{
    IHttpRequestBuilder SetMethod(string method);
    IHttpRequestBuilder SetUrl(string url);
    IHttpRequestBuilder AddHeader(string key, string value);
    IHttpRequestBuilder SetBody(string body);
    HttpRequest Build();
}
