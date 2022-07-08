using Service.API.Repositories;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Service.API
{
    public static class IoCContainer
    {
        public static void RegisterMyServices(this IRegistrator registrator)
        {
            //register swagger
            registrator.Register<ISwaggerProvider, SwaggerGenerator>(Reuse.Transient);
            registrator.Register<ISchemaGenerator, SchemaGenerator>(Reuse.Transient);

            //register repository
            registrator.Register<ISecretSantaRepository, SecretSantaRepository>(Reuse.Scoped);

            //register services
            registrator.Register<IEventService, EventService>(Reuse.Scoped);
            registrator.Register<IPersonService, PersonService>(Reuse.Scoped);
            registrator.Register<ITenantService, TenantService>(Reuse.Scoped);
            registrator.Register<IRandomService, RandomService>(Reuse.Scoped);
        }
    }
}