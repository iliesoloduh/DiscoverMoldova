using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscoverMoldova.Infrastructure.Migrations
{
    public partial class AddedDescriptionFieldToResort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Resorts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Resorts");
        }
    }
}
