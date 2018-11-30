using DesignPatterns.GangOfFour.Adapter.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Adapter.Service
{
    public class HttpClientCallerService : IHttpClientCaller
    {
        public IHttpClientCaller _httpClientCaller { get; set; }
        public HttpClientCallerService(IHttpClientCaller httpClientCaller)
        {
            _httpClientCaller = httpClientCaller;
        }

        string IHttpClientCaller.POST(string url, string requestBody, string contentType)
        {
            return _httpClientCaller.POST(url,requestBody,contentType);
        }

        public string GET(string url, string requestBody, Dictionary<string, string> httpHeaders, string contentType)
        {
            return _httpClientCaller.GET(url, requestBody, httpHeaders, contentType);
        }
    }
}
