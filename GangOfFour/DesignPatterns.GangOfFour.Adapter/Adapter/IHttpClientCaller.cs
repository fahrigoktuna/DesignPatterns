using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatterns.GangOfFour.Adapter.Adapter
{
    public interface IHttpClientCaller
    {
        string POST(string url, string requestBody, string contentType);

        string GET(string url, string requestBody, Dictionary<string, string> httpHeaders, string contentType);
    }
}
