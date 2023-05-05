using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Repository;
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
              options => options.UseSqlServer(builder.Configuration.GetConnectionString("localDb"))
              //options => options.UseSqlServer(builder.Configuration.GetConnectionString("azureDb"))
        );

builder.Services.AddScoped<IProfilRepository, ProfilRepository>();

builder.Services.AddScoped<IAbriRepository, AbriRepository>();
builder.Services.AddScoped<IAbriService, AbriService>();

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
