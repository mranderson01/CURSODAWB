using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersistenciaMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    IdMamifero = table.Column<int>(type: "int", nullable: false),
                    IdReptil = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: true),
                    Reptil_AnimalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Animal_Animal_Reptil_AnimalId",
                        column: x => x.Reptil_AnimalId,
                        principalTable: "Animal",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_AnimalId",
                table: "Animal",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_Reptil_AnimalId",
                table: "Animal",
                column: "Reptil_AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");
        }
    }
}
