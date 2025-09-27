using CKK.DB.Interfaces;
using CKK.DB.UOW;
using CKK.Web.Components;

namespace CKK.Web {
    public class Program {
        public static void Main(string [] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddScoped<DatabaseConnectionFactory>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(sp =>
            {
                var factory = sp.GetRequiredService<DatabaseConnectionFactory>();
                return new UnitOfWork(factory);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if( !app.Environment.IsDevelopment() ) {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
