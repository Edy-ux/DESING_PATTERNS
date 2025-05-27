using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.src.SOLID.L.Users.Event;
public class UserCreatedEvent : IDomainEvent
{
    public string Name { get; }

    public DateTime DateOccurrence { get; } = DateTime.Now;

    public UserCreatedEvent(string name)
    {
        Name = name;
    }
}