using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Machine_arts.Migrations
{
    public partial class CreateGradevinskaVozila : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GradevinskoVozilo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Slika = table.Column<string>(type: "TEXT", nullable: false),
                    Cijena = table.Column<string>(type: "TEXT", nullable: false),
                    Specifikacije = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradevinskoVozilo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GradevinskoVozilo");
        }
    }
}
