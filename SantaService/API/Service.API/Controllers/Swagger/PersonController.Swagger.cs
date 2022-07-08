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
        public partial Task<IHttpActionResult> GetAllPersonsListAsync();

        /// <summary>
        /// sandbox
        /// </summary>
        /// <returns></returns>
        public partial Task<IHttpActionResult> GetRandomPersonsListAsync();

    }
}
