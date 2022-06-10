using BLL;
using DryIoc;
using DryIoc.WebApi;
using Service.API.Repositories;
using System.Web.Http;

namespace Service.API
{
    public static class IoCContainer
    {
        public static IContainer RegisterServices(this HttpConfiguration config)
        {
            var container = new Container().WithWebApi(config);
            ///register repository
            container.Register<ISecretSantaRepository, SecretSantaRepository>();

            ///register services
            container.Register<IEventService, EventService>();
            container.Register<IPersonService, PersonService>();
            container.Register<ITenantService, TenantService>();
            

            return container;
        }
    }
}