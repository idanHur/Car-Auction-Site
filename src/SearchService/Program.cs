using MongoDB.Driver;
using MongoDB.Entities;
using SearchService;
using SearchService.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.MapControllers();

try
{
    await DbInitiallizer.InitDb(app);
}
catch(Exception e)
{
    Console.WriteLine(e);
}

app.Run();
