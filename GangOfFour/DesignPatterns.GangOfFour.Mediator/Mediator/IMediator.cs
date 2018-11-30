using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Mediator.Mediator
{
    public interface IMediator
    {
        void Send<T>(T sendingObject);
    }
}
