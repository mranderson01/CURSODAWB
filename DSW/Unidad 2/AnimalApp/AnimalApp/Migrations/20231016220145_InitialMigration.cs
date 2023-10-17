using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idPropietario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Propietario_idPropietario",
                        column: x => x.idPropietario,
                        principalTable: "Propietario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Propietario",
                columns: new[] { "Id", "Name", "Number", "Surname" },
                values: new object[] { 1, "Jhenny", "666 666 666", "Alaca" });

            migrationBuilder.InsertData(
                table: "Propietario",
                columns: new[] { "Id", "Name", "Number", "Surname" },
                values: new object[] { 2, "Rodrigo", "666 666 666", "Sucapuca Alaca" });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "Id", "Description", "Name", "idPropietario" },
                values: new object[] { 1, "Es un gato de color negro y blanco", "Fitipanlis", 1 });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "Id", "Description", "Name", "idPropietario" },
                values: new object[] { 2, "Es un crocodilo muy grande", "Renekton", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_idPropietario",
                table: "Animal",
                column: "idPropietario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Propietario");
        }
    }
}
