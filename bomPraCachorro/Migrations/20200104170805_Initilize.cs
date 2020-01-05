using Microsoft.EntityFrameworkCore.Migrations;

namespace bomPraCachorro.Migrations
{
    public partial class Initilize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especies",
                columns: table => new
                {
                    EspecieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especies", x => x.EspecieId);
                });

            migrationBuilder.CreateTable(
                name: "TipoPontos",
                columns: table => new
                {
                    TipoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImagemTipo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPontos", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserLogin = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Cel = table.Column<int>(nullable: false),
                    DDD = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Especies = table.Column<int>(nullable: true),
                    Raca = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animais_Especies_Especies",
                        column: x => x.Especies,
                        principalTable: "Especies",
                        principalColumn: "EspecieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pontos",
                columns: table => new
                {
                    PontoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rua = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    TipoPontos = table.Column<int>(nullable: true),
                    Usuarios = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontos", x => x.PontoId);
                    table.ForeignKey(
                        name: "FK_Pontos_TipoPontos_TipoPontos",
                        column: x => x.TipoPontos,
                        principalTable: "TipoPontos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pontos_Usuarios_Usuarios",
                        column: x => x.Usuarios,
                        principalTable: "Usuarios",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animais_Especies",
                table: "Animais",
                column: "Especies");

            migrationBuilder.CreateIndex(
                name: "IX_Pontos_TipoPontos",
                table: "Pontos",
                column: "TipoPontos");

            migrationBuilder.CreateIndex(
                name: "IX_Pontos_Usuarios",
                table: "Pontos",
                column: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Pontos");

            migrationBuilder.DropTable(
                name: "Especies");

            migrationBuilder.DropTable(
                name: "TipoPontos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
