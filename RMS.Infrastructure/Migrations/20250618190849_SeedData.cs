using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 18, 19, 8, 45, 906, DateTimeKind.Utc).AddTicks(7596), null, null, null, null, false, false, "Appetizers", null, null },
                    { 2, new DateTime(2025, 6, 18, 19, 8, 45, 906, DateTimeKind.Utc).AddTicks(9159), null, null, null, "Main dishes including burgers and pizzas", false, false, "Main Dishes", null, null },
                    { 3, new DateTime(2025, 6, 18, 19, 8, 45, 906, DateTimeKind.Utc).AddTicks(9359), null, null, null, null, false, false, "Desserts", null, null },
                    { 4, new DateTime(2025, 6, 18, 19, 8, 45, 906, DateTimeKind.Utc).AddTicks(9361), null, null, null, "Beverages including soft drinks and juices", false, false, "Drinks", null, null }
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "Code", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DiscountAmount", "DiscountPercentage", "ExpirationDate", "IsActive", "IsDeleted", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "HAPPYHOUR20", new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(1583), null, null, null, null, 20m, null, true, false, null, null },
                    { 2, "BIGORDER10", new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(2839), null, null, null, null, 10m, null, true, false, null, null },
                    { 3, "STUDENT10", new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(2842), null, null, null, null, 10m, null, true, false, null, null },
                    { 4, "SENIOR15", new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(2843), null, null, null, null, 15m, null, true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Capacity", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsAvailable", "IsDeleted", "TableNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(8342), null, null, null, false, false, 1, null, null },
                    { 2, 2, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(9123), null, null, null, false, false, 2, null, null },
                    { 3, 6, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(9125), null, null, null, true, false, 3, null, null },
                    { 4, 8, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(9126), null, null, null, true, false, 4, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "HashedPassword", "IsDeleted", "PhoneNumber", "ProfilePicture", "StaffPosition", "UpdatedAt", "UpdatedBy", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(64), null, null, null, null, "aya.khaled@example.com", "123456", false, "0100000001", null, null, null, null, "Aya Khaled", 0 },
                    { 2, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1238), null, null, null, null, "doha.ezzat@example.com", "123456", false, "0100000002", null, null, null, null, "Doha Ezzat", 0 },
                    { 3, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1263), null, null, null, null, "jameela.abdulrahman@example.com", "123456", false, "0100000003", null, null, null, null, "Jameela Abdulrahman", 0 },
                    { 4, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1265), null, null, null, null, "shimaa.mohamed@example.com", "123456", false, "0100000004", null, null, null, null, "Shimaa Mohamed", 0 },
                    { 5, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1267), null, null, null, null, "karim.elshenawy@rms.com", "123456", false, "0100000005", null, 0, null, null, "Karim ElShenawy", 1 },
                    { 6, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1726), null, null, null, null, "laila.hassan@rms.com", "123456", false, "0100000006", null, 1, null, null, "Laila Hassan", 1 },
                    { 7, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1728), null, null, null, null, "mohamed.tarek@rms.com", "123456", false, "0100000007", null, 2, null, null, "Mohamed Tarek", 1 },
                    { 8, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1730), null, null, null, null, "sara.mostafa@rms.com", "123456", false, "0100000008", null, 3, null, null, "Sara Mostafa", 1 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CategoryId", "CreatedAt", "CreatedBy", "DailyOrderCount", "DeletedAt", "DeletedBy", "Description", "ImageUrl", "IsAvailable", "IsDeleted", "Name", "PreparationTimeInMinutes", "UnitPrice", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(5741), null, 0, null, null, null, null, true, false, "Spring Rolls", 0, 5.99m, null, null },
                    { 2, 1, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7354), null, 0, null, null, null, null, true, false, "Caesar Salad", 0, 7.99m, null, null },
                    { 3, 2, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7357), null, 0, null, null, null, null, true, false, "Grilled Chicken", 0, 12.99m, null, null },
                    { 4, 3, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7358), null, 0, null, null, null, null, true, false, "Chocolate Cake", 0, 4.99m, null, null },
                    { 5, 4, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7360), null, 0, null, null, null, null, true, false, "Coca Cola", 0, 1.99m, null, null },
                    { 6, 3, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7361), null, 0, null, null, null, null, true, false, "Cheesecake", 0, 6.50m, null, null },
                    { 7, 4, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7363), null, 0, null, null, null, null, true, false, "Mango Juice", 0, 3.99m, null, null },
                    { 8, 2, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7364), null, 0, null, null, null, null, true, false, "Spaghetti Carbonara", 0, 10.99m, null, null },
                    { 9, 2, new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7392), null, 0, null, null, null, null, true, false, "Vegetable Stir Fry", 0, 8.99m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "AssignedStaffId", "CouponId", "CreatedAt", "CreatedBy", "CustomerId", "DeletedAt", "DeletedBy", "DeliveryAddress", "DeliveryTime", "DiscountAmount", "IsDeleted", "Note", "OrderStatus", "OrderType", "TableId", "TaxPercentage", "Total", "TotalBeforeDiscounts", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(2510), null, 1, null, null, null, null, 0m, false, "No onions", 0, 0, 1, 0.085m, 20m, 20m, null, null },
                    { 2, null, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4243), null, 2, null, null, null, null, 0m, false, null, 2, 1, null, 0.085m, 15m, 15m, null, null },
                    { 3, null, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4246), null, 3, null, null, null, null, 0m, false, null, 3, 2, null, 0.085m, 30m, 30m, null, null },
                    { 4, null, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4247), null, 1, null, null, null, null, 0m, false, null, 0, 0, null, 0.085m, 20m, 20m, null, null },
                    { 5, null, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4249), null, 2, null, null, "123 Main St", null, 0m, false, "Please ring the bell", 0, 2, null, 0.085m, 22.5m, 25m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "AssignedStaffId", "CreatedAt", "CreatedBy", "CustomerId", "DeletedAt", "DeletedBy", "DurationInMinutes", "IsDeleted", "NumberOfGuests", "ReservationCreatedAt", "ReservationStatus", "SpecialRequests", "StartTime", "TableId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5957), null, 2, null, null, 90, false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Window seat please", new DateTime(2025, 6, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null },
                    { 2, 6, new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(469), null, 2, null, null, 90, false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Quiet area", new DateTime(2025, 6, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null },
                    { 3, 5, new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(708), null, 1, null, null, 60, false, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Window seat", new DateTime(2025, 6, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "MenuItemId", "OrderId", "Quantity", "UnitPrice", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4823), null, null, null, false, 1, 1, 2, 0m, null, null },
                    { 2, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5520), null, null, null, false, 3, 1, 1, 0m, null, null },
                    { 3, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5521), null, null, null, false, 2, 2, 1, 0m, null, null },
                    { 4, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5522), null, null, null, false, 5, 2, 2, 0m, null, null },
                    { 5, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5523), null, null, null, false, 4, 3, 1, 0m, null, null },
                    { 6, new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5524), null, null, null, false, 6, 3, 1, 0m, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
