using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReviewsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b57197dc-ff4e-4e03-aeb0-cc7c560dc519");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews",
                column: "BookingId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Accuracy", "BookingId", "CheckIn", "Cleanliness", "Comment", "Communication", "CreatedAt", "Location", "Value" },
                values: new object[] { "b57197dc-ff4e-4e03-aeb0-cc7c560dc519", 2.0m, "b6d7b477-9b64-4a79-b7a3-b01c45378d5e", 2.0m, 2.5m, "Needs improvement", 3.0m, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.5m, 2.0m });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews",
                column: "BookingId");
        }
    }
}
