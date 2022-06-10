using DAL.Models;
using DM.Models;

namespace BLL
{
    /// <summary>
    ///     person functions
    /// </summary>
    public interface IPersonService
    {
        /// <summary>
        ///     register person for event
        /// </summary>
        /// <param name="personView">person from form</param>
        /// <returns></returns>
        public Task<Person> RegisterPerson(PersonModel personView);

        /// <summary>
        ///     update person
        /// </summary>
        /// <param name="id">person id</param>
        /// <param name="personView">updated data from form</param>
        /// <returns></returns>
        public Task<Person> UpdatePerson(Guid id, PersonModel personView);

        /// <summary>
        ///     get person by id
        /// </summary>
        /// <param name="id">person id</param>
        /// <returns></returns>
        public Task<Person> GetPerson(Guid id);

        /// <summary>
        ///     get persons list
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Person>> GetPersons();

        /// <summary>
        ///     delete person
        /// </summary>
        /// <param name="id">person id</param>
        /// <returns></returns>
        public Task<bool> DeletePerson(Guid id);

        public Task<Person> BindingPersonToTenant(Guid tenantId);

    }
}