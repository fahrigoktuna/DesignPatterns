using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using DesignPatterns.GangOfFour.Builder;

namespace DesignPatterns.GangOfFour.Host
{
    public class KestrelHost : IHost
    {
        private readonly IWebHost _webHost;
        public KestrelHost(IWebHost webHost)
        {
            _webHost = webHost;
        }
        public void Run() => _webHost.Run();

        public static HostBuilder Create<TStartup>() where TStartup : class
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();
            var webHostBuilder = WebHost.CreateDefaultBuilder()
                .UseConfiguration(config)
                .UseStartup<TStartup>();

            return new HostBuilder(webHostBuilder.Build());
        }
    }
}
