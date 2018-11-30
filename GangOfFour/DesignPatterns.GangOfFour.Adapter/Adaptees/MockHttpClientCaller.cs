using DesignPatterns.GangOfFour.Adapter.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Adapter.Adaptees
{
    public class MockHttpClientCaller : IHttpClientCaller
    {
        public string GET(string url, string requestBody, Dictionary<string, string> httpHeaders, string contentType)
        {
            return "Mock Json Object";
        }

        public string POST(string url, string requestBody, string contentType)
        {
            return "Mock Json Object";
        }
    }
}
