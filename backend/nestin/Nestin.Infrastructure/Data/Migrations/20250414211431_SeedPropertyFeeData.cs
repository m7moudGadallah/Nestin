using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertyFeeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropertyFees",
                columns: new[] { "Id", "Amount", "Name", "PropertyId" },
                values: new object[,]
                {
                    { 1, 1212.09m, "Cleaning Fee", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
                    { 2, 442.09m, "Extra Guest Fee", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
                    { 3, 600m, "Pet Fee", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
                    { 4, 600m, "Pet Fee", "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" },
                    { 5, 1200m, "Cleaning Fee", "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" },
                    { 6, 900.12m, "Cleaning Fee", "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" },
                    { 7, 442.09m, "Extra Guest Fee", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" },
                    { 8, 113.09m, "Cleaning Fee", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
