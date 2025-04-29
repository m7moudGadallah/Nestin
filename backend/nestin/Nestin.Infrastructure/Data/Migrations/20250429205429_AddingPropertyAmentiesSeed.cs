using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPropertyAmentiesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 3, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 11, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 1, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 51, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 4, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 14, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 30, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 16, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 61, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 2, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 11, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 22, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 42, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 8, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 28, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" });

            migrationBuilder.InsertData(
                table: "PropertyAmenities",
                columns: new[] { "AmenityId", "PropertyId" },
                values: new object[,]
                {
                    { 39, "06dbae08-bc6b-4ca6-9162-3213784b9971" },
                    { 44, "06dbae08-bc6b-4ca6-9162-3213784b9971" },
                    { 47, "06dbae08-bc6b-4ca6-9162-3213784b9971" },
                    { 34, "0bb50f31-e322-4b76-97dd-6a7fcf585d33" },
                    { 35, "0bb50f31-e322-4b76-97dd-6a7fcf585d33" },
                    { 53, "0bb50f31-e322-4b76-97dd-6a7fcf585d33" },
                    { 30, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08" },
                    { 39, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08" },
                    { 42, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08" },
                    { 17, "294e2751-203b-4beb-b21e-0bb96f082d7c" },
                    { 41, "294e2751-203b-4beb-b21e-0bb96f082d7c" },
                    { 43, "294e2751-203b-4beb-b21e-0bb96f082d7c" },
                    { 26, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1" },
                    { 27, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1" },
                    { 47, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1" },
                    { 29, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35" },
                    { 52, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35" },
                    { 59, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35" },
                    { 8, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6" },
                    { 30, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6" },
                    { 31, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6" },
                    { 7, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" },
                    { 13, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" },
                    { 22, "4b04a76a-1608-4a8f-b09c-8d9043b83e16" },
                    { 25, "4b04a76a-1608-4a8f-b09c-8d9043b83e16" },
                    { 34, "4b04a76a-1608-4a8f-b09c-8d9043b83e16" },
                    { 12, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" },
                    { 18, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" },
                    { 36, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f" },
                    { 49, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f" },
                    { 56, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f" },
                    { 8, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" },
                    { 16, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" },
                    { 14, "763e6c5f-1ad1-4071-b0e6-55e924624198" },
                    { 46, "763e6c5f-1ad1-4071-b0e6-55e924624198" },
                    { 53, "763e6c5f-1ad1-4071-b0e6-55e924624198" },
                    { 10, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" },
                    { 14, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" },
                    { 21, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" },
                    { 36, "a555515a-ff8a-4741-b0a4-db9be729198e" },
                    { 38, "a555515a-ff8a-4741-b0a4-db9be729198e" },
                    { 41, "a555515a-ff8a-4741-b0a4-db9be729198e" },
                    { 5, "c10d2d46-869a-46bc-a46d-90bdd958c252" },
                    { 37, "c10d2d46-869a-46bc-a46d-90bdd958c252" },
                    { 40, "c10d2d46-869a-46bc-a46d-90bdd958c252" },
                    { 19, "c150e428-1c9a-43a2-be07-f4366875f1ce" },
                    { 50, "c150e428-1c9a-43a2-be07-f4366875f1ce" },
                    { 58, "c150e428-1c9a-43a2-be07-f4366875f1ce" },
                    { 26, "c5c0d4db-b048-4ee4-8835-344900fd35b2" },
                    { 32, "c5c0d4db-b048-4ee4-8835-344900fd35b2" },
                    { 33, "c5c0d4db-b048-4ee4-8835-344900fd35b2" },
                    { 3, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
                    { 6, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
                    { 19, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" },
                    { 24, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" },
                    { 12, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c" },
                    { 28, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c" },
                    { 29, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c" },
                    { 7, "efd964ab-dceb-4b96-b113-665c5684a102" },
                    { 48, "efd964ab-dceb-4b96-b113-665c5684a102" },
                    { 54, "efd964ab-dceb-4b96-b113-665c5684a102" },
                    { 17, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" },
                    { 23, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" },
                    { 22, "f1e8be41-4fd5-47e4-8960-12d8f4afc273" },
                    { 45, "f1e8be41-4fd5-47e4-8960-12d8f4afc273" },
                    { 51, "f1e8be41-4fd5-47e4-8960-12d8f4afc273" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 39, "06dbae08-bc6b-4ca6-9162-3213784b9971" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 44, "06dbae08-bc6b-4ca6-9162-3213784b9971" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 47, "06dbae08-bc6b-4ca6-9162-3213784b9971" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 34, "0bb50f31-e322-4b76-97dd-6a7fcf585d33" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 35, "0bb50f31-e322-4b76-97dd-6a7fcf585d33" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 53, "0bb50f31-e322-4b76-97dd-6a7fcf585d33" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 30, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 39, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 42, "1adca40b-b8ff-4cea-b6e4-8e5f40d29c08" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 17, "294e2751-203b-4beb-b21e-0bb96f082d7c" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 41, "294e2751-203b-4beb-b21e-0bb96f082d7c" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 43, "294e2751-203b-4beb-b21e-0bb96f082d7c" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 26, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 27, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 47, "2ab6e4d1-79b9-4dba-9109-22ef75a29ff1" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 29, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 52, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 59, "2e3ed231-a2a6-4961-a1ba-f232d56c6f35" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 8, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 30, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 31, "3c0e361a-51df-4e03-b8d0-2d7601aa60f6" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 7, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 13, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 22, "4b04a76a-1608-4a8f-b09c-8d9043b83e16" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 25, "4b04a76a-1608-4a8f-b09c-8d9043b83e16" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 34, "4b04a76a-1608-4a8f-b09c-8d9043b83e16" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 12, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 18, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 36, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 49, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 56, "52a8df7d-c0b2-4ee3-8369-9daed4885f9f" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 8, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 16, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 14, "763e6c5f-1ad1-4071-b0e6-55e924624198" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 46, "763e6c5f-1ad1-4071-b0e6-55e924624198" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 53, "763e6c5f-1ad1-4071-b0e6-55e924624198" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 10, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 14, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 21, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 36, "a555515a-ff8a-4741-b0a4-db9be729198e" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 38, "a555515a-ff8a-4741-b0a4-db9be729198e" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 41, "a555515a-ff8a-4741-b0a4-db9be729198e" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 5, "c10d2d46-869a-46bc-a46d-90bdd958c252" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 37, "c10d2d46-869a-46bc-a46d-90bdd958c252" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 40, "c10d2d46-869a-46bc-a46d-90bdd958c252" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 19, "c150e428-1c9a-43a2-be07-f4366875f1ce" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 50, "c150e428-1c9a-43a2-be07-f4366875f1ce" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 58, "c150e428-1c9a-43a2-be07-f4366875f1ce" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 26, "c5c0d4db-b048-4ee4-8835-344900fd35b2" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 32, "c5c0d4db-b048-4ee4-8835-344900fd35b2" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 33, "c5c0d4db-b048-4ee4-8835-344900fd35b2" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 3, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 6, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 19, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 24, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 12, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 28, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 29, "ef3b2df2-e539-4cb9-8eb6-4eeb833e694c" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 7, "efd964ab-dceb-4b96-b113-665c5684a102" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 48, "efd964ab-dceb-4b96-b113-665c5684a102" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 54, "efd964ab-dceb-4b96-b113-665c5684a102" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 17, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 23, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 22, "f1e8be41-4fd5-47e4-8960-12d8f4afc273" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 45, "f1e8be41-4fd5-47e4-8960-12d8f4afc273" });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { 51, "f1e8be41-4fd5-47e4-8960-12d8f4afc273" });

            migrationBuilder.InsertData(
                table: "PropertyAmenities",
                columns: new[] { "AmenityId", "PropertyId" },
                values: new object[,]
                {
                    { 3, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" },
                    { 11, "3e7f99ab-228a-4d90-91c4-6adf8c12e048" },
                    { 1, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" },
                    { 51, "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2" },
                    { 4, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" },
                    { 14, "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa" },
                    { 30, "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4" },
                    { 16, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" },
                    { 61, "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3" },
                    { 2, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
                    { 11, "cc4e48ea-ca54-4d32-a448-3c2c9d14f936" },
                    { 22, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" },
                    { 42, "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f" },
                    { 8, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" },
                    { 28, "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7" }
                });
        }
    }
}
