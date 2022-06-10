using BLL;
using Microsoft.AspNetCore.Mvc;
using Service.API.Repositories;

namespace Service.API.Controllers
{
    [Route("tenant")]
    [ApiController]
    public class TenantController : ApiBaseController
    {
        public TenantController(IEventService eventService, IPersonService personService, ISecretSantaRepository secretSantaRepository) : base(eventService, personService, secretSantaRepository)
        {
        }
    }
}
