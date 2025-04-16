using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedReviewsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Accuracy", "BookingId", "CheckIn", "Cleanliness", "Comment", "Communication", "CreatedAt", "Location", "Value" },
                values: new object[,]
                {
                    { "2fca2c7e-263b-4d7e-99e7-0c1c3ad2aa08", 3.0m, "438d19e1-66fc-4219-9e3d-0519c9c27332", 2.5m, 3.5m, "Could be better", 4.0m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0m, 3.0m },
                    { "66d2f0d9-1f1f-4a02-81d6-0ecabc5215e6", 4.0m, "7f6b0bb5-e99e-47c7-8d75-b5d46284e241", 5.0m, 4.5m, "Great stay overall", 4.5m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0m, 5.0m },
                    { "72b3d68d-234a-4ed7-b7f7-e07fc82f58ef", 4.0m, "b6d7b477-9b64-4a79-b7a3-b01c45378d5e", 3.5m, 4.0m, "Good value for money", 4.5m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0m, 4.0m },
                    { "84c03e84-cd8b-4dbf-a0f4-48ed3dd0b0aa", 5.0m, "8a45a4b6-24ab-4a5b-8ef3-17b7de41295a", 5.0m, 5.0m, "Excellent experience", 5.0m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0m, 5.0m },
                    { "a54b86b1-65e2-426b-81ef-c65c71e5b8d0", 4.5m, "49b69c8a-8b4b-4021-85f4-ff273b70c85d", 4.0m, 5.0m, "Comfortable and clean", 5.0m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5m, 4.5m },
                    { "b57197dc-ff4e-4e03-aeb0-cc7c560dc519", 2.0m, "b6d7b477-9b64-4a79-b7a3-b01c45378d5e", 2.0m, 2.5m, "Needs improvement", 3.0m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5m, 2.0m },
                    { "e62cd505-8d60-430b-8b52-16d40902a303", 4.5m, "7b479ff7-22c5-46ad-85a3-204b502e5d0b", 4.0m, 4.5m, "Very good host", 5.0m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5m, 4.5m },
                    { "fca2e08b-0436-4f3f-8261-f69cf3eaa579", 3.5m, "e42b9075-d67c-4b5f-8316-bde33ef7272a", 3.0m, 3.0m, "Average experience", 3.5m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0m, 3.0m },
                    { "ffc234ae-2820-4fd6-b9d7-6b315d91a790", 5.0m, "0fe8f9f5-7751-460b-b39f-dab6946c0ba2", 5.0m, 5.0m, "Perfect location", 5.0m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0m, 5.0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2fca2c7e-263b-4d7e-99e7-0c1c3ad2aa08");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "66d2f0d9-1f1f-4a02-81d6-0ecabc5215e6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "72b3d68d-234a-4ed7-b7f7-e07fc82f58ef");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "84c03e84-cd8b-4dbf-a0f4-48ed3dd0b0aa");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a54b86b1-65e2-426b-81ef-c65c71e5b8d0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b57197dc-ff4e-4e03-aeb0-cc7c560dc519");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e62cd505-8d60-430b-8b52-16d40902a303");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "fca2e08b-0436-4f3f-8261-f69cf3eaa579");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ffc234ae-2820-4fd6-b9d7-6b315d91a790");
        }
    }
}
