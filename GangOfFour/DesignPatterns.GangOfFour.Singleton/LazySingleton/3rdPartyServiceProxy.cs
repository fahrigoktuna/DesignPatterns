using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Singleton.LazySingleton
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
        private static readonly Lazy<_3rdPartyServiceProxy> _instance
            = new Lazy<_3rdPartyServiceProxy>(() => new _3rdPartyServiceProxy());

        
        private _3rdPartyServiceProxy()
        {
        }

        public static _3rdPartyServiceProxy Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public object HandleProxyMethod<T>()
        {
            return default(T);
        }
    }
}
