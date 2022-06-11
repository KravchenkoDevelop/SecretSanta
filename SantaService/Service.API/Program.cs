using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.OpenApi.Models;
using Service.API;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
// DI register.
var container = new Container(r => r.With(propertiesAndFields: r => r.ServiceType.Name.EndsWith("Controller") ? PropertiesAndFields.Properties()(r) : null));
container.RegisterMyServices();

builder.Host.UseServiceProviderFactory(new DryIocServiceProviderFactory(container));
builder.Host.UseContentRoot(Directory.GetCurrentDirectory());
builder.WebHost.UseIISIntegration();

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SecretSanta", Version = $"{Assembly.GetEntryAssembly().GetName().Version}" });
    c.EnableAnnotations();
});

var app = builder.Build();
//app.UseAuthorization();
//app.UseAuthentication();

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
app.MapControllers();
app.UseRouting();

app.Run();
