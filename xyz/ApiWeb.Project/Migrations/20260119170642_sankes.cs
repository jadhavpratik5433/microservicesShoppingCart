using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiWeb.Project.Migrations
{
    /// <inheritdoc />
    public partial class sankes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponID", "CouponCode", "DiscountAmount", "MinAmount" },
                values: new object[,]
                {
                    { 1, "SUMMER10", 10.0, 50 },
                    { 2, "sanket", 20.0, 70 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponID",
                keyValue: 2);
        }
    }
}
