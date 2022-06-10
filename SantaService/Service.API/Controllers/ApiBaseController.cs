using BLL;
using Microsoft.AspNetCore.Mvc;
using Service.API.Repositories;

namespace Service.API.Controllers
{
    public class ApiBaseController : ControllerBase
    {
        private IEventService _eventService;
        private IPersonService _personService;
        private ISecretSantaRepository _secretSantaRepository;

        public ApiBaseController(IEventService eventService, IPersonService personService, ISecretSantaRepository secretSantaRepository)
        {
            _eventService = eventService;
            _personService = personService;
            _secretSantaRepository = secretSantaRepository;
        }
    }
}