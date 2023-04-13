using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DI2P5G2_BackendDbContext>(
              options => options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase"))
        );

builder.Services.AddScoped<IProfilRepository, ProfilRepository>();

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
