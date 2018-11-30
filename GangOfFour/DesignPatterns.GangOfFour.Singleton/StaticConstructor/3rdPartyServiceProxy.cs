using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Singleton.StaticConstructor
{
    public class _3rdPartyServiceProxy
    {
        private static string ClientUserName
        {
            get { return "return Config UserName"; }

        }

        private static string ClientPassword
        {
            get { return "Decrypt config password and return"; }

        }

        private static string Url
        {
            get { return "return URL"; }

        }

        static _3rdPartyServiceProxy()
        {
            //Automapper mapping and Binding configuration handle in construction only once.
        }

        public object HandleProxyMethod<T>()
        {
            return default(T);
        }
    }
}
