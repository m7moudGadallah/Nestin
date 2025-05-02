using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingUserProfileDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FileUploads",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { "4ae9e354-5eac-4f3a-a4b3-7c84c5b31d89", "images/guest.jpg" },
                    { "98b7dcb6-7c53-4216-9f7a-259f40371fd4", "images/host.jpg" },
                    { "c3d1f440-7e0e-4f38-8b5d-34ea8d12e801", "images/admin.jpg" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "UserId", "Bio", "BirthDate", "CountryId", "FirstName", "LastName", "PhotoId" },
                values: new object[,]
                {
                    { "2dacdb51-fee9-4479-904c-cafe7dca22a6", "As the system administrator, I ensure that our platform runs smoothly, securely, and efficiently. From managing users and listings to maintaining system integrity, I'm here to support both guests and hosts for a seamless experience.", new DateOnly(1995, 5, 2), 64, "Marcus", "Dou", "c3d1f440-7e0e-4f38-8b5d-34ea8d12e801" },
                    { "3dacdb51-fee9-4479-904c-cafe7dca22a7", "Hi, I’m Pavel! I’ve been hosting guests from around the world for over 3 years. I love sharing my cozy home and local tips to help you experience the best of the city. Your comfort and privacy are my top priorities—feel free to reach out with any questions before or during your stay!", new DateOnly(1999, 12, 2), 64, "Pavel", "Elmo", "98b7dcb6-7c53-4216-9f7a-259f40371fd4" },
                    { "4dacdb51-fee9-4479-904c-cafe7dca22a8", "Hi, I’m Lucas! I enjoy exploring new cities, meeting new people, and experiencing different cultures. I’m a respectful guest who values comfort and cleanliness. Looking forward to staying in your wonderful property and making the most of my travels!", new DateOnly(2001, 2, 2), 64, "lucas", "Martin", "4ae9e354-5eac-4f3a-a4b3-7c84c5b31d89" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "UserId",
                keyValue: "2dacdb51-fee9-4479-904c-cafe7dca22a6");

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "UserId",
                keyValue: "3dacdb51-fee9-4479-904c-cafe7dca22a7");

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "UserId",
                keyValue: "4dacdb51-fee9-4479-904c-cafe7dca22a8");

            migrationBuilder.DeleteData(
                table: "FileUploads",
                keyColumn: "Id",
                keyValue: "4ae9e354-5eac-4f3a-a4b3-7c84c5b31d89");

            migrationBuilder.DeleteData(
                table: "FileUploads",
                keyColumn: "Id",
                keyValue: "98b7dcb6-7c53-4216-9f7a-259f40371fd4");

            migrationBuilder.DeleteData(
                table: "FileUploads",
                keyColumn: "Id",
                keyValue: "c3d1f440-7e0e-4f38-8b5d-34ea8d12e801");
        }
    }
}
