using BLL.Abstracts;
using DAL.Models;
using SecretSantaGenerator.DM.Models;
using System;

namespace SecretSantaGenerator.BLL
{
    public partial class EventService : IEventService
    {
        public Event CreateEvent(EventModel newEvent)
        {
            throw new NotImplementedException();
        }

        public Event EditEvent(Guid id, EventModel updEvent)
        {
            throw new NotImplementedException();
        }

        public Event DeleteEvent(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SendNotification()
        {
            throw new NotImplementedException();
        }
    }
}