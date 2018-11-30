using System;

namespace DesignPatterns.GangOfFour.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LazySingleton._3rdPartyServiceProxy.Instance.HandleProxyMethod<Object>(); // 1

            StaticConstructor._3rdPartyServiceProxy onlyOnceInstance = new StaticConstructor._3rdPartyServiceProxy(); // 2

            onlyOnceInstance.HandleProxyMethod<Object>();

            OldFashionedSingleton._3rdPartyServiceProxy.Instance.HandleProxyMethod<Object>(); // 3
        }
    }
}
