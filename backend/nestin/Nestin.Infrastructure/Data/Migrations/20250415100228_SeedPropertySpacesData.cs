using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertySpacesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "0ea8ad1a-78d3-4e4a-831f-fb268e372338", "Office", "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", 6 },
                    { "2450b4fc-b6b1-4b5e-a4e6-e9e297eeb8ff", "Bathroom 1", "3e7f99ab-228a-4d90-91c4-6adf8c12e048", 2 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "3f95f420-21d6-4b2b-b2ef-4b2c92a7f2e9", true, "Bedroom 1", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", 1 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "6a61a1b1-27fd-4f3f-9d8a-9db0b2c35f5e", "Storage", "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", 16 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "6b631776-91e2-4b4c-bd37-cd82b9b4477d", true, "Kitchen 1", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", 3 },
                    { "74f3f8db-0bfc-4c0b-b527-71a326e3f3e1", true, "Balcony", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", 9 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "87e0c991-e32c-4e9c-a780-96f5567a9bb1", "Kitchen 1", "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", 3 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "961aa4f3-45dc-4933-a47b-cba57c1f726b", true, "Laundry Room", "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", 7 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "96ab72d9-2e0d-42d3-a5e3-1eaafc99b3c3", "Bedroom 2", "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", 1 },
                    { "b038b3db-c74d-4d2d-89a6-1ddf5c9580df", "Bathroom 1", "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", 2 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "c9f0d1e3-54a3-4f03-8b69-c11f3bdf02a6", true, "Game Room", "3e7f99ab-228a-4d90-91c4-6adf8c12e048", 14 },
                    { "e1de9d5c-8232-44cc-9abf-9c9a1f0a5e0f", true, "Gym", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", 6 },
                    { "e5dc74e1-d3c0-4878-8e9c-c4dc10fdbf0f", true, "Library", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", 6 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "ed9f2a7b-3e54-403e-b0ae-64ec33eec956", "Bathroom 2", "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", 2 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "f65eb14d-4463-4fa9-a8c6-4b497e20d760", true, "Dining Room", "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", 5 },
                    { "f84c1d56-cdb4-4ac4-8a4e-1c7f4d1f32a7", true, "Living Room 3", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "0ea8ad1a-78d3-4e4a-831f-fb268e372338");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "2450b4fc-b6b1-4b5e-a4e6-e9e297eeb8ff");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "3f95f420-21d6-4b2b-b2ef-4b2c92a7f2e9");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "6a61a1b1-27fd-4f3f-9d8a-9db0b2c35f5e");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "6b631776-91e2-4b4c-bd37-cd82b9b4477d");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "74f3f8db-0bfc-4c0b-b527-71a326e3f3e1");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "87e0c991-e32c-4e9c-a780-96f5567a9bb1");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "961aa4f3-45dc-4933-a47b-cba57c1f726b");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "96ab72d9-2e0d-42d3-a5e3-1eaafc99b3c3");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "b038b3db-c74d-4d2d-89a6-1ddf5c9580df");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "c9f0d1e3-54a3-4f03-8b69-c11f3bdf02a6");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "e1de9d5c-8232-44cc-9abf-9c9a1f0a5e0f");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "e5dc74e1-d3c0-4878-8e9c-c4dc10fdbf0f");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "ed9f2a7b-3e54-403e-b0ae-64ec33eec956");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "f65eb14d-4463-4fa9-a8c6-4b497e20d760");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "f84c1d56-cdb4-4ac4-8a4e-1c7f4d1f32a7");
        }
    }
}
