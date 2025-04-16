using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedAmenitiesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "CategoryId", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, 11, "wifi", "Wi-Fi" },
                    { 2, 2, "waves", "Pool" },
                    { 3, 7, "air-vent", "Air conditioning" },
                    { 4, 9, "bath", "Bathtub" },
                    { 5, 9, "wind", "Hair dryer" },
                    { 6, 9, "broom", "Cleaning products" },
                    { 7, 9, "droplets", "Shampoo" },
                    { 8, 9, "droplet", "Conditioner" },
                    { 9, 9, "soap", "Body soap" },
                    { 10, 9, "toilet", "Bidet" },
                    { 11, 9, "shower-head", "Outdoor shower" },
                    { 12, 9, "thermometer-sun", "Hot water" },
                    { 13, 9, "flask-round", "Shower gel" },
                    { 14, 8, "sparkles", "Free washer – In unit" },
                    { 15, 8, "shirt", "Hangers" },
                    { 16, 8, "bed-double", "Bed linens" },
                    { 17, 8, "pill", "Extra pillows and blankets" },
                    { 18, 8, "lamp", "Room-darkening shades" },
                    { 19, 8, "flame", "Iron" },
                    { 20, 8, "hanger", "Drying rack for clothing" },
                    { 21, 8, "bug", "Mosquito net" },
                    { 22, 8, "archive", "Clothing storage: closet and dresser" },
                    { 23, 4, "cable", "Ethernet connection" },
                    { 24, 4, "tv", "42 inch HDTV with Netflix" },
                    { 25, 4, "volume-2", "Sound system with aux" },
                    { 26, 4, "gamepad-2", "Game console" },
                    { 27, 4, "tennis", "Ping pong table" },
                    { 28, 4, "dice-5", "Pool table" },
                    { 29, 4, "book-open", "Books and reading material" },
                    { 30, 4, "film", "Movie theater" },
                    { 31, 10, "baby", "Crib" },
                    { 32, 10, "blocks", "Children’s books and toys" },
                    { 33, 10, "chair", "High chair" },
                    { 34, 10, "baby", "Baby bath" },
                    { 35, 10, "utensils-crossed", "Children’s dinnerware" },
                    { 36, 10, "dice-3", "Board games" },
                    { 37, 10, "door-closed", "Baby safety gates" },
                    { 38, 10, "user", "Babysitter recommendations" },
                    { 39, 10, "puzzle", "Children's playroom" },
                    { 40, 7, "flame", "Indoor fireplace: wood-burning" },
                    { 41, 7, "fan", "Ceiling fan" },
                    { 42, 7, "fan", "Portable fans" },
                    { 43, 7, "thermometer", "Heating" },
                    { 44, 3, "first-aid-kit", "First aid kit" },
                    { 45, 3, "laptop", "Dedicated workspace" },
                    { 46, 2, "chef-hat", "Kitchen" },
                    { 47, 2, "fridge", "Refrigerator" },
                    { 48, 2, "utensils-crossed", "Cooking basics" },
                    { 49, 2, "plate", "Dishes and silverware" },
                    { 50, 2, "snowflake", "Freezer" },
                    { 51, 2, "droplet", "Dishwasher" },
                    { 52, 2, "flame", "Stove" },
                    { 53, 2, "microwave", "Oven" },
                    { 54, 2, "kettle", "Hot water kettle" },
                    { 55, 2, "coffee", "Coffee maker" },
                    { 56, 2, "sandwich", "Toaster" },
                    { 57, 2, "sheet", "Baking sheet" },
                    { 58, 2, "blender", "Blender" },
                    { 59, 2, "knife", "Barbecue utensils" },
                    { 60, 2, "coffee", "Coffee" },
                    { 61, 12, "door-open", "Private entrance" },
                    { 62, 12, "shirt", "Laundromat nearby" },
                    { 63, 12, "mountain", "Balacony" },
                    { 64, 12, "fire-extinguisher", "Fire Pit" },
                    { 65, 12, "sofa", "Outdoor furniture" },
                    { 66, 13, "paw-print", "Pets Allowed" },
                    { 67, 6, "car", "Free street parking" },
                    { 68, 6, "car", "Free street On premises" },
                    { 69, 13, "calendar", "Long term stays allowed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 69);
        }
    }
}
