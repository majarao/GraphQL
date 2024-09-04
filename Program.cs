using GraphQL.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddContext()
    .AddAppGraphQL();

builder.Services.AddCors();

WebApplication app = builder.Build();

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

app.MapGraphQL();

app.Run();