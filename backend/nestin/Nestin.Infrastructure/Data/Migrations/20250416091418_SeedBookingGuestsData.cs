using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookingGuestsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookingGuests",
                columns: new[] { "BookingId", "GuestTypeId", "GuestCount" },
                values: new object[,]
                {
                    { "0fe8f9f5-7751-460b-b39f-dab6946c0ba2", 2, 1 },
                    { "438d19e1-66fc-4219-9e3d-0519c9c27332", 3, 2 },
                    { "49b69c8a-8b4b-4021-85f4-ff273b70c85d", 2, 3 },
                    { "7b479ff7-22c5-46ad-85a3-204b502e5d0b", 4, 2 },
                    { "7f6b0bb5-e99e-47c7-8d75-b5d46284e241", 1, 3 },
                    { "8a45a4b6-24ab-4a5b-8ef3-17b7de41295a", 1, 2 },
                    { "b6d7b477-9b64-4a79-b7a3-b01c45378d5e", 2, 1 },
                    { "d2bc71b9-d703-43fc-a90f-bf22f29a7b4e", 2, 2 },
                    { "e42b9075-d67c-4b5f-8316-bde33ef7272a", 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "0fe8f9f5-7751-460b-b39f-dab6946c0ba2", 2 });

            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "438d19e1-66fc-4219-9e3d-0519c9c27332", 3 });

            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "49b69c8a-8b4b-4021-85f4-ff273b70c85d", 2 });

            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "7b479ff7-22c5-46ad-85a3-204b502e5d0b", 4 });

            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "7f6b0bb5-e99e-47c7-8d75-b5d46284e241", 1 });

            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "8a45a4b6-24ab-4a5b-8ef3-17b7de41295a", 1 });

            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "b6d7b477-9b64-4a79-b7a3-b01c45378d5e", 2 });

            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "d2bc71b9-d703-43fc-a90f-bf22f29a7b4e", 2 });

            migrationBuilder.DeleteData(
                table: "BookingGuests",
                keyColumns: new[] { "BookingId", "GuestTypeId" },
                keyValues: new object[] { "e42b9075-d67c-4b5f-8316-bde33ef7272a", 1 });
        }
    }
}
