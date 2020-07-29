using NetDevPack.Messaging;

namespace Neurotech.Domain.Core.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
