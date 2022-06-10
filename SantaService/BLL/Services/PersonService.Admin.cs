using BLL.Abstracts;
using DM.Models;

namespace SecretSantaGenerator.BLL
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