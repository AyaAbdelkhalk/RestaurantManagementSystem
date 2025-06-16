using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "ImageUrl", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, null, null, false, "Appetizers" },
                    { 2, "Main dishes including burgers and pizzas", null, false, "Main Dishes" },
                    { 3, null, null, false, "Desserts" },
                    { 4, "Beverages including soft drinks and juices", null, false, "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CreatedAt", "DateOfBirth", "Email", "HashedPassword", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, null, null, null, "aya.khaled@example.com", null, "Aya Khaled", "0100000001" },
                    { 2, null, null, null, "doha.ezzat@example.com", null, "Doha Ezzat", "0100000002" },
                    { 3, null, null, null, "jameela.abdulrahman@example.com", null, "Jameela Abdulrahman", "0100000003" },
                    { 4, null, null, null, "shimaa.mohamed@example.com", null, "Shimaa Mohamed", "0100000004" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "Address", "CreatedAt", "Email", "HashedPassword", "Name", "PhoneNumber", "Position" },
                values: new object[,]
                {
                    { 1, null, null, "karim.elshenawy@rms.com", null, "Karim ElShenawy", "0100000001", "Waiter" },
                    { 2, null, null, "laila.hassan@rms.com", null, "Laila Hassan", "0100000001", "Chef" },
                    { 3, null, null, "mohamed.tarek@rms.com", null, "Mohamed Tarek", "0100000001", "Manager" },
                    { 4, null, null, "sara.mostafa@rms.com", null, "Sara Mostafa", "0100000001", "Cashier" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Capacity", "IsAvailable", "TableNumber" },
                values: new object[,]
                {
                    { 1, 4, false, 1 },
                    { 2, 2, false, 2 },
                    { 3, 6, true, 3 },
                    { 4, 8, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "CategoryId", "DailyOrderCount", "Description", "ImageUrl", "IsAvailable", "Name", "PreparationTimeInMinutes", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 0, null, null, true, "Spring Rolls", 0, 5.99m },
                    { 2, 1, 0, null, null, true, "Caesar Salad", 0, 7.99m },
                    { 3, 2, 0, null, null, true, "Grilled Chicken", 0, 12.99m },
                    { 4, 3, 0, null, null, true, "Chocolate Cake", 0, 4.99m },
                    { 5, 4, 0, null, null, true, "Coca Cola", 0, 1.99m },
                    { 6, 3, 0, null, null, true, "Cheesecake", 0, 6.50m },
                    { 7, 4, 0, null, null, true, "Mango Juice", 0, 3.99m },
                    { 8, 2, 0, null, null, true, "Spaghetti Carbonara", 0, 10.99m },
                    { 9, 2, 0, null, null, true, "Vegetable Stir Fry", 0, 8.99m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CouponId", "CustomerId", "DeliveryAddress", "DeliveryTime", "DiscountAmount", "Note", "OrderStatus", "OrderTime", "OrderType", "StaffId", "TableId", "Total", "TotalBeforeDiscounts" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, 0m, "No onions", 0, null, 0, null, 1, 0m, 0m },
                    { 2, null, 2, null, null, 0m, null, 2, null, 1, null, null, 15.00m, 15.00m },
                    { 3, null, 3, null, null, 0m, null, 3, null, 2, null, null, 30.00m, 30.00m },
                    { 4, null, 1, null, null, 0m, null, 0, null, 0, null, null, 20.00m, 20.00m },
                    { 5, null, 2, "123 Main St, City, Country", null, 0m, "Please ring the bell", 0, null, 2, null, null, 0m, 0m }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CustomerId", "DurationInMinutes", "NumberOfGuests", "ReservationCreatedAt", "ReservationStatus", "SpecialRequests", "StaffId", "StartTime", "TableId" },
                values: new object[,]
                {
                    { 1, 2, 90, 2, new DateTime(2025, 6, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, "Window seat please", null, new DateTime(2025, 6, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 2, 2, 90, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Quiet area", 2, new DateTime(2025, 6, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 1, 60, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Window seat", 1, new DateTime(2025, 6, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "MenuItemId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 3, 1, 1 },
                    { 3, 2, 2, 1 },
                    { 4, 5, 2, 2 },
                    { 5, 4, 3, 1 },
                    { 6, 6, 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
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
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

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
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

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
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
