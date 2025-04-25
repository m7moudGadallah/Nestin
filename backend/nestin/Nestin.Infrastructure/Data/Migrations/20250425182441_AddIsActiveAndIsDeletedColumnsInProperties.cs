using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActiveAndIsDeletedColumnsInProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Properties",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "3e7f99ab-228a-4d90-91c4-6adf8c12e048",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "4e3d342-8e8d-4f1d-8123-2d09cb92b6a2",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "5ca2f710-3c1f-4966-a924-7bcdf5ce57aa",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "8e95f4b1-dc1d-4b4d-8102-09b7fbb88ec4",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "a43ecbfa-7b0a-4f6b-9c88-987be3c4e3d3",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "cc4e48ea-ca54-4d32-a448-3c2c9d14f936",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "d8eecb1f-5583-4d64-a7dc-5aef5e2c498f",
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "f1cc1b4c-b674-4a1a-89ee-5f7b4d44d2f7",
                column: "IsActive",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Properties");
        }
    }
}
