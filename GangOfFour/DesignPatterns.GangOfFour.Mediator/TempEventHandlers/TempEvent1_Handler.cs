using DesignPatterns.GangOfFour.Mediator.TempEvents;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.GangOfFour.Mediator.TempEventHandlers
{
    public class TempEvent1_Handler : IEventHandler<TempEvent1>
    {
        public void Handle(TempEvent1 @event)
        {
            Console.WriteLine($"TempEvent1 with param &&{@event.PropName}&& handle is running by Handler_1");
        }
    }
}
