using DesignPatterns.GangOfFour.Adapter.Adaptees;
using DesignPatterns.GangOfFour.Adapter.Service;
using System;

namespace DesignPatterns.GangOfFour.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClientCallerService httpService = new HttpClientCallerService(new DefaultHttpClientCaller());

            string defaultResponse = httpService.GET("http://www.google.com.tr", "", null, "");

            httpService = new HttpClientCallerService(new MockHttpClientCaller());

            string mockResponse = httpService.GET("http://www.google.com.tr", "", null, "");
        }
    }
}
