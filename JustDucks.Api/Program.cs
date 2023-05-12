using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(c =>
{
    var corsPolicy = new CorsPolicy();
    builder.Configuration.GetRequiredSection(nameof(CorsPolicy)).Bind(corsPolicy);
    c.AddDefaultPolicy(corsPolicy);
});

//TODO: AddAuthentication
//TODO: AddAuthorization

var app = builder.Build();

app.UseCors();

//TODO: UseAuthentication
//TODO: UseAuthorization

app.MapGet("/", () => "Hello World!");

app.Run();
