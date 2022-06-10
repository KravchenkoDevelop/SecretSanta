using BLL;
using Service.API.Repositories;

namespace Service.API.Controllers
{
    public partial class PersonController : ApiBaseController
    {
        public PersonController(IEventService eventService, IPersonService personService, ISecretSantaRepository secretSantaRepository) : base(eventService, personService, secretSantaRepository)
        {
        }


    }
}
