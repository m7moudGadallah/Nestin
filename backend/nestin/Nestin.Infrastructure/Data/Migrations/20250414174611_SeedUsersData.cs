using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2dacdb51-fee9-4479-904c-cafe7dca22a6", 0, "2bc5ed7c-f23c-41b2-8f24-6cde1379cf70", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEC7spMPg5RTE/+JwhaFMZ9D4qe125yj/pgHQRdpqvzZn/yUZ56sxPK6NYZ+WPproog==", null, false, "2O776OTQMPGHNUKGKGVD7EK56EWEHWJ4", false, "admin" },
                    { "3dacdb51-fee9-4479-904c-cafe7dca22a7", 0, "3bc5ed7c-f23c-41b2-8f24-6cde1379cf70", "host@email.com", true, false, null, "HOST@EMAIL.COM", "HOST", "AQAAAAIAAYagAAAAEC7spMPg5RTE/+JwhaFMZ9D4qe125yj/pgHQRdpqvzZn/yUZ56sxPK6NYZ+WPproog==", null, false, "HOSTSTAMP", false, "host" },
                    { "4dacdb51-fee9-4479-904c-cafe7dca22a8", 0, "4bc5ed7c-f23c-41b2-8f24-6cde1379cf70", "guest@email.com", true, false, null, "GUEST@EMAIL.COM", "GUEST", "AQAAAAIAAYagAAAAEC7spMPg5RTE/+JwhaFMZ9D4qe125yj/pgHQRdpqvzZn/yUZ56sxPK6NYZ+WPproog==", null, false, "GUESTSTAMP", false, "guest" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dacdb51-fee9-4479-904c-cafe7dca22a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dacdb51-fee9-4479-904c-cafe7dca22a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4dacdb51-fee9-4479-904c-cafe7dca22a8");
        }
    }
}
