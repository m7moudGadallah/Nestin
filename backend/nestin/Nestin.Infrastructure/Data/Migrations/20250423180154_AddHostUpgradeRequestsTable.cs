using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddHostUpgradeRequestsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HostUpgradeRequests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FrontPhotoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BackPhotoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostUpgradeRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostUpgradeRequests_AspNetUsers_ApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HostUpgradeRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HostUpgradeRequests_FileUploads_BackPhotoId",
                        column: x => x.BackPhotoId,
                        principalTable: "FileUploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HostUpgradeRequests_FileUploads_FrontPhotoId",
                        column: x => x.FrontPhotoId,
                        principalTable: "FileUploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HostUpgradeRequests_ApprovedBy",
                table: "HostUpgradeRequests",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HostUpgradeRequests_BackPhotoId",
                table: "HostUpgradeRequests",
                column: "BackPhotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HostUpgradeRequests_FrontPhotoId",
                table: "HostUpgradeRequests",
                column: "FrontPhotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HostUpgradeRequests_Status",
                table: "HostUpgradeRequests",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_HostUpgradeRequests_UserId",
                table: "HostUpgradeRequests",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HostUpgradeRequests");
        }
    }
}
