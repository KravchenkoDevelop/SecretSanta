using Service.API.Repositories;
using RouteAttribute = System.Web.Http.RouteAttribute;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Service.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public partial class SantaServiceController : ApiBaseController
    {
        public SantaServiceController(IEventService eventService, IPersonService personService, ISecretSantaRepository secretSantaRepository) : base(eventService, personService, secretSantaRepository)
        {
        }


    }
}
