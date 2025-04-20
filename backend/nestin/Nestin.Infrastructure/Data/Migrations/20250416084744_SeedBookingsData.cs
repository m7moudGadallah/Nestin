using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookingsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckIn", "CheckOut", "CreatedAt", "PricePerNight", "PropertyId", "Status", "TotalFees", "UserId" },
                values: new object[,]
                {
                    { "0fe8f9f5-7751-460b-b39f-dab6946c0ba2", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2120m, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", "Confirmed", 1900m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" },
                    { "438d19e1-66fc-4219-9e3d-0519c9c27332", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, "3e7f99ab-228a-4d90-91c4-6adf8c12e048", "Confirmed", 1200m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" },
                    { "49b69c8a-8b4b-4021-85f4-ff273b70c85d", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", "Confirmed", 1200m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" },
                    { "7b479ff7-22c5-46ad-85a3-204b502e5d0b", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", "Pending", 1900m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" },
                    { "7f6b0bb5-e99e-47c7-8d75-b5d46284e241", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", "Pending", 89981m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" },
                    { "8a45a4b6-24ab-4a5b-8ef3-17b7de41295a", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", "Canceled", 1900m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" },
                    { "b6d7b477-9b64-4a79-b7a3-b01c45378d5e", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", "Canceled", 1200m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" },
                    { "d2bc71b9-d703-43fc-a90f-bf22f29a7b4e", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", "Confirmed", 2000m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" },
                    { "e42b9075-d67c-4b5f-8316-bde33ef7272a", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", "Confirmed", 1200m, "4dacdb51-fee9-4479-904c-cafe7dca22a8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "0fe8f9f5-7751-460b-b39f-dab6946c0ba2");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "438d19e1-66fc-4219-9e3d-0519c9c27332");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "49b69c8a-8b4b-4021-85f4-ff273b70c85d");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "7b479ff7-22c5-46ad-85a3-204b502e5d0b");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "7f6b0bb5-e99e-47c7-8d75-b5d46284e241");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "8a45a4b6-24ab-4a5b-8ef3-17b7de41295a");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "b6d7b477-9b64-4a79-b7a3-b01c45378d5e");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "d2bc71b9-d703-43fc-a90f-bf22f29a7b4e");

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: "e42b9075-d67c-4b5f-8316-bde33ef7272a");
        }
    }
}
