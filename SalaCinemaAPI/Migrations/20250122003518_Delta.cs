using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SalaCinemaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Delta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    IdSala = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroSala = table.Column<int>(type: "integer", nullable: false),
                    NomeFilme = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.IdSala);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeFilme = table.Column<string>(type: "text", nullable: false),
                    Diretor = table.Column<string>(type: "text", nullable: false),
                    Duracao = table.Column<string>(type: "text", nullable: false),
                    SalaIdSala = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmes_Salas_SalaIdSala",
                        column: x => x.SalaIdSala,
                        principalTable: "Salas",
                        principalColumn: "IdSala");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_SalaIdSala",
                table: "Filmes",
                column: "SalaIdSala");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
