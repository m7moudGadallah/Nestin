using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPropertySpaceSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "14a66729-9580-472b-9438-dfc7e2440c95", "Office", "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", 6 },
                    { "188b8c66-66fa-42a2-944c-4fd3f048250c", "Closet", "c10d2d46-869a-46bc-a46d-90bdd958c252", 13 },
                    { "1954cfa5-9c89-41a7-a6be-41c71b34efc9", "Sunroom", "0bb50f31-e322-4b76-97dd-6a7fcf585d33", 12 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "1cc7112f-3bb5-4265-8e0a-b305274c0410", true, "Gym", "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c", 6 },
                    { "29ac2c68-b4b4-45b8-918a-fbdf11660d7e", true, "Playroom", "52a8df7d-c0b2-4ee3-8369-9daed4885f9f", 14 },
                    { "30baf72d-9d00-4f3e-9405-2261d6f0dd76", true, "Study", "f1e8be41-4fd5-47e4-8960-12d8f4afc273", 6 },
                    { "325e05d6-cc5d-4140-b1bc-d96fc52d86b3", true, "Living Room", "3e7f99ab-228a-4d90-91c4-6adf8c12e048", 4 },
                    { "49f23d20-c9ae-4a77-9734-1886d424cb77", true, "Laundry Room", "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08", 7 },
                    { "5eb1c7e5-efb6-4b3c-983f-d278c1c086e7", true, "Reception", "294e2751-203b-4beb-b21e-0bb96f082d7c", 8 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "62b66c76-60d1-4b4b-8e97-bfd0338ea05a", "Bathroom", "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", 2 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "6b09c3a9-e319-45d0-a253-b5d6f4f9de3a", true, "Porch", "763e6c5f-1ad1-4071-b0e6-55e924624198", 9 },
                    { "6c67a41a-8274-4ad0-864e-20fd4866b2d4", true, "Theater", "3c0e361a-51df-4e03-b8d0-2d7601aa60f6", 15 },
                    { "726d598e-c948-41b6-8cc3-c7e1aa4a51e4", true, "Dining Room", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", 5 },
                    { "846b07ee-bb17-4c94-82df-99f1f7643ea3", true, "Pantry", "c5c0d4db-b048-4ee4-8835-344900fd35b2", 11 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "8cf76f1f-7f39-4d78-bcc7-2a2a34db54b3", "Utility Room", "c150e428-1c9a-43a2-be07-f4366875f1ce", 15 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "96f6a377-d586-44a2-acc7-fc45c10d999c", true, "Library", "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1", 6 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "9f5f9e6e-0d79-41ad-86a1-06cbff2d0e92", "Guest Room", "06dbae08-bc6b-4ca6-9162-3213784b9971", 1 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "b09ce60b-b66b-47df-9985-41d1e7f6b254", true, "Balcony", "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", 9 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "c6ae89de-0d1a-4e5a-9230-8ef6617a3b53", "Hallway", "a555515a-ff8a-4741-b0a4-db9be729198e", 10 },
                    { "c8f09e6f-8c82-4026-b3ec-23be0a378a56", "Storage", "4b04a76a-1608-4a8f-b09c-8d9043b83e16", 16 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "d20a85b2-4019-4714-a63e-e017b4be4e3e", true, "Kitchen", "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", 3 });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[,]
                {
                    { "d2e5f682-06d0-40e7-a1e7-002b958d8048", "Workshop", "efd964ab-dceb-4b96-b113-665c5684a102", 13 },
                    { "daae3bd2-707e-4374-9b6c-5703f9789c7f", "Bedroom", "cc4e48ea-ca54-4d32-a448-3c2c9d14f936", 1 }
                });

            migrationBuilder.InsertData(
                table: "PropertySpaces",
                columns: new[] { "Id", "IsShared", "Name", "PropertyId", "PropertySpaceTypeId" },
                values: new object[] { "f8c7fef3-70f4-4650-baa6-f93db77dfd92", true, "Game Room", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", 14 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "14a66729-9580-472b-9438-dfc7e2440c95");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "188b8c66-66fa-42a2-944c-4fd3f048250c");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "1954cfa5-9c89-41a7-a6be-41c71b34efc9");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "1cc7112f-3bb5-4265-8e0a-b305274c0410");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "29ac2c68-b4b4-45b8-918a-fbdf11660d7e");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "30baf72d-9d00-4f3e-9405-2261d6f0dd76");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "325e05d6-cc5d-4140-b1bc-d96fc52d86b3");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "49f23d20-c9ae-4a77-9734-1886d424cb77");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "5eb1c7e5-efb6-4b3c-983f-d278c1c086e7");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "62b66c76-60d1-4b4b-8e97-bfd0338ea05a");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "6b09c3a9-e319-45d0-a253-b5d6f4f9de3a");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "6c67a41a-8274-4ad0-864e-20fd4866b2d4");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "726d598e-c948-41b6-8cc3-c7e1aa4a51e4");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "846b07ee-bb17-4c94-82df-99f1f7643ea3");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "8cf76f1f-7f39-4d78-bcc7-2a2a34db54b3");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "96f6a377-d586-44a2-acc7-fc45c10d999c");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "9f5f9e6e-0d79-41ad-86a1-06cbff2d0e92");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "b09ce60b-b66b-47df-9985-41d1e7f6b254");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "c6ae89de-0d1a-4e5a-9230-8ef6617a3b53");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "c8f09e6f-8c82-4026-b3ec-23be0a378a56");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "d20a85b2-4019-4714-a63e-e017b4be4e3e");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "d2e5f682-06d0-40e7-a1e7-002b958d8048");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "daae3bd2-707e-4374-9b6c-5703f9789c7f");

            migrationBuilder.DeleteData(
                table: "PropertySpaces",
                keyColumn: "Id",
                keyValue: "f8c7fef3-70f4-4650-baa6-f93db77dfd92");

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
    }
}
