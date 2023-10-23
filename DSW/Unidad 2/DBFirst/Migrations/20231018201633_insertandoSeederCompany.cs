using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DBFirst.Migrations
{
    /// <inheritdoc />
    public partial class insertandoSeederCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Description", "Name", "ShipperID" },
                values: new object[,]
                {
                    { 1, "Es la primera compañia", "OneCompany", null },
                    { 2, "Es la segunda compañia", "TwoCompany", null },
                    { 3, "Es la tercera compañia", "ThreeCompany", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
