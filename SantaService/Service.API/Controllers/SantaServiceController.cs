using Microsoft.AspNetCore.Mvc;
using Service.API.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Service.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public partial class SantaServiceController : ApiBaseController
    {
        public SantaServiceController(IEventService eventService, IPersonService personService, ISecretSantaRepository secretSantaRepository) : base(eventService, personService, secretSantaRepository)
        {
        }


    }
}
