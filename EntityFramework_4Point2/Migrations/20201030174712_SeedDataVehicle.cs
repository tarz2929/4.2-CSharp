using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework_4Point2.Migrations
{
    public partial class SeedDataVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "vehicle",
                columns: new[] { "ID", "Colour", "ManufacturerID", "Model", "ModelYear" },
                values: new object[,]
                {
                    { -1, "Blue", -1, "Fusion", 2010 },
                    { -2, "Black", -1, "Escape", 2014 },
                    { -3, "Red", -2, "Cruze", 2012 },
                    { -4, "Black", -3, "Ram", 2018 },
                    { -5, "Blue", -3, "Charger", 2016 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
