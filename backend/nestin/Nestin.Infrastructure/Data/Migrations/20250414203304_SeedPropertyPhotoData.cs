using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertyPhotoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropertyPhotos",
                columns: new[] { "PhotoId", "PropertyId", "TouchedAt" },
                values: new object[,]
                {
                    { "26d418bb-0f90-4f3c-b339-7dd5c31b5e99", "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2ac68b52-e7b6-4bb7-9f8e-49aa7f2b2b6c", "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2cf95d6d-63ae-4b97-8101-c6c5e8227b6d", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4b0f81f1-9bc0-45c6-988e-1a4fd270b3e0", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4dfe3d56-2d34-4a6b-9cb5-f7a5a2dd8c28", "3e7f99ab-228a-4d90-91c4-6adf8c12e048", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "51d1e109-dccf-45fd-9f15-bbd3c0b7fcd5", "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5b742ed2-28d9-4e3b-8125-6e9c4587a0d3", "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5e2e82a1-4893-4a63-9375-d73f7a09d7c5", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "69c6c01e-65b3-4cf7-bbc7-2e94272b658a", "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6c54a231-b88f-409f-b5d5-170180930186", "3e7f99ab-228a-4d90-91c4-6adf8c12e048", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "6c79893d-f97f-4fc6-b0c3-4ebfcab3f85f", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7a18064f-b6cb-4d58-a51b-0e8a74eac7a4", "3e7f99ab-228a-4d90-91c4-6adf8c12e048", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7d861c0c-011d-4b2a-8ce5-f5b1f0b81d01", "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "89f65612-5023-489e-9604-2f01074abf0c", "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "95cde2b1-305e-4c13-9293-8c4c8f7c8b9f", "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "98a76538-918f-4e60-9c01-b364e0e1891f", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "a4c0d40d-e90e-4b14-8a2a-5ac0212be9b1", "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "b21f8f4f-6d95-4f60-81b4-56d2ef017a08", "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "b455bb0a-69a3-4024-b5fa-5a49323e58fd", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "ce9e31d6-6553-4214-8b94-fb9c8f3065ed", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "dc16e3d2-16ed-4ff5-b9c2-27a1e8b5ccbe", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "e34a2808-38df-4e47-8c3e-d6e3f2712f11", "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "f3885b77-0f9e-4ec3-9b3e-cbc194a07d7f", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "fbc177de-bf4c-4b75-a1f6-884d05ce6c9f", "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "26d418bb-0f90-4f3c-b339-7dd5c31b5e99");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "2ac68b52-e7b6-4bb7-9f8e-49aa7f2b2b6c");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "2cf95d6d-63ae-4b97-8101-c6c5e8227b6d");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "4b0f81f1-9bc0-45c6-988e-1a4fd270b3e0");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "4dfe3d56-2d34-4a6b-9cb5-f7a5a2dd8c28");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "51d1e109-dccf-45fd-9f15-bbd3c0b7fcd5");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "5b742ed2-28d9-4e3b-8125-6e9c4587a0d3");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "5e2e82a1-4893-4a63-9375-d73f7a09d7c5");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "69c6c01e-65b3-4cf7-bbc7-2e94272b658a");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "6c54a231-b88f-409f-b5d5-170180930186");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "6c79893d-f97f-4fc6-b0c3-4ebfcab3f85f");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "7a18064f-b6cb-4d58-a51b-0e8a74eac7a4");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "7d861c0c-011d-4b2a-8ce5-f5b1f0b81d01");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "89f65612-5023-489e-9604-2f01074abf0c");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "95cde2b1-305e-4c13-9293-8c4c8f7c8b9f");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "98a76538-918f-4e60-9c01-b364e0e1891f");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "a4c0d40d-e90e-4b14-8a2a-5ac0212be9b1");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "b21f8f4f-6d95-4f60-81b4-56d2ef017a08");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "b455bb0a-69a3-4024-b5fa-5a49323e58fd");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "ce9e31d6-6553-4214-8b94-fb9c8f3065ed");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "dc16e3d2-16ed-4ff5-b9c2-27a1e8b5ccbe");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "e34a2808-38df-4e47-8c3e-d6e3f2712f11");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "f3885b77-0f9e-4ec3-9b3e-cbc194a07d7f");

            migrationBuilder.DeleteData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "fbc177de-bf4c-4b75-a1f6-884d05ce6c9f");
        }
    }
}
