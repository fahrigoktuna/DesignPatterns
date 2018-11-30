using DesignPatterns.GangOfFour.Adapter.Adapter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace DesignPatterns.GangOfFour.Adapter.Adaptees
{
    public class DefaultHttpClientCaller : IHttpClientCaller
    {
        public string GET(string url, string requestBody, Dictionary<string, string> httpHeaders, string contentType)
        {
            Stream responseStream = null;
            var request = WebRequest.Create(url);

            if(httpHeaders!= null && httpHeaders.Count>0)
            foreach (var item in httpHeaders)
                request.Headers.Add(item.Key, item.Value);

            request.Method = "GET";

            request.ContentType = contentType;//@"application/json";

            responseStream = request.GetResponse().GetResponseStream();

            System.IO.StreamReader sr = new System.IO.StreamReader(responseStream);

            return sr.ReadToEnd();
        }

        public string POST(string url, string requestBody, string contentType)
        {
            Stream responseStream = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(requestBody);

            request.ContentLength = byteArray.Length;
            request.ContentType = contentType;

            using (Stream dataStream = request.GetRequestStream())
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);

                responseStream = response.GetResponseStream();

                return new StreamReader(responseStream).ReadToEnd();
            }
        }
    }
}
