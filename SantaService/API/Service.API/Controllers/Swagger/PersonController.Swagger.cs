using System.Web.Http;

namespace Service.API.Controllers
{
    /// <summary>
    /// Persons
    /// </summary>
    public partial class PersonController : ApiBaseController
    {
        /// <summary>
        /// test doc
        /// </summary>
        /// <returns></returns>
        public partial Task GetAllPersonsListAsync();

        public partial Task GetRandomPersonsListAsync();

    }
}
