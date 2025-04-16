using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRolesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d35a86a5-72b3-4e7e-bb7f-5ef782b36f7c", "2dacdb51-fee9-4479-904c-cafe7dca22a6" },
                    { "59ebef1f-d79b-4db0-9c5a-304836f14ff1", "3dacdb51-fee9-4479-904c-cafe7dca22a7" },
                    { "9c75a5df-20a4-4ff1-85a5-bb52f9cf223f", "4dacdb51-fee9-4479-904c-cafe7dca22a8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d35a86a5-72b3-4e7e-bb7f-5ef782b36f7c", "2dacdb51-fee9-4479-904c-cafe7dca22a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "59ebef1f-d79b-4db0-9c5a-304836f14ff1", "3dacdb51-fee9-4479-904c-cafe7dca22a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c75a5df-20a4-4ff1-85a5-bb52f9cf223f", "4dacdb51-fee9-4479-904c-cafe7dca22a8" });
        }
    }
}
