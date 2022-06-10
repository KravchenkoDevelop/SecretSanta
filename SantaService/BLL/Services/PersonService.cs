using DAL.Models;
using DM.Models;

namespace BLL
{
    public partial class PersonService : IPersonService
    {
        public Task<Person> RegisterPerson(PersonModel personView)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdatePerson(Guid id, PersonModel personView)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetPerson(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> BindingPersonToTenant(Guid tenantId)
        {
            throw new NotImplementedException();
        }
    }
}