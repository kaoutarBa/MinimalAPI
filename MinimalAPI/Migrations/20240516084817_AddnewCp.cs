using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalCouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddnewCp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Created", "IsActive", "LastUpdated", "Name", "Percent" },
                values: new object[] { 3, null, true, null, "30OFF", 30 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
