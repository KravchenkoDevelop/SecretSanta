using DM.Models;

namespace BLL
{
    public partial class PersonService : IPersonService
    {
        public async Task<IEnumerable<Person>> GetPersons()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePerson(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}