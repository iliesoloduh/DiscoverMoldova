using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscoverMoldova.Infrastructure.Migrations
{
    public partial class AddedResortFacilitiesEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResortFacility",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResortId = table.Column<long>(type: "bigint", nullable: false),
                    FacilityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResortFacility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResortFacility_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResortFacility_Resorts_ResortId",
                        column: x => x.ResortId,
                        principalTable: "Resorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResortFacility_FacilityId",
                table: "ResortFacility",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ResortFacility_ResortId",
                table: "ResortFacility",
                column: "ResortId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResortFacility");

            migrationBuilder.DropTable(
                name: "Facility");
        }
    }
}
