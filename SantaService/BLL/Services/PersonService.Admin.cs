using BLL.Abstracts;
using SecretSantaGenerator.DM.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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