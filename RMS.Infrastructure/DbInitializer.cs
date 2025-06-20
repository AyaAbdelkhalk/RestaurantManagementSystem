using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RMS.Core.Enum;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(RMSDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            await context.Database.MigrateAsync();

            // 1. Roles
            string[] roles = { "Admin", "Staff", "Customer" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            // 2. Users
            var users = new List<(string UserName, string Email, string Password, string Role, StaffPosition? staffPosition)>
            {
                ("AyaKhaled", "aya.khaled@example.com", "User@123", "Customer", null),
                ("DohaEzzat", "doha.ezzat@example.com", "User@123", "Customer", null),
                ("JameelaAbdulrahman", "jameela.abdulrahman@example.com", "User@123", "Customer", null),
                ("ShimaaMohamed", "shimaa.mohamed@example.com", "123456", "Customer", null),

                ("KarimElShenawy", "karim.elshenawy@rms.com", "User@123", "Staff", StaffPosition.Waiter),
                ("LailaHassan", "laila.hassan@rms.com", "User@123", "Staff", StaffPosition.Chef),
                ("MohamedTarek", "mohamed.tarek@rms.com", "User@123", "Staff", StaffPosition.Manager),
                ("SaraMostafa", "sara.mostafa@rms.com", "User@123", "Staff", StaffPosition.Cashier),

                ("AdminRMS", "admin@rms.com", "Admin@123", "Admin", StaffPosition.Manager)
            };
            var userIdMap = new Dictionary<string, string>();
            foreach (var u in users)
            {
                var existingUser = await userManager.FindByEmailAsync(u.Email);
                if (existingUser == null)
                {
                    var newId = Guid.NewGuid().ToString();
                    var user = new User
                    {
                        Id = newId,
                        UserName = u.UserName,
                        Email = u.Email,
                        EmailConfirmed = true,
                        StaffPosition = u.staffPosition
                    };

                    var result = await userManager.CreateAsync(user, u.Password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, u.Role);
                        userIdMap.Add(u.Email, newId);

                    }
                    
                }
                else
                {
                    userIdMap.Add(u.Email, existingUser.Id);
                }
            }
            await context.SaveChangesAsync();

            // 3. Categories
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new() { /*CategoryId = 1,*/ Name = "Appetizers",IsActive=true },
                    new() { /*CategoryId = 2,*/ Name = "Main Dishes", Description = "Main dishes including burgers and pizzas" },
                    new() { /*CategoryId = 3,*/ Name = "Desserts" },
                    new() { /*CategoryId = 4,*/ Name = "Drinks", Description = "Beverages including soft drinks and juices" }
                };
                context.Categories.AddRange(categories);
            }
            await context.SaveChangesAsync();

            // 4. MenuItems
            if (!context.MenuItems.Any())
            {
                var menuItems = new List<MenuItem>
                {
                    new() { /*MenuItemId = 1,*/ Name = "Spring Rolls", UnitPrice = 5.99m, CategoryId = 13, IsAvailable = true },
                    new() { /*MenuItemId = 2,*/ Name = "Caesar Salad", UnitPrice = 7.99m, CategoryId = 13, IsAvailable = true },
                    new() { /*MenuItemId = 3,*/ Name = "Grilled Chicken", UnitPrice = 12.99m, CategoryId = 14, IsAvailable = true },
                    new() { /*MenuItemId = 4,*/ Name = "Chocolate Cake", UnitPrice = 4.99m, CategoryId = 15, IsAvailable = true },
                    new() { /*MenuItemId = 5,*/ Name = "Coca Cola", UnitPrice = 1.99m, CategoryId = 16, IsAvailable = true },
                    new() { /*MenuItemId = 6,*/ Name = "Cheesecake", UnitPrice = 6.50m, CategoryId = 15, IsAvailable = true },
                    new() { /*MenuItemId = 7,*/ Name = "Mango Juice", UnitPrice = 3.99m, CategoryId = 16, IsAvailable = true },
                    new() { /*MenuItemId = 8,*/ Name = "Spaghetti Carbonara", UnitPrice = 10.99m, CategoryId = 14, IsAvailable = true },
                    new() { /*MenuItemId = 9,*/ Name = "Vegetable Stir Fry", UnitPrice = 8.99m, CategoryId = 14, IsAvailable = true }
                };
                context.MenuItems.AddRange(menuItems);
            }
            await context.SaveChangesAsync();

            // 5. Tables
            if (!context.Tables.Any())
            {
                var tables = new List<Table>
                {
                    new() { /*TableId = 1,*/ TableNumber = 1, Capacity = 4, IsAvailable = false },
                    new() { /*TableId = 2,*/ TableNumber = 2, Capacity = 2, IsAvailable = false },
                    new() { /*TableId = 3,*/ TableNumber = 3, Capacity = 6 },
                    new() { /*TableId = 4,*/ TableNumber = 4, Capacity = 8 }
                };
                context.Tables.AddRange(tables);
                await context.SaveChangesAsync();

            }

            // 6. Coupons
            if (!context.Coupons.Any())
            {
                var coupons = new List<Coupon>
                {
                    new() { /*CouponId = 1,*/ Code = "HAPPYHOUR20", DiscountPercentage = 20, IsActive = true },
                    new() { /*CouponId = 2,*/ Code = "BIGORDER10", DiscountPercentage = 10, IsActive = true },
                    new() { /*CouponId = 3,*/ Code = "STUDENT10", DiscountPercentage = 10, IsActive = true },
                    new() { /*CouponId = 4,*/ Code = "SENIOR15", DiscountPercentage = 15, IsActive = true }
                };
                context.Coupons.AddRange(coupons);
                await context.SaveChangesAsync();

            }

            // 7. Orders
            if (!context.Orders.Any())
            {
                var orders = new List<Order>
                {
                    new() { /*OrderId = 1,*/ CustomerId = userIdMap["aya.khaled@example.com"], OrderStatus = OrderStatus.Pending, OrderType = OrderType.DineIn, TableId = 13, Note = "No onions", TotalBeforeDiscounts = 20, Total = 20 },
                    new() { /*OrderId = 2,*/ CustomerId = userIdMap["doha.ezzat@example.com"], OrderStatus = OrderStatus.Ready, OrderType = OrderType.TakeOut, TotalBeforeDiscounts = 15, Total = 15 },
                    new() { /*OrderId = 3,*/ CustomerId = userIdMap["jameela.abdulrahman@example.com"], OrderStatus = OrderStatus.Delivered, OrderType = OrderType.Delivery, TotalBeforeDiscounts = 30, Total = 30 },
                    new() { /*OrderId = 4,*/ CustomerId = userIdMap["aya.khaled@example.com"], OrderStatus = OrderStatus.Pending, OrderType = OrderType.DineIn,TableId=14, TotalBeforeDiscounts = 20, Total = 20 },
                    new() { /*OrderId = 5,*/ CustomerId = userIdMap["doha.ezzat@example.com"], OrderStatus = OrderStatus.Pending, OrderType = OrderType.Delivery, Note = "Please ring the bell", DeliveryAddress = "123 Main St", TotalBeforeDiscounts = 25, Total = 22.5m }
                };
                context.Orders.AddRange(orders);
                await context.SaveChangesAsync();
            }
            // 8. OrderItems
            if (!context.OrderItems.Any())
            {
                var orderItems = new List<OrderItem>
                {
                    new() { /*Id = 1,*/ OrderId = 10, MenuItemId = 13, Quantity = 2 },
                    new() { /*Id = 2,*/ OrderId = 10, MenuItemId = 16, Quantity = 1 },
                    new() { /*Id = 3,*/ OrderId = 11, MenuItemId = 14, Quantity = 1 },
                    new() { /*Id = 4,*/ OrderId = 11, MenuItemId = 17, Quantity = 2 },
                    new() { /*Id = 5,*/ OrderId = 12, MenuItemId = 16, Quantity = 1 },
                    new() { /*Id = 6,*/ OrderId = 12, MenuItemId = 18, Quantity = 1 }
                };
                context.OrderItems.AddRange(orderItems);
                await context.SaveChangesAsync();

            }

            // 9. Reservations
            if (!context.Reservations.Any())
            {
                var reservations = new List<Reservation>
                {
                    new() { /*ReservationId = 1,*/ CustomerId = userIdMap["doha.ezzat@example.com"], TableId = 14, NumberOfGuests = 2, StartTime = new DateTime(2025, 6, 7, 13, 0, 0), DurationInMinutes = 90, SpecialRequests = "Window seat please", ReservationStatus = ReservationStatus.Confirmed },
                    new() { /*ReservationId = 2,*/ CustomerId = userIdMap["doha.ezzat@example.com"], TableId = 14, NumberOfGuests = 2, StartTime = new DateTime(2025, 6, 7, 15, 0, 0), DurationInMinutes = 90, SpecialRequests = "Quiet area", ReservationStatus = ReservationStatus.Pending, AssignedStaffId = userIdMap["laila.hassan@rms.com"] },
                    new() { /*ReservationId = 3,*/ CustomerId = userIdMap["aya.khaled@example.com"], TableId = 13, NumberOfGuests = 4, StartTime = new DateTime(2025, 6, 7, 14, 0, 0), DurationInMinutes = 60, SpecialRequests = "Window seat", ReservationStatus = ReservationStatus.Confirmed, AssignedStaffId = userIdMap["karim.elshenawy@rms.com"] }
                };
                context.Reservations.AddRange(reservations);
                await context.SaveChangesAsync();

            }

            if (context.ChangeTracker.HasChanges())
            {
                await context.SaveChangesAsync();
            }

        }
    }
}
