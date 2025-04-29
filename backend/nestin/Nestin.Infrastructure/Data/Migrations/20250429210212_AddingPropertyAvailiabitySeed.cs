using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPropertyAvailiabitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "EndDate",
                value: new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 11,
                column: "EndDate",
                value: new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "PropertyAvailabilities",
                columns: new[] { "Id", "EndDate", "IsAvailable", "PropertyId", "StartDate" },
                values: new object[,]
                {
                    { 14, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "3e7f99ab-228a-4d90-91c4-6adf8c12e048", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2025, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa", new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2", new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7", new DateTime(2025, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f", new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "4b04a76a-1608-4a8f-b09c-8d9043b83e16", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "4b04a76a-1608-4a8f-b09c-8d9043b83e16", new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "4b04a76a-1608-4a8f-b09c-8d9043b83e16", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c", new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c", new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c5c0d4db-b048-4ee4-8835-344900fd35b2", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c5c0d4db-b048-4ee4-8835-344900fd35b2", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c5c0d4db-b048-4ee4-8835-344900fd35b2", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0bb50f31-e322-4b76-97dd-6a7fcf585d33", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0bb50f31-e322-4b76-97dd-6a7fcf585d33", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "0bb50f31-e322-4b76-97dd-6a7fcf585d33", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "a555515a-ff8a-4741-b0a4-db9be729198e", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "a555515a-ff8a-4741-b0a4-db9be729198e", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "a555515a-ff8a-4741-b0a4-db9be729198e", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c10d2d46-869a-46bc-a46d-90bdd958c252", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c10d2d46-869a-46bc-a46d-90bdd958c252", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c10d2d46-869a-46bc-a46d-90bdd958c252", new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "294e2751-203b-4beb-b21e-0bb96f082d7c", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "294e2751-203b-4beb-b21e-0bb96f082d7c", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "294e2751-203b-4beb-b21e-0bb96f082d7c", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "06dbae08-bc6b-4ca6-9162-3213784b9971", new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "06dbae08-bc6b-4ca6-9162-3213784b9971", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "06dbae08-bc6b-4ca6-9162-3213784b9971", new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "f1e8be41-4fd5-47e4-8960-12d8f4afc273", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "f1e8be41-4fd5-47e4-8960-12d8f4afc273", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "f1e8be41-4fd5-47e4-8960-12d8f4afc273", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "763e6c5f-1ad1-4071-b0e6-55e924624198", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "763e6c5f-1ad1-4071-b0e6-55e924624198", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "763e6c5f-1ad1-4071-b0e6-55e924624198", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "efd964ab-dceb-4b96-b113-665c5684a102", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "efd964ab-dceb-4b96-b113-665c5684a102", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "efd964ab-dceb-4b96-b113-665c5684a102", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f", new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f", new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c150e428-1c9a-43a2-be07-f4366875f1ce", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c150e428-1c9a-43a2-be07-f4366875f1ce", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "c150e428-1c9a-43a2-be07-f4366875f1ce", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "EndDate",
                value: new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 11,
                column: "EndDate",
                value: new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PropertyAvailabilities",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
