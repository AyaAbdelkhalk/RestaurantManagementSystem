using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RMS.Core.Enum;
using RMS.Core.Models;
using System.Linq.Expressions;

namespace RMS.Infrastructure
{
    public class RMSDbContext : DbContext
    {
        public RMSDbContext(){}
        public RMSDbContext(DbContextOptions<RMSDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                 warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureOrderRelations(modelBuilder);
            ConfigureReservationRelations(modelBuilder);
            ConfigureAuditRelationships(modelBuilder);
            ConfigureQueryFilters(modelBuilder);
            SeedInitialData(modelBuilder);


            #region advnacedforglobalfilters
            //// another way to apply global filters for BaseEntity derived classes
            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            //    {
            //        modelBuilder.Entity(entityType.ClrType)
            //            .HasQueryFilter(GetIsDeletedFilter(entityType.ClrType));
            //    }
            //} 
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            ApplyAuditInfo();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ApplyAuditInfo();
            return await base.SaveChangesAsync(cancellationToken);
        }

        #region Dbsets
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; } 
        #endregion



        private void ConfigureOrderRelations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(u => u.CustomerOrders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.AssignedStaff)
                .WithMany(u => u.AssignedOrders)
                .HasForeignKey(o => o.AssignedStaffId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        private void ConfigureReservationRelations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Customer)
                .WithMany(u => u.CustomerReservations)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.AssignedStaff)
                .WithMany(u => u.AssignedReservations)
                .HasForeignKey(r => r.AssignedStaffId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Table)
                .WithMany(t => t.Reservations)
                .HasForeignKey(r => r.TableId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        private void ConfigureAuditRelationships(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var clrType = entity.ClrType;

                if (typeof(BaseEntity).IsAssignableFrom(clrType))
                {
                    modelBuilder.Entity(clrType).HasOne(typeof(User), "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    modelBuilder.Entity(clrType).HasOne(typeof(User), "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    modelBuilder.Entity(clrType).HasOne(typeof(User), "DeletedByUser")
                        .WithMany()
                        .HasForeignKey("DeletedBy")
                        .OnDelete(DeleteBehavior.Restrict);
                }
            }
        }
        private void ConfigureQueryFilters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<MenuItem>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Order>().HasQueryFilter(o => !o.IsDeleted);
            modelBuilder.Entity<OrderItem>().HasQueryFilter(oi => !oi.IsDeleted);
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Reservation>().HasQueryFilter(r => !r.IsDeleted);
            modelBuilder.Entity<Table>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<Coupon>().HasQueryFilter(c => !c.IsDeleted);
        }
        private void SeedInitialData(ModelBuilder modelBuilder)
        {
            // Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Appetizers" },
                new Category { CategoryId = 2, Name = "Main Dishes", Description = "Main dishes including burgers and pizzas" },
                new Category { CategoryId = 3, Name = "Desserts" },
                new Category { CategoryId = 4, Name = "Drinks", Description = "Beverages including soft drinks and juices" }
            );

            // MenuItems
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

            // Tables
            modelBuilder.Entity<Table>().HasData(
                new Table { TableId = 1, TableNumber = 1, Capacity = 4, IsAvailable = false },
                new Table { TableId = 2, TableNumber = 2, Capacity = 2, IsAvailable = false },
                new Table { TableId = 3, TableNumber = 3, Capacity = 6 },
                new Table { TableId = 4, TableNumber = 4, Capacity = 8 }
            );

            // Users (Customers and Staff)
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "Aya Khaled", Email = "aya.khaled@example.com", PhoneNumber = "0100000001", UserType = UserType.Customer, HashedPassword = "123456" },
                new User { UserId = 2, UserName = "Doha Ezzat", Email = "doha.ezzat@example.com", PhoneNumber = "0100000002", UserType = UserType.Customer, HashedPassword = "123456" },
                new User { UserId = 3, UserName = "Jameela Abdulrahman", Email = "jameela.abdulrahman@example.com", PhoneNumber = "0100000003", UserType = UserType.Customer, HashedPassword = "123456" },
                new User { UserId = 4, UserName = "Shimaa Mohamed", Email = "shimaa.mohamed@example.com", PhoneNumber = "0100000004", UserType = UserType.Customer, HashedPassword = "123456" },

                new User { UserId = 5, UserName = "Karim ElShenawy", Email = "karim.elshenawy@rms.com", PhoneNumber = "0100000005", UserType = UserType.Staff, HashedPassword = "123456", StaffPosition = StaffPosition.Waiter },
                new User { UserId = 6, UserName = "Laila Hassan", Email = "laila.hassan@rms.com", PhoneNumber = "0100000006", UserType = UserType.Staff, HashedPassword = "123456", StaffPosition = StaffPosition.Chef },
                new User { UserId = 7, UserName = "Mohamed Tarek", Email = "mohamed.tarek@rms.com", PhoneNumber = "0100000007", UserType = UserType.Staff, HashedPassword = "123456", StaffPosition = StaffPosition.Manager },
                new User { UserId = 8, UserName = "Sara Mostafa", Email = "sara.mostafa@rms.com", PhoneNumber = "0100000008", UserType = UserType.Staff, HashedPassword = "123456", StaffPosition = StaffPosition.Cashier }
            );



            // Orders
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, CustomerId = 1, OrderStatus = OrderStatus.Pending, OrderType = OrderType.DineIn, TableId = 1, Note = "No onions", TotalBeforeDiscounts = 20, Total = 20 },
                new Order { OrderId = 2, CustomerId = 2, OrderStatus = OrderStatus.Ready, OrderType = OrderType.TakeOut, TotalBeforeDiscounts = 15, Total = 15 },
                new Order { OrderId = 3, CustomerId = 3, OrderStatus = OrderStatus.Delivered, OrderType = OrderType.Delivery, TotalBeforeDiscounts = 30, Total = 30 },
                new Order { OrderId = 4, CustomerId = 1, OrderStatus = OrderStatus.Pending, OrderType = OrderType.DineIn, TotalBeforeDiscounts = 20, Total = 20 },
                new Order { OrderId = 5, CustomerId = 2, OrderStatus = OrderStatus.Pending, OrderType = OrderType.Delivery, Note = "Please ring the bell", DeliveryAddress = "123 Main St", TotalBeforeDiscounts = 25, Total = 22.5m }
            );

            // OrderItems
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { Id = 1, OrderId = 1, MenuItemId = 1, Quantity = 2 },
                new OrderItem { Id = 2, OrderId = 1, MenuItemId = 3, Quantity = 1 },
                new OrderItem { Id = 3, OrderId = 2, MenuItemId = 2, Quantity = 1 },
                new OrderItem { Id = 4, OrderId = 2, MenuItemId = 5, Quantity = 2 },
                new OrderItem { Id = 5, OrderId = 3, MenuItemId = 4, Quantity = 1 },
                new OrderItem { Id = 6, OrderId = 3, MenuItemId = 6, Quantity = 1 }
            );

            // Reservations
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationId = 1, CustomerId = 2, TableId = 2, NumberOfGuests = 2, StartTime = new DateTime(2025, 6, 7, 13, 0, 0), DurationInMinutes = 90, SpecialRequests = "Window seat please", ReservationStatus = ReservationStatus.Confirmed },
                new Reservation { ReservationId = 2, CustomerId = 2, TableId = 2, NumberOfGuests = 2, StartTime = new DateTime(2025, 6, 7, 15, 0, 0), DurationInMinutes = 90, SpecialRequests = "Quiet area", ReservationStatus = ReservationStatus.Pending, AssignedStaffId = 6 },
                new Reservation { ReservationId = 3, CustomerId = 1, TableId = 1, NumberOfGuests = 4, StartTime = new DateTime(2025, 6, 7, 14, 0, 0), DurationInMinutes = 60, SpecialRequests = "Window seat", ReservationStatus = ReservationStatus.Confirmed, AssignedStaffId = 5 }
            );

            // Coupons
            modelBuilder.Entity<Coupon>().HasData(
                new Coupon { CouponId = 1, Code = "HAPPYHOUR20", DiscountPercentage = 20, IsActive = true },
                new Coupon { CouponId = 2, Code = "BIGORDER10", DiscountPercentage = 10, IsActive = true },
                new Coupon { CouponId = 3, Code = "STUDENT10", DiscountPercentage = 10, IsActive = true },
                new Coupon { CouponId = 4, Code = "SENIOR15", DiscountPercentage = 15, IsActive = true }
            );
        }

        private void ApplyAuditInfo()
        {
            //var userId = _httpContextAccessor.HttpContext?.Items["UserId"] as int?;

            var userId =1;//dont forget to replace this

            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                    entry.Entity.CreatedBy = userId;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                    entry.Entity.UpdatedBy = userId;
                }
                else if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.IsDeleted = true;
                    entry.Entity.DeletedAt = DateTime.UtcNow;
                    entry.Entity.DeletedBy = userId;
                }
            }
        }




            //private static LambdaExpression GetIsDeletedFilter(Type type)
            //{
            //    var param = Expression.Parameter(type, "e");
            //    var prop = Expression.Property(param, "IsDeleted");
            //    var constant = Expression.Constant(false);
            //    var body = Expression.Equal(prop, constant);
            //    return Expression.Lambda(body, param);
            //}

        }
}
