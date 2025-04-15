using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertySpaceItemsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropertySpaceItems",
                columns: new[] { "Id", "PropertySpaceId", "PropertySpaceItemTypeId", "Quantity" },
                values: new object[,]
                {
                    { 1, "3f95f420-21d6-4b2b-b2ef-4b2c92a7f2e9", 2, 1 },
                    { 2, "96ab72d9-2e0d-42d3-a5e3-1eaafc99b3c3", 2, 2 },
                    { 3, "f84c1d56-cdb4-4ac4-8a4e-1c7f4d1f32a7", 10, 1 },
                    { 4, "6b631776-91e2-4b4c-bd37-cd82b9b4477d", 7, 2 },
                    { 5, "2450b4fc-b6b1-4b5e-a4e6-e9e297eeb8ff", 4, 2 },
                    { 6, "74f3f8db-0bfc-4c0b-b527-71a326e3f3e1", 25, 2 },
                    { 7, "f65eb14d-4463-4fa9-a8c6-4b497e20d760", 13, 1 },
                    { 8, "0ea8ad1a-78d3-4e4a-831f-fb268e372338", 16, 1 },
                    { 9, "c9f0d1e3-54a3-4f03-8b69-c11f3bdf02a6", 39, 1 },
                    { 10, "6a61a1b1-27fd-4f3f-9d8a-9db0b2c35f5e", 42, 1 },
                    { 11, "e5dc74e1-d3c0-4878-8e9c-c4dc10fdbf0f", 18, 2 },
                    { 12, "e1de9d5c-8232-44cc-9abf-9c9a1f0a5e0f", 12, 1 },
                    { 13, "b038b3db-c74d-4d2d-89a6-1ddf5c9580df", 5, 1 },
                    { 14, "961aa4f3-45dc-4933-a47b-cba57c1f726b", 19, 3 },
                    { 15, "87e0c991-e32c-4e9c-a780-96f5567a9bb1", 7, 2 },
                    { 16, "ed9f2a7b-3e54-403e-b0ae-64ec33eec956", 6, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
