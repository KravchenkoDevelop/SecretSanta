using DAL.Models;
using DM.Models;

namespace BLL
{
    public interface IEventService
    {
        /// <summary>
        ///     watch event by id
        /// </summary>
        /// <param name="id">event id</param>
        /// <returns></returns>
        public Task<Event> ReadEvent(Guid id);

        /// <summary>
        ///     get available events
        /// </summary>
        /// <param name="filterDate"></param>
        /// <returns></returns>
        public Task<IEnumerable<Event>> WatchEvents(DateTime filterDate);

        /// <summary>
        ///     create new event
        /// </summary>
        /// <param name="newEvent">event from front</param>
        /// <returns></returns>
        public Task<Event> CreateEvent(EventModel newEvent);

        /// <summary>
        ///     update event
        /// </summary>
        /// <param name="id">edited event id</param>
        /// <param name="updEvent">new event data</param>
        /// <returns></returns>
        public Task<Event> EditEvent(Guid id, EventModel updEvent);

        /// <summary>
        ///     remove event
        /// </summary>
        /// <param name="id">deleting event id</param>
        /// <returns></returns>
        public Task<Event> DeleteEvent(Guid id);

        /// <summary>
        ///     send notification email for members
        /// </summary>
        public Task SendNotification();
    }
}