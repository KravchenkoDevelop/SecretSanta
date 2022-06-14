// DI register.
var container = new Container(r => r.With(propertiesAndFields: r => r.ServiceType.Name.EndsWith("Controller") ? PropertiesAndFields.Properties()(r) : null));
container.RegisterMyServices();
WebApplication.CreateBuilder(args).Host.UseServiceProviderFactory(new DryIocServiceProviderFactory(container));
WebApplication.CreateBuilder(args).Host.UseContentRoot(Directory.GetCurrentDirectory());

WebApplication.CreateBuilder(args).WebHost.UseIISIntegration();

WebApplication.CreateBuilder(args).Services.AddControllers();
WebApplication.CreateBuilder(args).Services.AddMvc().AddApplicationPart(Assembly.Load(new AssemblyName("Service.API")));
WebApplication.CreateBuilder(args).Services.AddEndpointsApiExplorer();
WebApplication.CreateBuilder(args).Services.AddSwaggerGen(c =>
{
    c.IncludeXmlComments(StartupServices.GetApiXMLDirectory());
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SecretSanta", Version = $"{Assembly.GetEntryAssembly().GetName().Version}" });
    c.EnableAnnotations();
});

var app = WebApplication.CreateBuilder(args).Build();

// Configure the HTTP request pipeline.
app.UseSwagger(o =>
{
    o.SerializeAsV2 = true;
    o.RouteTemplate = $"/{Assembly.GetEntryAssembly().GetName().Name}/{Assembly.GetEntryAssembly().GetName().Version}/doc.json";
});

app.UseSwaggerUI(o =>
{
    o.SwaggerEndpoint($"/{Assembly.GetEntryAssembly().GetName().Name}/{Assembly.GetEntryAssembly().GetName().Version}/doc.json", $"API {Assembly.GetEntryAssembly().GetName().Version}");
    o.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.Run();
