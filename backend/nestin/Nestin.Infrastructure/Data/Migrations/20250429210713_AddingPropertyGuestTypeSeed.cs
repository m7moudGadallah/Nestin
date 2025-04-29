using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPropertyGuestTypeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 2, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 3, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 4, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 2, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 3, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 4, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" });

            migrationBuilder.InsertData(
                table: "PropertyGuests",
                columns: new[] { "GuestTypeId", "PropertyId", "GuestCount" },
                values: new object[,]
                {
                    { 3, "06dbae08-bc6b-4ca6-9162-3213784b9971", 4 },
                    { 2, "0bb50f31-e322-4b76-97dd-6a7fcf585d33", 4 },
                    { 1, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08", 5 },
                    { 2, "294e2751-203b-4beb-b21e-0bb96f082d7c", 2 },
                    { 1, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1", 5 },
                    { 1, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35", 2 },
                    { 1, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6", 4 },
                    { 1, "4b04a76a-1608-4a8f-b09c-8d9043b83e16", 3 },
                    { 1, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", 5 },
                    { 3, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f", 2 },
                    { 1, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", 2 },
                    { 1, "763e6c5f-1ad1-4071-b0e6-55e924624198", 3 },
                    { 1, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", 4 },
                    { 1, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", 2 },
                    { 3, "a555515a-ff8a-4741-b0a4-db9be729198e", 1 },
                    { 4, "c10d2d46-869a-46bc-a46d-90bdd958c252", 3 },
                    { 4, "c150e428-1c9a-43a2-be07-f4366875f1ce", 4 },
                    { 1, "c5c0d4db-b048-4ee4-8835-344900fd35b2", 2 },
                    { 1, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", 1 },
                    { 1, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c", 2 },
                    { 2, "efd964ab-dceb-4b96-b113-665c5684a102", 1 },
                    { 1, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", 4 },
                    { 4, "f1e8be41-4fd5-47e4-8960-12d8f4afc273", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 3, "06dbae08-bc6b-4ca6-9162-3213784b9971" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 2, "0bb50f31-e322-4b76-97dd-6a7fcf585d33" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 2, "294e2751-203b-4beb-b21e-0bb96f082d7c" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "4b04a76a-1608-4a8f-b09c-8d9043b83e16" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 3, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "763e6c5f-1ad1-4071-b0e6-55e924624198" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 3, "a555515a-ff8a-4741-b0a4-db9be729198e" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 4, "c10d2d46-869a-46bc-a46d-90bdd958c252" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 4, "c150e428-1c9a-43a2-be07-f4366875f1ce" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "c5c0d4db-b048-4ee4-8835-344900fd35b2" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 2, "efd964ab-dceb-4b96-b113-665c5684a102" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 1, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" });

            migrationBuilder.DeleteData(
                table: "PropertyGuests",
                keyColumns: new[] { "GuestTypeId", "PropertyId" },
                keyValues: new object[] { 4, "f1e8be41-4fd5-47e4-8960-12d8f4afc273" });

            migrationBuilder.InsertData(
                table: "PropertyGuests",
                columns: new[] { "GuestTypeId", "PropertyId", "GuestCount" },
                values: new object[,]
                {
                    { 2, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", 2 },
                    { 3, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", 1 },
                    { 4, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", 5 },
                    { 2, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", 6 },
                    { 3, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", 2 },
                    { 4, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", 3 }
                });
        }
    }
}
