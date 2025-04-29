using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingLocationDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 9, 174, "Windmill in Ponta Delgada, Portugal" },
                    { 11, 202, "Cape Town, Western Cape, South Africa" },
                    { 12, 64, "Maadi , Egypt" },
                    { 13, 39, "Courtenay, Canada" },
                    { 14, 231, "Virginia, United States" },
                    { 15, 223, " Gammarth, Tunisia" },
                    { 16, 22, "Jodoigne, Belgium" },
                    { 17, 11, "Buenos Aires, Argentina" },
                    { 18, 157, "Lekki, Nigeria" },
                    { 19, 236, "Lâm Thượng, Vietnam" },
                    { 20, 229, "Dubai, United Arab Emirates" },
                    { 21, 146, "Imlil, Morocco" },
                    { 22, 48, " Sasaima,  Colombia" },
                    { 23, 101, "Kabupaten Gianyar, Indonesia" },
                    { 24, 106, "Rome, Italy" },
                    { 25, 224, "Bodrum, Turkey" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}
