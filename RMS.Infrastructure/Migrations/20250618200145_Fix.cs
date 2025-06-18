using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 571, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 571, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 571, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 571, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 573, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 573, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 573, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 573, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 571, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 573, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 573, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 20, 1, 43, 572, DateTimeKind.Utc).AddTicks(5383));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 276, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 276, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 276, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 276, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 278, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 18, 19, 22, 44, 277, DateTimeKind.Utc).AddTicks(9804));
        }
    }
}
