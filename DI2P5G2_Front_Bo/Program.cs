using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<DI2P5G2_BackendDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase"))
            );

builder.Services.AddScoped<IProfilRepository, ProfilRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
//endpoints.MapControllerRoute(
    //name: "createProfil",
    //pattern: "/administration/artiste/create",
    //defaults: new { controller = "Artists", action = "Create" });
});

app.Run();


app.MapRazorPages();

app.Run();
