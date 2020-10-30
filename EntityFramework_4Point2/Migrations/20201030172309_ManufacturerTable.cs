using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework_4Point2.Migrations
{
    public partial class ManufacturerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "vehicle");

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerID",
                table: "vehicle",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "manufacturer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturer", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "FK_Vehicle_Manufacturer",
                table: "vehicle",
                column: "ManufacturerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Manufacturer",
                table: "vehicle",
                column: "ManufacturerID",
                principalTable: "manufacturer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Manufacturer",
                table: "vehicle");

            migrationBuilder.DropTable(
                name: "manufacturer");

            migrationBuilder.DropIndex(
                name: "FK_Vehicle_Manufacturer",
                table: "vehicle");

            migrationBuilder.DropColumn(
                name: "ManufacturerID",
                table: "vehicle");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "vehicle",
                type: "varchar(30)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_general_ci");
        }
    }
}
