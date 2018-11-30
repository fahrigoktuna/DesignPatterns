using DesignPatterns.GangOfFour.Mediator.TempEvents;

namespace DesignPatterns.GangOfFour.Mediator.TempEventHandlers
{
    public interface IEventHandler<T> where T : IEvent
    {
        void Handle(T @event);
    }
}
