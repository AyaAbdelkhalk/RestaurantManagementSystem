using Microsoft.EntityFrameworkCore;
using RMS.Core.Models;

namespace RMS.Infrastructure
{
    public class RMSDbContext : DbContext
    {
        public RMSDbContext(){}
        public RMSDbContext(DbContextOptions<RMSDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed data
            //Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Appetizers" },
                new Category { CategoryId = 2, Name = "Main Dishes", Description = "Main dishes including burgers and pizzas" },
                new Category { CategoryId = 3, Name = "Desserts" },
                new Category { CategoryId = 4, Name = "Drinks", Description = "Beverages including soft drinks and juices" }
            );
            //MenuItems
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { MenuItemId = 1, Name = "Spring Rolls", UnitPrice = 5.99m, CategoryId = 1, IsAvailable = true },
                new MenuItem { MenuItemId = 2, Name = "Caesar Salad", UnitPrice = 7.99m, CategoryId = 1, IsAvailable = true },
                new MenuItem { MenuItemId = 3, Name = "Grilled Chicken", UnitPrice = 12.99m, CategoryId = 2, IsAvailable = true },
                new MenuItem { MenuItemId = 4, Name = "Chocolate Cake", UnitPrice = 4.99m, CategoryId = 3, IsAvailable = true },
                new MenuItem { MenuItemId = 5, Name = "Coca Cola", UnitPrice = 1.99m, CategoryId = 4, IsAvailable = true },
                new MenuItem { MenuItemId = 6, Name = "Cheesecake", UnitPrice = 6.50m, IsAvailable = true, CategoryId = 3 },
                new MenuItem { MenuItemId = 7, Name = "Mango Juice", UnitPrice = 3.99m, IsAvailable = true, CategoryId = 4 },
                new MenuItem { MenuItemId = 8, Name = "Spaghetti Carbonara", UnitPrice = 10.99m, IsAvailable = true, CategoryId = 2 },
                new MenuItem { MenuItemId = 9, Name = "Vegetable Stir Fry", UnitPrice = 8.99m, IsAvailable = true, CategoryId = 2 }
            );

            ////Tables
            modelBuilder.Entity<Table>().HasData(
                new Table { TableId = 1, TableNumber = 1, Capacity = 4, IsAvailable = false },
                new Table { TableId = 2, TableNumber = 2, Capacity = 2, IsAvailable = false },
                new Table { TableId = 3, TableNumber = 3, Capacity = 6 },
                new Table { TableId = 4, TableNumber = 4, Capacity = 8 }
            );

            //Customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, Name = "Aya Khaled", Email = "aya.khaled@example.com", PhoneNumber = "0100000001" },
                new Customer { CustomerId = 2, Name = "Doha Ezzat", Email = "doha.ezzat@example.com", PhoneNumber = "0100000002" },
                new Customer { CustomerId = 3, Name = "Jameela Abdulrahman", Email = "jameela.abdulrahman@example.com", PhoneNumber = "0100000003" },
                new Customer { CustomerId = 4, Name = "Shimaa Mohamed", Email = "shimaa.mohamed@example.com", PhoneNumber = "0100000004" }
            );

            ////Staff
            modelBuilder.Entity<Staff>().HasData(
                new Staff { StaffId = 1, Name = "Karim ElShenawy", Position = "Waiter", Email = "karim.elshenawy@rms.com", PhoneNumber = "0100000001" },
                new Staff { StaffId = 2, Name = "Laila Hassan", Position = "Chef", Email = "laila.hassan@rms.com", PhoneNumber = "0100000001" },
                new Staff { StaffId = 3, Name = "Mohamed Tarek", Position = "Manager", Email = "mohamed.tarek@rms.com", PhoneNumber = "0100000001" },
                new Staff { StaffId = 4, Name = "Sara Mostafa", Position = "Cashier", Email = "sara.mostafa@rms.com", PhoneNumber = "0100000001" }
            );

            //Orders
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 4, CustomerId = 1, OrderStatus = Core.Enum.OrderStatus.Pending, OrderType = Core.Enum.OrderType.DineIn, TotalBeforeDiscounts = 20.00m, Total = 20.00m },
                new Order { OrderId = 2, CustomerId = 2, OrderStatus = Core.Enum.OrderStatus.Ready, OrderType = Core.Enum.OrderType.TakeOut, TotalBeforeDiscounts = 15.00m, Total = 15.00m },
                new Order { OrderId = 3, CustomerId = 3, OrderStatus = Core.Enum.OrderStatus.Delivered, OrderType = Core.Enum.OrderType.Delivery, TotalBeforeDiscounts = 30.00m, Total = 30.00m },
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    OrderStatus = Core.Enum.OrderStatus.Pending,
                    OrderType = Core.Enum.OrderType.DineIn,
                    Note = "No onions",
                    DeliveryAddress = null,
                    TableId = 1
                },
                new Order
                {
                    OrderId = 5,
                    CustomerId = 2,
                    OrderStatus = Core.Enum.OrderStatus.Pending,
                    OrderType = Core.Enum.OrderType.Delivery,
                    Note = "Please ring the bell",
                    DeliveryAddress = "123 Main St, City, Country",
                    TableId = null
                }
            );

            //OrderItems
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { Id = 1, OrderId = 1, MenuItemId = 1, Quantity = 2 },
                new OrderItem { Id = 2, OrderId = 1, MenuItemId = 3, Quantity = 1 },
                new OrderItem { Id = 3, OrderId = 2, MenuItemId = 2, Quantity = 1 },
                new OrderItem { Id = 4, OrderId = 2, MenuItemId = 5, Quantity = 2 },
                new OrderItem { Id = 5, OrderId = 3, MenuItemId = 4, Quantity = 1 },
                new OrderItem { Id = 6, OrderId = 3, MenuItemId = 6, Quantity = 1 }
            );

            //Reservations
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationId = 3, CustomerId = 1, NumberOfGuests = 4, SpecialRequests = "Window seat", StartTime = new DateTime(2025, 6, 7, 14, 0, 0), DurationInMinutes = 60, ReservationStatus = Core.Enum.ReservationStatus.Confirmed, TableId = 1, StaffId = 1 },
                new Reservation { ReservationId = 2, CustomerId = 2, NumberOfGuests = 2, SpecialRequests = "Quiet area", StartTime = new DateTime(2025, 6, 7, 15, 0, 0), DurationInMinutes = 90, ReservationStatus = Core.Enum.ReservationStatus.Pending, TableId = 2, StaffId = 2 },
                new Reservation { ReservationId = 1, CustomerId = 2, TableId = 2, NumberOfGuests = 2, ReservationStatus = Core.Enum.ReservationStatus.Confirmed, ReservationCreatedAt = new DateTime(2025, 6, 8, 12, 0, 0), StartTime = new DateTime(2025, 6, 7, 13, 0, 0), DurationInMinutes = 90, SpecialRequests = "Window seat please" }
            );

            //Copon
            modelBuilder.Entity<Coupon>().HasData(
                new Coupon { CouponId = 1, Code = "HAPPYHOUR20", DiscountPercentage = 20, IsActive = true },
                new Coupon { CouponId = 2, Code = "BIGORDER10", DiscountPercentage = 10, IsActive = true },
                new Coupon { CouponId = 3, Code = "STUDENT10", DiscountPercentage = 10,IsActive = true},
                new Coupon { CouponId = 4, Code = "SENIOR15", DiscountPercentage = 15,IsActive = true}
            );


            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.
        //        UseSqlServer("Data Source=.;Initial Catalog=RMS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True;");
        //}
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Staff> Staff { get; set; }

    }
}
