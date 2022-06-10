using DM.Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public partial class EventService : IEventService
    {
        public Task<Event> ReadEvent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> WatchEvents(DateTime filterDate)
        {
            throw new NotImplementedException();
        }
    }
}