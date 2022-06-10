using BLL.Abstracts;
using DAL.Models;
using DM.Models;

namespace SecretSantaGenerator.BLL
{
    public partial class EventService : IEventService
    {
        public Task<Event> CreateEvent(EventModel newEvent)
        {
            throw new NotImplementedException();
        }

        public Task<Event> EditEvent(Guid id, EventModel updEvent)
        {
            throw new NotImplementedException();
        }

        public Task<Event> DeleteEvent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task SendNotification()
        {
            throw new NotImplementedException();
        }
    }
}