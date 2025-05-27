using App.src.SOLID.L.Users.Event.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace App.src.SOLID.L.Users.Event;
public class EventDispatcherConsole : IEventDispatcher
{
    public void Publish(IDomainEvent domainEvent)
    {
        Console.WriteLine($"[Event] {domainEvent.GetType().Name} occurred at {domainEvent.DateOccurrence}: {JsonSerializer.Serialize(domainEvent)}");
    }
}
