using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatePropertySpacesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertySpaces",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PropertySpaceTypeId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsShared = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertySpaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertySpaces_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertySpaces_PropertySpaceTypes_PropertySpaceTypeId",
                        column: x => x.PropertySpaceTypeId,
                        principalTable: "PropertySpaceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertySpaces_PropertyId",
                table: "PropertySpaces",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySpaces_PropertySpaceTypeId",
                table: "PropertySpaces",
                column: "PropertySpaceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertySpaces");
        }
    }
}
