using DAL.Models;
using SecretSantaGenerator.DM.Models;
using System;
using System.Collections.Generic;

namespace BLL.Abstracts
{
    public interface IEventService
    {
        /// <summary>
        ///     watch event by id
        /// </summary>
        /// <param name="id">event id</param>
        /// <returns></returns>
        public Event ReadEvent(Guid id);

        /// <summary>
        ///     get available events
        /// </summary>
        /// <param name="filterDate"></param>
        /// <returns></returns>
        public IEnumerable<Event> WatchEvents(DateTime filterDate);

        /// <summary>
        ///     create new event
        /// </summary>
        /// <param name="newEvent">event from front</param>
        /// <returns></returns>
        public Event CreateEvent(EventModel newEvent);

        /// <summary>
        ///     update event
        /// </summary>
        /// <param name="id">edited event id</param>
        /// <param name="updEvent">new event data</param>
        /// <returns></returns>
        public Event EditEvent(Guid id, EventModel updEvent);

        /// <summary>
        ///     remove event
        /// </summary>
        /// <param name="id">deleting event id</param>
        /// <returns></returns>
        public Event DeleteEvent(Guid id);

        /// <summary>
        ///     send notification email for members
        /// </summary>
        public void SendNotification();
    }
}