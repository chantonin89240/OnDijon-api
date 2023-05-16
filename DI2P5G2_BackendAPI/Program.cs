using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Repository;
using DI2P5G2_Backend.Repository.interfaces;
using DI2P5G2_Backend.Repository.Interfaces;
using DI2P5G2_Backend.Services;
using DI2P5G2_Backend.Services.Interfaces;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DI2P5G2_BackendDbContext>(
              options => options.UseSqlServer(builder.Configuration.GetConnectionString("AzureDb"))
              //options => options.UseSqlServer(builder.Configuration.GetConnectionString("azureDb"))
        );

builder.Services.AddScoped<IProfilRepository, ProfilRepository>();


builder.Services.AddScoped<ISensorErrorRepository, SensorErrorRepository>();

// AddScope des ShelterState
builder.Services.AddScoped<IShelterStateRepository, ShelterStateRepository>();
builder.Services.AddScoped<IShelterStateService, ShelterStateService>();

// AddScope des Favoris
builder.Services.AddScoped<IFavorisRepository, FavorisRepository>();
builder.Services.AddScoped<IFavorisService, FavorisService>();

// AddScope d'Abris
builder.Services.AddScoped<IAbriRepository, AbriRepository>();
builder.Services.AddScoped<IAbriService, AbriService>();

//var context = builder.Services.BuildServiceProvider().GetRequiredService<DI2P5G2_BackendDbContext>();
//context.Database.EnsureDeleted();
//context.Database.EnsureCreated();




var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
