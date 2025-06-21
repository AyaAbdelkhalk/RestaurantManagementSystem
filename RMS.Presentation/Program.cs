using Hangfire;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RMS.Application.Helper;
using RMS.Application.Interfaces;
using RMS.Application.Services;
using RMS.Application.Services.CategoryService;
using RMS.Application.Services.CouponService;
using RMS.Application.Services.MenuItemService;
using RMS.Application.Services.OrderItemService;
using RMS.Application.Services.OrderService;
using RMS.Application.Services.ReservationService;
using RMS.Application.Services.TableService;
using RMS.Application.Services.UserService;
using RMS.Core.Models;
using RMS.Infrastructure;
using RMS.Infrastructure.Repository;
namespace RMS.Presentation
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            TypeAdapterConfig.GlobalSettings.Scan(typeof(Program).Assembly);
            Mapper.RegisterMapsterConfiguration();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Hangfire configuration
            builder.Services.AddHangfire(config =>
                config.UseSqlServerStorage(builder.Configuration.GetConnectionString("HangfireDBV0")));

            builder.Services.AddHangfireServer();

            #region Register R&S
            //Register Repositories
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICouponRepository, CouponRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            builder.Services.AddScoped<IMenuItemRepository, MenuItemRepository>();
            builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
            builder.Services.AddScoped<ITableRepository, TableRepository>();

            //builder.Services.AddScoped<RMSDbContext, RMSDbContext>();

            // Register the DbContext 
            builder.Services.AddDbContext<RMSDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("RMSConnection")));

            //Register Services
            builder.Services.AddScoped<ICategoryServices, CategoryServices>();
            builder.Services.AddScoped<ICouponServices, CouponServices>();
            builder.Services.AddScoped<IUserServices, UserServices>();
            builder.Services.AddScoped<IOrderServices, OrderServices>();
            builder.Services.AddScoped<IOrderItemServices, OrderItemServices>();
            builder.Services.AddScoped<IMenuItemServices, MenuItemServices>();
            builder.Services.AddScoped<IReservationServices, ReservationServices>();
            builder.Services.AddScoped<ITableServices, TableServices>();
            builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

            #endregion

            #region Identity&SeedData
            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;

            }).AddEntityFrameworkStores<RMSDbContext>()
                    .AddDefaultTokenProviders();
            builder.Services.AddHttpContextAccessor();

            var app = builder.Build();
            //Seed data
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<RMSDbContext>();
                var userManager = services.GetRequiredService<UserManager<User>>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                await DbInitializer.SeedAsync(context, userManager, roleManager);
            } 
            #endregion

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseHangfireDashboard();
            //app.UseHangfireDashboard("/hangfire");
            app.MapGet("/test-job", () =>
            {
                BackgroundJob.Enqueue(() => Console.WriteLine("Hello from Hangfire!"));
                return "Job Added!";
            });
            RecurringJob.AddOrUpdate<IMenuItemServices>(
                "daily-menuitem-reset",
                service => service.ResetDailyAvailabilityAsync(),
                Cron.Daily(0, 0)); 
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
