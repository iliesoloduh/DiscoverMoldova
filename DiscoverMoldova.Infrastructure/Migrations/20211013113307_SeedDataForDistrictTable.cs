using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscoverMoldova.Infrastructure.Migrations
{
    public partial class SeedDataForDistrictTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Anenii Noi" },
                    { 2, "Basarabeasca" },
                    { 3, "Bălți" },
                    { 4, "Bender" },
                    { 5, "Briceni" },
                    { 6, "Cahul" },
                    { 7, "Cantemir" },
                    { 8, "Călărași" },
                    { 9, "Căușeni" },
                    { 10, "Chișinău" },
                    { 11, "Comrat" },
                    { 12, "Cimișlia" },
                    { 13, "Criuleni" },
                    { 14, "Dondușeni" },
                    { 15, "Drochia" },
                    { 16, "Dubăsari" },
                    { 17, "Edineț" },
                    { 18, "Fălești" },
                    { 19, "Florești" },
                    { 20, "Glodeni" },
                    { 21, "Hîncești" },
                    { 22, "Ialoveni" },
                    { 23, "Leova" },
                    { 24, "Nisporeni" },
                    { 25, "Ocnița" },
                    { 26, "Orhei" },
                    { 27, "Rezina" },
                    { 28, "Rîșcani" },
                    { 29, "Sîngerei" },
                    { 30, "Șoldănești" },
                    { 31, "Soroca" },
                    { 32, "Ștefan Vodă" },
                    { 33, "Strășeni" },
                    { 34, "Taraclia" },
                    { 35, "Telenești" },
                    { 36, "Tiraspol" },
                    { 37, "Ungheni" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Districts");
        }
    }
}
