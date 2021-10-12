using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscoverMoldova.Infrastructure.Migrations
{
    public partial class AddedRelantionhipBetweenResortsAndLocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resorts_Locations_LocationId",
                table: "Resorts");

            migrationBuilder.AlterColumn<long>(
                name: "LocationId",
                table: "Resorts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Resorts_Locations_LocationId",
                table: "Resorts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resorts_Locations_LocationId",
                table: "Resorts");

            migrationBuilder.AlterColumn<long>(
                name: "LocationId",
                table: "Resorts",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Resorts_Locations_LocationId",
                table: "Resorts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
