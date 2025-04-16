using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertyAvailabilityData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropertyAvailabilities",
                columns: new[] { "Id", "EndDate", "PropertyId", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "3e7f99ab-228a-4d90-91c4-6adf8c12e048", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "3e7f99ab-228a-4d90-91c4-6adf8c12e048", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", new DateTime(2025, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
