using Microsoft.AspNetCore.Builder;

namespace DI2P5G2_BackendAPI
{
    public class Startup
    {
        public static WebApplication Initialize(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();



            return app;
        }



        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }



        public static void ConfigureServices(WebApplicationBuilder builder)
        {
        }
    }
}
