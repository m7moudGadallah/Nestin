using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPropertyFeesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Name" },
                values: new object[] { 1200m, "Cleaning Fee" });

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Name" },
                values: new object[] { 600m, "Pet Fee" });

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "PropertyId" },
                values: new object[] { 950.50m, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" });

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Name", "PropertyId" },
                values: new object[] { 900.12m, "Cleaning Fee", "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "Name", "PropertyId" },
                values: new object[] { 330.00m, "Extra Guest Fee", "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" });

            migrationBuilder.InsertData(
                table: "PropertyFees",
                columns: new[] { "Id", "Amount", "Name", "PropertyId" },
                values: new object[,]
                {
                    { 9, 442.09m, "Pet Fee", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" },
                    { 10, 800.75m, "Cleaning Fee", "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" },
                    { 11, 113.09m, "Cleaning Fee", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" },
                    { 12, 510.00m, "Cleaning Fee", "4b04a76a-1608-4a8f-b09c-8d9043b83e16" },
                    { 13, 250.00m, "Pet Fee", "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1" },
                    { 14, 789.99m, "Cleaning Fee", "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c" },
                    { 15, 199.99m, "Extra Guest Fee", "3c0e361a-51df-4e03-b8d0-2d7601aa60f6" },
                    { 16, 450.00m, "Cleaning Fee", "c5c0d4db-b048-4ee4-8835-344900fd35b2" },
                    { 17, 320.00m, "Pet Fee", "0bb50f31-e322-4b76-97dd-6a7fcf585d33" },
                    { 18, 670.00m, "Cleaning Fee", "a555515a-ff8a-4741-b0a4-db9be729198e" },
                    { 19, 275.50m, "Extra Guest Fee", "c10d2d46-869a-46bc-a46d-90bdd958c252" },
                    { 20, 390.00m, "Cleaning Fee", "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08" },
                    { 21, 425.99m, "Cleaning Fee", "294e2751-203b-4beb-b21e-0bb96f082d7c" },
                    { 22, 515.49m, "Pet Fee", "06dbae08-bc6b-4ca6-9162-3213784b9971" },
                    { 23, 398.89m, "Extra Guest Fee", "f1e8be41-4fd5-47e4-8960-12d8f4afc273" },
                    { 24, 300.00m, "Cleaning Fee", "763e6c5f-1ad1-4071-b0e6-55e924624198" },
                    { 25, 345.00m, "Cleaning Fee", "efd964ab-dceb-4b96-b113-665c5684a102" },
                    { 26, 410.00m, "Pet Fee", "52a8df7d-c0b2-4ee3-8369-9daed4885f9f" },
                    { 27, 289.00m, "Extra Guest Fee", "c150e428-1c9a-43a2-be07-f4366875f1ce" },
                    { 28, 378.00m, "Cleaning Fee", "2e3ed231-a2a6-4961-a1ba-f232d56c6f35" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Name" },
                values: new object[] { 600m, "Pet Fee" });

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Name" },
                values: new object[] { 1200m, "Cleaning Fee" });

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "PropertyId" },
                values: new object[] { 900.12m, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Name", "PropertyId" },
                values: new object[] { 442.09m, "Extra Guest Fee", "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" });

            migrationBuilder.UpdateData(
                table: "PropertyFees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "Name", "PropertyId" },
                values: new object[] { 113.09m, "Cleaning Fee", "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" });
        }
    }
}
