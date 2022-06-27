using Microsoft.AspNetCore.Mvc;
using Service.API.Repositories;

namespace Service.API.Controllers
{
    [Route("prefix/[controller]")]
    public partial class PersonController : ApiBaseController
    {
        public PersonController(IEventService eventService, IPersonService personService, ISecretSantaRepository secretSantaRepository) : base(eventService, personService, secretSantaRepository)
        {
        }

        [Route("persons/personsList")]
        [HttpGet]
        public partial async Task GetAllPersonsListAsync()
        {
            
        }
    }
}
