using Service.API.Repositories;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace Service.API.Controllers
{
    [Route("tenant")]
    public partial class TenantController : ApiBaseController
    {
        public TenantController(IEventService eventService, IPersonService personService, ISecretSantaRepository secretSantaRepository) : base(eventService, personService, secretSantaRepository)
        {
        }
    }
}
