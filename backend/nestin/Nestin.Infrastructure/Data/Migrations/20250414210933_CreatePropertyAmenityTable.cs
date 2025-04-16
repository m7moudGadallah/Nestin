using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatePropertyAmenityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyFee_Properties_PropertyId",
                table: "PropertyFee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyFee",
                table: "PropertyFee");

            migrationBuilder.RenameTable(
                name: "PropertyFee",
                newName: "PropertyFees");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyFee_PropertyId",
                table: "PropertyFees",
                newName: "IX_PropertyFees_PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyFees",
                table: "PropertyFees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PropertyAmenities",
                columns: table => new
                {
                    AmenityId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAmenities", x => new { x.PropertyId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_PropertyAmenities_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyAmenities_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAmenities_AmenityId",
                table: "PropertyAmenities",
                column: "AmenityId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyFees_Properties_PropertyId",
                table: "PropertyFees",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyFees_Properties_PropertyId",
                table: "PropertyFees");

            migrationBuilder.DropTable(
                name: "PropertyAmenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyFees",
                table: "PropertyFees");

            migrationBuilder.RenameTable(
                name: "PropertyFees",
                newName: "PropertyFee");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyFees_PropertyId",
                table: "PropertyFee",
                newName: "IX_PropertyFee_PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyFee",
                table: "PropertyFee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyFee_Properties_PropertyId",
                table: "PropertyFee",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
