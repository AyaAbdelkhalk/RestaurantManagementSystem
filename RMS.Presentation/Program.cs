using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
using RMS.Infrastructure;
using RMS.Infrastructure.Repository;
using RMS.Application.Services;
using RMS.Application.Services.CategoryService;
using RMS.Application.Services.CouponService;
using RMS.Application.Services.UserService;
using RMS.Application.Services.OrderService;
using RMS.Application.Services.OrderItemService;
using RMS.Application.Services.TableService;
using RMS.Application.Services.MenuItemService;
using RMS.Application.Services.ReservationService;
namespace RMS.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Register Repositories
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICouponRepository, CouponRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            builder.Services.AddScoped<IMenuItemRepository, MenuItemRepository>();
            builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
            builder.Services.AddScoped<ITableRepository, TableRepository>();

            builder.Services.AddScoped<RMSDbContext, RMSDbContext>();

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




            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

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
