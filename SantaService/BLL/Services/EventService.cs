using BLL.Abstracts;
using SecretSantaGenerator.DM.Models;
using System;
using System.Collections.Generic;

namespace SecretSantaGenerator.BLL
{
    public partial class EventService : IEventService
    {
        public Event ReadEvent(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> WatchEvents(DateTime filterDate)
        {
            throw new NotImplementedException();
        }
    }
}