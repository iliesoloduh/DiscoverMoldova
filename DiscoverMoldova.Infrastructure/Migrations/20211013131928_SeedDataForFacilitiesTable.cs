using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscoverMoldova.Infrastructure.Migrations
{
    public partial class SeedDataForFacilitiesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Wifi" },
                    { 2, "Swimming pool" },
                    { 3, "Sauna" },
                    { 4, "BBQ" },
                    { 5, "Parking" },
                    { 6, "Soccer field" },
                    { 7, "Volleyball field" },
                    { 8, "Basketball field" },
                    { 9, "Billiard room" },
                    { 10, "Restaurant" },
                    { 11, "TV" },
                    { 12, "Fridge"}
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Facilities");
        }
    }
}
