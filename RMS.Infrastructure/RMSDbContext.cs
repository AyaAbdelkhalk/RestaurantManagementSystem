using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RMS.Application.Helper;
using RMS.Core.Enum;
using RMS.Core.Interfaces;
using RMS.Core.Models;
using System.Linq.Expressions;
using System.Security.Claims;

namespace RMS.Infrastructure
{
    public class RMSDbContext : IdentityDbContext<User>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public RMSDbContext(DbContextOptions<RMSDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.ConfigureWarnings(warnings =>
        //         warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureOrderRelations(modelBuilder);
            ConfigureReservationRelations(modelBuilder);
            ConfigureAuditRelationships(modelBuilder);
            ConfigureQueryFilters(modelBuilder);
            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

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

        }
        

        #region Dbsets
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }
        #endregion

        #region Configure Methods

        private void ConfigureOrderRelations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(u => u.OrdersPlacedByCustomer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.AssignedStaff)
                .WithMany(u => u.OrdersAssignedToStaff)
                .HasForeignKey(o => o.AssignedStaffId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        private void ConfigureReservationRelations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Customer)
                .WithMany(u => u.ReservationsMadeByCustomer)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.AssignedStaff)
                .WithMany(u => u.ReservationsHandledByStaff)
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

                if (typeof(IBaseEntity).IsAssignableFrom(clrType))
                {
                    var entityBuilder = modelBuilder.Entity(clrType);

                    entityBuilder
                        .HasOne(typeof(User), null) // null = no navigation property
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    entityBuilder
                        .HasOne(typeof(User), null)
                        .WithMany()
                        .HasForeignKey("UpdatedBy")
                        .OnDelete(DeleteBehavior.Restrict);

                    entityBuilder
                        .HasOne(typeof(User), null)
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

        #endregion

        #region Audit
        private void ApplyAuditInfo()
        {
            var userId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            foreach (var entry in ChangeTracker.Entries<IBaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                    entry.Entity.CreatedBy = string.IsNullOrEmpty(userId) ? null : userId;
                    if (!string.IsNullOrEmpty(userId))
                        entry.Entity.SetCreatedBy(userId);
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                    entry.Entity.UpdatedBy = string.IsNullOrEmpty(userId) ? null : userId;
                    if (!string.IsNullOrEmpty(userId))
                        entry.Entity.SetUpdatedBy(userId);
                }
                else if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.IsDeleted = true;
                    entry.Entity.DeletedAt = DateTime.UtcNow;
                    entry.Entity.DeletedBy = string.IsNullOrEmpty(userId) ? null : userId;
                    if (!string.IsNullOrEmpty(userId))
                        entry.Entity.SetDeletedBy(userId);
                }
            }
        }
        public override int SaveChanges()
        {
            if (ChangeTracker.HasChanges())
            {
                ApplyAuditInfo();
            }
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            if (ChangeTracker.HasChanges())
            {
                ApplyAuditInfo();
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

        #endregion


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
