using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    BookingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cleanliness = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Accuracy = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    CheckIn = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Communication = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Location = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookingId",
                table: "Reviews",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CreatedAt",
                table: "Reviews",
                column: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
