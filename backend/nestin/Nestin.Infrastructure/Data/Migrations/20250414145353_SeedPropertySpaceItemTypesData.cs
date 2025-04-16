using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertySpaceItemTypesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropertySpaceItemTypes",
                columns: new[] { "Id", "Name", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { 1, "Master Bedroom", 1 },
                    { 2, "Guest Bedroom", 1 },
                    { 3, "Kid’s Bedroom", 1 },
                    { 4, "Full Bathroom", 2 },
                    { 5, "Half Bathroom", 2 },
                    { 6, "Ensuite Bathroom", 2 },
                    { 7, "Full Kitchen", 3 },
                    { 8, "Kitchenette", 3 },
                    { 9, "Outdoor Kitchen", 3 },
                    { 10, "Living Room", 4 },
                    { 11, "Lounge Area", 4 },
                    { 12, "Entertainment Room", 4 },
                    { 13, "Dining Room", 5 },
                    { 14, "Breakfast Nook", 5 },
                    { 15, "Bar Counter", 5 },
                    { 16, "Dedicated Office", 6 },
                    { 17, "Desk in Room", 6 },
                    { 18, "Co-working Corner", 6 },
                    { 19, "Laundry Room", 7 },
                    { 20, "Washer/Dryer in Unit", 7 },
                    { 21, "Shared Laundry Area", 7 },
                    { 22, "Private Entrance", 8 },
                    { 23, "Shared Entrance", 8 },
                    { 24, "Gated Entrance", 8 },
                    { 25, "Balcony", 9 },
                    { 26, "Terrace", 9 },
                    { 27, "Rooftop", 9 },
                    { 28, "Backyard", 10 },
                    { 29, "Garden", 10 },
                    { 30, "Courtyard", 10 },
                    { 31, "Fire Pit", 11 },
                    { 32, "Indoor Fireplace", 11 },
                    { 33, "Outdoor Fireplace", 11 },
                    { 34, "Nursery", 12 },
                    { 35, "Changing Station", 12 },
                    { 36, "Crib Corner", 12 },
                    { 37, "Indoor Playroom", 13 },
                    { 38, "Outdoor Playset", 13 },
                    { 39, "Game Room", 13 },
                    { 40, "Walk-in Closet", 14 },
                    { 41, "Wardrobe", 14 },
                    { 42, "Luggage Storage", 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItemTypes",
                keyColumn: "Id",
                keyValue: 42);
        }
    }
}
