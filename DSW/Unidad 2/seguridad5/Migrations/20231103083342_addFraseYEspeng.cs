using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace seguridad5.Migrations
{
    /// <inheritdoc />
    public partial class addFraseYEspeng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frase",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhraseEng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhraseIng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idEspeng = table.Column<int>(type: "int", nullable: false),
                    Espengid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frase", x => x.id);
                    table.ForeignKey(
                        name: "FK_Frase_Espeng_Espengid",
                        column: x => x.Espengid,
                        principalTable: "Espeng",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Frase_Espengid",
                table: "Frase",
                column: "Espengid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frase");
        }
    }
}
