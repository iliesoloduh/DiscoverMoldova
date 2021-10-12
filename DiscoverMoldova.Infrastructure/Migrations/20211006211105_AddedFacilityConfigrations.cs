using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscoverMoldova.Infrastructure.Migrations
{
    public partial class AddedFacilityConfigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResortFacility_Facility_FacilityId",
                table: "ResortFacility");

            migrationBuilder.DropForeignKey(
                name: "FK_ResortFacility_Resorts_ResortId",
                table: "ResortFacility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResortFacility",
                table: "ResortFacility");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facility",
                table: "Facility");

            migrationBuilder.RenameTable(
                name: "ResortFacility",
                newName: "ResortFacilities");

            migrationBuilder.RenameTable(
                name: "Facility",
                newName: "Facilities");

            migrationBuilder.RenameIndex(
                name: "IX_ResortFacility_ResortId",
                table: "ResortFacilities",
                newName: "IX_ResortFacilities_ResortId");

            migrationBuilder.RenameIndex(
                name: "IX_ResortFacility_FacilityId",
                table: "ResortFacilities",
                newName: "IX_ResortFacilities_FacilityId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Facilities",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResortFacilities",
                table: "ResortFacilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResortFacilities_Facilities_FacilityId",
                table: "ResortFacilities",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResortFacilities_Resorts_ResortId",
                table: "ResortFacilities",
                column: "ResortId",
                principalTable: "Resorts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResortFacilities_Facilities_FacilityId",
                table: "ResortFacilities");

            migrationBuilder.DropForeignKey(
                name: "FK_ResortFacilities_Resorts_ResortId",
                table: "ResortFacilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResortFacilities",
                table: "ResortFacilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities");

            migrationBuilder.RenameTable(
                name: "ResortFacilities",
                newName: "ResortFacility");

            migrationBuilder.RenameTable(
                name: "Facilities",
                newName: "Facility");

            migrationBuilder.RenameIndex(
                name: "IX_ResortFacilities_ResortId",
                table: "ResortFacility",
                newName: "IX_ResortFacility_ResortId");

            migrationBuilder.RenameIndex(
                name: "IX_ResortFacilities_FacilityId",
                table: "ResortFacility",
                newName: "IX_ResortFacility_FacilityId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Facility",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResortFacility",
                table: "ResortFacility",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facility",
                table: "Facility",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResortFacility_Facility_FacilityId",
                table: "ResortFacility",
                column: "FacilityId",
                principalTable: "Facility",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResortFacility_Resorts_ResortId",
                table: "ResortFacility",
                column: "ResortId",
                principalTable: "Resorts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
