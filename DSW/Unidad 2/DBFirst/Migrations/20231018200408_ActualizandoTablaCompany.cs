using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBFirst.Migrations
{
    /// <inheritdoc />
    public partial class ActualizandoTablaCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipperID",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_ShipperID",
                table: "Company",
                column: "ShipperID");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Shippers_ShipperID",
                table: "Company",
                column: "ShipperID",
                principalTable: "Shippers",
                principalColumn: "ShipperID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Shippers_ShipperID",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_ShipperID",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "ShipperID",
                table: "Company");
        }
    }
}
