using BuilderPattern3.Model;

namespace BuilderPattern3.Version2;

public class HttpRequestBuilder : IHttpRequestBuilder
{
    private HttpRequest _request = new HttpRequest();

    public IHttpRequestBuilder Configure(Action<HttpRequest> configure)
    {
        configure(_request);
        return this;
    }

    public HttpRequest Build()
    {
        return _request;
    }
}
