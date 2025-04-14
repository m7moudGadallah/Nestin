using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatePropertySpaceItemTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertySpaceItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PropertySpaceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertySpaceItemTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertySpaceItemTypes_PropertySpaceTypes_PropertySpaceTypeId",
                        column: x => x.PropertySpaceTypeId,
                        principalTable: "PropertySpaceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertySpaceItemTypes_PropertySpaceTypeId",
                table: "PropertySpaceItemTypes",
                column: "PropertySpaceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertySpaceItemTypes");
        }
    }
}
