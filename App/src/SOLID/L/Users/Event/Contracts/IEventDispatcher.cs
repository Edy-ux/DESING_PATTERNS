

namespace App.src.SOLID.L.Users.Event.Contracts;
public interface IEventDispatcher
{
    void Publish(IDomainEvent domainEvent);
}