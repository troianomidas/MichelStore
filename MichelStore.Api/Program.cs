using MediatR;
using MichelStore.Application;
using MichelStore.Infrastructure;
using MichelStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(connectionString, x =>
        x.MigrationsAssembly("MichelStore.Api"));
});

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("v1/products/{id}", async (
    ISender sender,
    Guid id,
    CancellationToken cancellationToken) =>
{
    var command = new MichelStore.Application.UseCases.Products.GetById.Command(id);
    var result = await sender.Send(command, cancellationToken);

    return result.IsSuccess ? Results.Ok(result.Value) : Results.BadRequest(result.Error);
});

app.MapPost("v1/products", async (
    ISender sender,
    MichelStore.Application.UseCases.Products.Create.Command command,
    CancellationToken cancellationToken) =>
{
    var result = await sender.Send(command, cancellationToken);

    return result.IsSuccess ? Results.Ok(result.Value) : Results.BadRequest(result.Error);
});

app.Run();