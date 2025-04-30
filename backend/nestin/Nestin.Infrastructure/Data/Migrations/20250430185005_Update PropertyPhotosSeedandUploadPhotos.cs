using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePropertyPhotosSeedandUploadPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileUploads",
                keyColumn: "Id",
                keyValue: "4c376b94-d74f-4472-b1a5-4c3d51df56d8",
                column: "Path",
                value: "images/Arg2.jpg");

            migrationBuilder.UpdateData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "3cb5e765-921f-4e0e-97be-b6d1e4c762cf",
                column: "PropertyId",
                value: "c150e428-1c9a-43a2-be07-f4366875f1ce");

            migrationBuilder.UpdateData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "a73860df-b173-4d4d-b834-124f19d93a20e",
                column: "PropertyId",
                value: "c150e428-1c9a-43a2-be07-f4366875f1ce");

            migrationBuilder.UpdateData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "f4b528d3-1204-4ccc-af05-2a39346d7ace",
                column: "PropertyId",
                value: "c150e428-1c9a-43a2-be07-f4366875f1ce");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FileUploads",
                keyColumn: "Id",
                keyValue: "4c376b94-d74f-4472-b1a5-4c3d51df56d8",
                column: "Path",
                value: "images/Arg2.avif");

            migrationBuilder.UpdateData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "3cb5e765-921f-4e0e-97be-b6d1e4c762cf",
                column: "PropertyId",
                value: "52a8df7d-c0b2-4ee3-8369-9daed4885f9f");

            migrationBuilder.UpdateData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "a73860df-b173-4d4d-b834-124f19d93a20e",
                column: "PropertyId",
                value: "52a8df7d-c0b2-4ee3-8369-9daed4885f9f");

            migrationBuilder.UpdateData(
                table: "PropertyPhotos",
                keyColumn: "PhotoId",
                keyValue: "f4b528d3-1204-4ccc-af05-2a39346d7ace",
                column: "PropertyId",
                value: "52a8df7d-c0b2-4ee3-8369-9daed4885f9f");
        }
    }
}
