using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscoverMoldova.Infrastructure.Migrations
{
    public partial class AddedResortDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resort_Users_UserId",
                table: "Resort");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resort",
                table: "Resort");

            migrationBuilder.RenameTable(
                name: "Resort",
                newName: "Resorts");

            migrationBuilder.RenameIndex(
                name: "IX_Resort_UserId",
                table: "Resorts",
                newName: "IX_Resorts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resorts",
                table: "Resorts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resorts_Users_UserId",
                table: "Resorts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resorts_Users_UserId",
                table: "Resorts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resorts",
                table: "Resorts");

            migrationBuilder.RenameTable(
                name: "Resorts",
                newName: "Resort");

            migrationBuilder.RenameIndex(
                name: "IX_Resorts_UserId",
                table: "Resort",
                newName: "IX_Resort_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resort",
                table: "Resort",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resort_Users_UserId",
                table: "Resort",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
