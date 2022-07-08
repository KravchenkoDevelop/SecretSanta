using Service.API.Repositories;
using System.Web.Http;

namespace Service.API.Controllers
{
    public partial class PersonController : ApiBaseController
    {
        private ISecretSantaRepository _secretSantaRepository;

        public PersonController(ISecretSantaRepository secretSantaRepository)
        {
            _secretSantaRepository = secretSantaRepository;
        }

        [Route("/personsList")]
        [HttpGet]
        public partial async Task<IHttpActionResult> GetAllPersonsListAsync()
        {
            return Ok();
        }
        
        [Route("/sandBox")]
        [HttpGet]
        public partial async Task<IHttpActionResult> GetRandomPersonsListAsync()
        {
            var result = _secretSantaRepository.GetPersonsListAsync();

            return Ok(result);
        }

    }
}
