using BuilderPattern3.Model;

namespace BuilderPattern3.Version2;

public interface IHttpRequestBuilder
{
    IHttpRequestBuilder Configure(Action<HttpRequest> configure);
    HttpRequest Build();
}
