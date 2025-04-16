using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatePropertySpaceItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertySpaceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertySpaceItemTypeId = table.Column<int>(type: "int", nullable: true),
                    PropertySpaceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertySpaceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertySpaceItems_PropertySpaceItemTypes_PropertySpaceItemTypeId",
                        column: x => x.PropertySpaceItemTypeId,
                        principalTable: "PropertySpaceItemTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropertySpaceItems_PropertySpaces_PropertySpaceId",
                        column: x => x.PropertySpaceId,
                        principalTable: "PropertySpaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertySpaceItems_PropertySpaceId",
                table: "PropertySpaceItems",
                column: "PropertySpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertySpaceItems_PropertySpaceItemTypeId",
                table: "PropertySpaceItems",
                column: "PropertySpaceItemTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertySpaceItems");
        }
    }
}
