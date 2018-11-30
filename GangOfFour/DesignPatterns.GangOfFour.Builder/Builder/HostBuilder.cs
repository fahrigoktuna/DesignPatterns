using Microsoft.AspNetCore.Hosting;
using DesignPatterns.GangOfFour.Host;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Builder
{
    public class HostBuilder
    {
        private readonly IWebHost _webHost;
        public HostBuilder(IWebHost webHost)
        {
            _webHost = webHost;
        }

        public KestrelHost BuildHost()
        {
            return new KestrelHost(_webHost);
        }
    }
}
