var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

builder.WebHost.UseIISIntegration();

// DI register.
var container = new Container(r => r.With(propertiesAndFields: req => req.ServiceType.Name.EndsWith("Controller") ? PropertiesAndFields.Properties()(req) : null));
builder.Host.UseServiceProviderFactory(new DryIocServiceProviderFactory(container));
builder.Host.UseContentRoot(Directory.GetCurrentDirectory());

var app = builder.Build();

startup.Configure(app);

app.Run();
