using Microsoft.EntityFrameworkCore.Migrations;

namespace crudDotnet.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    FilmeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmeNome = table.Column<string>(nullable: true),
                    FilmeSinopse = table.Column<string>(nullable: true),
                    FilmeAnoLancamento = table.Column<int>(nullable: false),
                    FilmeImdb = table.Column<double>(nullable: false),
                    FilmeUrlImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.FilmeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
