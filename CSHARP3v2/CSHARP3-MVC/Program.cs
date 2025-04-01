using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CSHARP3_MVC.Data;
using CSHARP3_MVC.Areas.Identity.Data;

namespace CSHARP3_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Connection string voor gebruikersbeheer (Identity)
            var identityConnectionString = builder.Configuration.GetConnectionString("CSHARP3_MVCContextConnection")
                ?? throw new InvalidOperationException("Connection string 'CSHARP3_MVCContextConnection' not found.");

            builder.Services.AddDbContext<CSHARP3_MVCContext>(options =>
                options.UseSqlServer(identityConnectionString));

            builder.Services.AddDefaultIdentity<CSHARP3_MVCUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<CSHARP3_MVCContext>();

            // Connection string voor PlatenzaakContext (Productbeheer)
            var platenzaakConnectionString = builder.Configuration.GetConnectionString("JochemConnectie")
                ?? throw new InvalidOperationException("Connection string 'PlatenzaakContextConnection' not found.");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(platenzaakConnectionString));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // ?? Zorg ervoor dat Identity correct werkt!
            app.UseAuthorization();

            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Database migraties toepassen bij opstarten
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var platenzaakContext = services.GetRequiredService<ApplicationDbContext>();
                platenzaakContext.Database.Migrate();

                var identityContext = services.GetRequiredService<CSHARP3_MVCContext>();
                identityContext.Database.Migrate();
            }

            app.Run();
        }
    }
}
