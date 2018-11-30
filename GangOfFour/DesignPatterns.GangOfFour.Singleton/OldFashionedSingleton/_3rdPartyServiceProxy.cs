using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Singleton.OldFashionedSingleton
{
   public class _3rdPartyServiceProxy
    {
        private static readonly object _locker = new object();

        private static volatile _3rdPartyServiceProxy _instance = null;

        public static _3rdPartyServiceProxy Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new _3rdPartyServiceProxy();
                        }
                    }
                }

                return _instance;
            }
        }

        private _3rdPartyServiceProxy()
        {
        }

        public object HandleProxyMethod<T>()
        {
            return default(T);
        }
    }
}
