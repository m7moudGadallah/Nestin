using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertyGuestSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropertyGuests",
                columns: new[] { "GuestTypeId", "PropertyId", "GuestCount" },
                values: new object[,]
                {
                    { 1, "3e7f99ab-228a-4d90-91c4-6adf8c12e048", 3 },
                    { 2, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", 2 },
                    { 3, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", 1 },
                    { 4, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", 5 },
                    { 2, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", 6 },
                    { 1, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", 1 },
                    { 3, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", 2 },
                    { 4, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 2, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 3, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 4, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 2, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 3, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 4, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" });
        }
    }
}
