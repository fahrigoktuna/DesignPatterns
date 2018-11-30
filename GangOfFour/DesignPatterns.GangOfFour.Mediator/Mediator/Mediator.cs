using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPatterns.GangOfFour.Mediator.Mediator
{
    public class Mediator : IMediator
    {
        public void Send<T>(T sendingObject)
        {
            foreach (var item in Assembly.GetExecutingAssembly().GetTypes().Where(p => TypeImplementsInterface(p, "IEventHandler`1")).ToList())
                if (sendingObject.GetType() == item.GetInterfaces()[0].GetGenericArguments()[0])
                    item.GetMethod("Handle").Invoke(Activator.CreateInstance(item, null), new object[] { sendingObject });
        }

        private bool TypeImplementsInterface(Type theType, string interfaceName)
        {
            Type interFaceType = theType.GetInterface(interfaceName, true);
            return (interFaceType != null);
        }
    }
}
