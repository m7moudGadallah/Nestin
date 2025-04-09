using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAspNetRolesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59ebef1f-d79b-4db0-9c5a-304836f14ff1", null, "Host", "HOST" },
                    { "9c75a5df-20a4-4ff1-85a5-bb52f9cf223f", null, "Guest", "GUEST" },
                    { "d35a86a5-72b3-4e7e-bb7f-5ef782b36f7c", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59ebef1f-d79b-4db0-9c5a-304836f14ff1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c75a5df-20a4-4ff1-85a5-bb52f9cf223f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d35a86a5-72b3-4e7e-bb7f-5ef782b36f7c");
        }
    }
}
