using DesignPatterns.GangOfFour.Host;
using System;

namespace DesignPatterns.GangOfFour.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            KestrelHost.Create<Startup>()
                .BuildHost()
                .Run();
        }
    }
}
