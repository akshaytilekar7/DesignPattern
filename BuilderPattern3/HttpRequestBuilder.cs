using BuilderPattern3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern3;

public  class HttpRequestBuilder : IHttpRequestBuilder
{
    private HttpRequest _request = new HttpRequest();

    public static IHttpRequestBuilder GetBuilder()
    {
        return new HttpRequestBuilder();
    }
    public IHttpRequestBuilder SetMethod(string method)
    {
        _request.Method = method;
        return this;
    }

    public IHttpRequestBuilder SetUrl(string url)
    {
        _request.Url = url;
        return this;
    }

    public IHttpRequestBuilder AddHeader(string key, string value)
    {
        _request.Headers[key] = value;
        return this;
    }

    public IHttpRequestBuilder SetBody(string body)
    {
        _request.Body = body;
        return this;
    }

    public HttpRequest Build()
    {
        return _request;
    }
}
