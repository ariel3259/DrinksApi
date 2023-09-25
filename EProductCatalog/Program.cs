using EProductCatalog.Context;
using EProductCatalog.Models;
using EProductCatalog.Repository;
using EProductCatalog.Repository.Interfaces;
using EProductCatalog.Services;
using EProductCatalog.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string? conectionString = builder.Configuration["ConnectionStrings:Dev2"];

if (conectionString == null)
    throw new Exception("Connection string not found");

builder.Services.AddDbContext<ApplicationContext>((options) =>
{
    options.UseSqlServer(conectionString);
}, ServiceLifetime.Transient);

//Repositories
builder.Services.AddTransient<IRepository<DrinkTypes>, DrinkTypesRepository>();

//Services
builder.Services.AddTransient<IDrinkTypesService, DrinkTypesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
