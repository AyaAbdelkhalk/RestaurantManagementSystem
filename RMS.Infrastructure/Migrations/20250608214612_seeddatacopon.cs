using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddatacopon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DiscountValue",
                table: "Coupon",
                newName: "DiscountPercentage");

            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "CouponId", "Code", "DiscountPercentage", "IsActive" },
                values: new object[,]
                {
                    { 1, "HAPPYHOUR20", 20m, true },
                    { 2, "BIGORDER10", 10m, true },
                    { 3, "STUDENT10", 10m, true },
                    { 4, "SENIOR15", 15m, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "DiscountPercentage",
                table: "Coupon",
                newName: "DiscountValue");
        }
    }
}
