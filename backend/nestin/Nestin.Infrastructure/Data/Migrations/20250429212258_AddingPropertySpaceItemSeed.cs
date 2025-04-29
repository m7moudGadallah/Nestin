using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPropertySpaceItemSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "PropertySpaceId",
                value: "daae3bd2-707e-4374-9b6c-5703f9789c7f");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "PropertySpaceId",
                value: "d20a85b2-4019-4714-a63e-e017b4be4e3e");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "PropertySpaceId",
                value: "325e05d6-cc5d-4140-b1bc-d96fc52d86b3");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "PropertySpaceId",
                value: "62b66c76-60d1-4b4b-8e97-bfd0338ea05a");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "PropertySpaceId",
                value: "b09ce60b-b66b-47df-9985-41d1e7f6b254");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "PropertySpaceId",
                value: "726d598e-c948-41b6-8cc3-c7e1aa4a51e4");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "PropertySpaceId",
                value: "14a66729-9580-472b-9438-dfc7e2440c95");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "PropertySpaceId",
                value: "f8c7fef3-70f4-4650-baa6-f93db77dfd92");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "PropertySpaceId",
                value: "c8f09e6f-8c82-4026-b3ec-23be0a378a56");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "PropertySpaceId",
                value: "96f6a377-d586-44a2-acc7-fc45c10d999c");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "PropertySpaceId",
                value: "1cc7112f-3bb5-4265-8e0a-b305274c0410");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "PropertySpaceId",
                value: "6c67a41a-8274-4ad0-864e-20fd4866b2d4");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "PropertySpaceId",
                value: "846b07ee-bb17-4c94-82df-99f1f7643ea3");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "PropertySpaceId",
                value: "1954cfa5-9c89-41a7-a6be-41c71b34efc9");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "PropertySpaceId",
                value: "c6ae89de-0d1a-4e5a-9230-8ef6617a3b53");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "PropertySpaceId",
                value: "49f23d20-c9ae-4a77-9734-1886d424cb77");

            migrationBuilder.InsertData(
                table: "PropertySpaceItems",
                columns: new[] { "Id", "PropertySpaceId", "PropertySpaceItemTypeId", "Quantity" },
                values: new object[,]
                {
                    { 17, "5eb1c7e5-efb6-4b3c-983f-d278c1c086e7", 8, 2 },
                    { 18, "9f5f9e6e-0d79-41ad-86a1-06cbff2d0e92", 1, 1 },
                    { 19, "30baf72d-9d00-4f3e-9405-2261d6f0dd76", 3, 2 },
                    { 20, "6b09c3a9-e319-45d0-a253-b5d6f4f9de3a", 9, 1 },
                    { 21, "d2e5f682-06d0-40e7-a1e7-002b958d8048", 11, 2 },
                    { 22, "29ac2c68-b4b4-45b8-918a-fbdf11660d7e", 14, 1 },
                    { 23, "8cf76f1f-7f39-4d78-bcc7-2a2a34db54b3", 15, 1 },
                    { 24, "8cf76f1f-7f39-4d78-bcc7-2a2a34db54b3", 12, 2 },
                    { 25, "14a66729-9580-472b-9438-dfc7e2440c95", 3, 1 },
                    { 26, "5eb1c7e5-efb6-4b3c-983f-d278c1c086e7", 1, 1 },
                    { 27, "9f5f9e6e-0d79-41ad-86a1-06cbff2d0e92", 2, 1 },
                    { 28, "1954cfa5-9c89-41a7-a6be-41c71b34efc9", 9, 3 },
                    { 29, "8cf76f1f-7f39-4d78-bcc7-2a2a34db54b3", 6, 1 },
                    { 30, "6c67a41a-8274-4ad0-864e-20fd4866b2d4", 5, 2 },
                    { 31, "6b09c3a9-e319-45d0-a253-b5d6f4f9de3a", 7, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "PropertySpaceId",
                value: "3f95f420-21d6-4b2b-b2ef-4b2c92a7f2e9");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "PropertySpaceId",
                value: "96ab72d9-2e0d-42d3-a5e3-1eaafc99b3c3");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "PropertySpaceId",
                value: "f84c1d56-cdb4-4ac4-8a4e-1c7f4d1f32a7");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "PropertySpaceId",
                value: "6b631776-91e2-4b4c-bd37-cd82b9b4477d");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "PropertySpaceId",
                value: "2450b4fc-b6b1-4b5e-a4e6-e9e297eeb8ff");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "PropertySpaceId",
                value: "74f3f8db-0bfc-4c0b-b527-71a326e3f3e1");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "PropertySpaceId",
                value: "f65eb14d-4463-4fa9-a8c6-4b497e20d760");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "PropertySpaceId",
                value: "0ea8ad1a-78d3-4e4a-831f-fb268e372338");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "PropertySpaceId",
                value: "c9f0d1e3-54a3-4f03-8b69-c11f3bdf02a6");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "PropertySpaceId",
                value: "6a61a1b1-27fd-4f3f-9d8a-9db0b2c35f5e");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "PropertySpaceId",
                value: "e5dc74e1-d3c0-4878-8e9c-c4dc10fdbf0f");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "PropertySpaceId",
                value: "e1de9d5c-8232-44cc-9abf-9c9a1f0a5e0f");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "PropertySpaceId",
                value: "b038b3db-c74d-4d2d-89a6-1ddf5c9580df");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "PropertySpaceId",
                value: "961aa4f3-45dc-4933-a47b-cba57c1f726b");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "PropertySpaceId",
                value: "87e0c991-e32c-4e9c-a780-96f5567a9bb1");

            migrationBuilder.UpdateData(
                table: "PropertySpaceItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "PropertySpaceId",
                value: "ed9f2a7b-3e54-403e-b0ae-64ec33eec956");
        }
    }
}
