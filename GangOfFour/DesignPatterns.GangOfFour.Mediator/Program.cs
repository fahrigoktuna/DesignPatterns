using DesignPatterns.GangOfFour.Mediator.TempEvents;
using System;

namespace DesignPatterns.GangOfFour.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator.Mediator _med = new Mediator.Mediator();

            _med.Send<TempEvent1>(new TempEvent1() { PropName = "Mediator - Event1" });

            Console.Read();
        }
    }
}
