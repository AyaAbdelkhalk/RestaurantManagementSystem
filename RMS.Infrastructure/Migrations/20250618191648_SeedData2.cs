using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationCreatedAt",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 14, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 14, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 14, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 14, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 16, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 16, 48, 15, DateTimeKind.Utc).AddTicks(7966));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationCreatedAt",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 906, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 906, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 906, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 906, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ReservationCreatedAt" },
                values: new object[] { new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(5957), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ReservationCreatedAt" },
                values: new object[] { new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(469), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ReservationCreatedAt" },
                values: new object[] { new DateTime(2025, 6, 18, 19, 8, 45, 909, DateTimeKind.Utc).AddTicks(708), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 907, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 8, 45, 908, DateTimeKind.Utc).AddTicks(1730));
        }
    }
}
