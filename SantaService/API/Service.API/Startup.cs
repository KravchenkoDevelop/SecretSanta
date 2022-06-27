using System.Configuration;

namespace Service.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddApplicationPart(Assembly.Load(new AssemblyName("Service.API"))); ;
            services.AddControllers();
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc($"v1", new OpenApiInfo { Title = "API Secret Santa Generator", Version = "v1" });
                o.IncludeXmlComments($".\\bin\\Service.API.xml");
            });
            services.AddCors();

            services.AddEndpointsApiExplorer();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseSwagger(o =>
            {
                o.RouteTemplate = "api-docs/{documentName}/swagger.json";
                o.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(o =>
            {
                o.SwaggerEndpoint("v1/swagger.json", "API Secret Santa Generator v1");
                o.RoutePrefix = "api-docs";
            });

        }
    }
}
