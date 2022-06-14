using Service.API.Repositories;

namespace Service.API
{
    public static class IoCContainer
    {
        public static void RegisterMyServices(this IRegistrator r)
        {
            ///register repository
            r.Register<ISecretSantaRepository, SecretSantaRepository>(Reuse.Scoped);

            ///register services
            r.Register<IEventService, EventService>(Reuse.Scoped);
            r.Register<IPersonService, PersonService>(Reuse.Scoped);
            r.Register<ITenantService, TenantService>(Reuse.Scoped);
        }
    }
}