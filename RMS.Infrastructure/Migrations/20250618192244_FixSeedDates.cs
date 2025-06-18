using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
