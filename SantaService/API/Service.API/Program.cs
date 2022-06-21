var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(o =>
{
    o.SwaggerDoc($"v1", new OpenApiInfo { Title = "API Secret Santa Generator", Version = "v1" });
    o.IncludeXmlComments($".\\bin\\Service.API.xml");
});
builder.Services.AddMvc().AddApplicationPart(Assembly.Load(new AssemblyName("Service.API")));
builder.Services.AddCors();
builder.WebHost.UseIISIntegration();

// DI register.
var container = new Container(r => r.With(propertiesAndFields: req => req.ServiceType.Name.EndsWith("Controller") ? PropertiesAndFields.Properties()(req) : null));
builder.Host.UseServiceProviderFactory(new DryIocServiceProviderFactory(container));
builder.Host.UseContentRoot(Directory.GetCurrentDirectory());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseSwagger(o =>
{
    o.SerializeAsV2 = true;
});
app.UseSwaggerUI(o =>
{
    o.SwaggerEndpoint("swagger.json", "API Secret Santa Generator v1");
    o.RoutePrefix = "api-docs";
});

app.Run();
