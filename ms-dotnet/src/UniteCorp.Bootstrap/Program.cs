using UniteCorp.Persistence;
using UniteCorp.Features;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddFeatures();
builder.Services.AddHealthChecks();
builder.Services.AddControllers().AddApplicationPart(typeof(GeoCercaActividadController).Assembly);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/", () => Results.Ok(new { service = "UniteCorp MsDotnet", status = "running" }))
    .WithName("Root");

app.MapGet("/health", () => Results.Ok(new { status = "ok" }))
    .WithName("Health");

app.MapControllers();

app.Run();
