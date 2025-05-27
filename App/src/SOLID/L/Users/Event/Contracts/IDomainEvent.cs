using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.src.SOLID.L.Users.Event.Contracts;
public interface IDomainEvent
{
    DateTime DateOccurrence { get; }

}
