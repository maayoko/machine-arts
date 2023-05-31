using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Machine_arts.Migrations
{
    public partial class CreateRest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bager",
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
                    table.PrimaryKey("PK_Bager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buldozer",
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
                    table.PrimaryKey("PK_Buldozer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Demper",
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
                    table.PrimaryKey("PK_Demper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kiper",
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
                    table.PrimaryKey("PK_Kiper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kombinirka",
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
                    table.PrimaryKey("PK_Kombinirka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KranDizalica",
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
                    table.PrimaryKey("PK_KranDizalica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mikser",
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
                    table.PrimaryKey("PK_Mikser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tegljac",
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
                    table.PrimaryKey("PK_Tegljac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utovarivac",
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
                    table.PrimaryKey("PK_Utovarivac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valjak",
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
                    table.PrimaryKey("PK_Valjak", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bager");

            migrationBuilder.DropTable(
                name: "Buldozer");

            migrationBuilder.DropTable(
                name: "Demper");

            migrationBuilder.DropTable(
                name: "Kiper");

            migrationBuilder.DropTable(
                name: "Kombinirka");

            migrationBuilder.DropTable(
                name: "KranDizalica");

            migrationBuilder.DropTable(
                name: "Mikser");

            migrationBuilder.DropTable(
                name: "Tegljac");

            migrationBuilder.DropTable(
                name: "Utovarivac");

            migrationBuilder.DropTable(
                name: "Valjak");
        }
    }
}
