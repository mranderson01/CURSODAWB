using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace seguridad5.Migrations
{
    /// <inheritdoc />
    public partial class addSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43593827-057f-4cc7-a73b-4f52a7a9d708", "6ab5faff-da46-4158-9ca4-050b075538ec", "Basic", "BASIC" },
                    { "67d37a7a-4cb8-4708-8b93-190f1959618c", "5aaec23d-0c6e-48b3-a8e3-760a70d96515", "Premium", "PREMIUM" },
                    { "f21cfc8b-d40c-4a76-a45e-a1aac9a0c0a4", "86f3b215-fe9c-46d0-b664-f20b321da116", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "172e831a-915e-44de-84ae-1263fcd467c4", 0, "acbd05d2-4c99-4b79-b0d8-4f37aab68981", "basic@diccionario.com", false, false, null, null, "BASIC@DICCIONARIO.COM", "AQAAAAEAACcQAAAAEMEH8jGyjhX2lmx8//5xnCKI61IZn1JFDF2YGYN0eGPlsaofxM8yOCt+8tc4M5hCGw==", null, false, "204655ef-9b91-4082-b91c-c72d5d3deeb7", false, "basic@diccionario.com" },
                    { "6455ad8c-07a6-4aa4-84ac-294a931b0498", 0, "d9dccd74-05b8-4dd5-b21a-84d7e4a6f7d5", "admin@diccionario.com", false, false, null, null, "ADMIN@DICCIONARIO.COM", "AQAAAAEAACcQAAAAEFXJETcKlvxIdxo0e47j/mU1A03pKeW+In9+gDpweRLVw+564zMSqgb3FoeUedTwew==", null, false, "18b75eb7-6ddf-463b-bd08-682dfc694f22", false, "admin@diccionario.com" },
                    { "f43ff7af-623b-44e7-baf1-233d962c9534", 0, "0433a031-e2b7-4347-94e3-5da2bd2726fa", "premium@diccionario.com", false, false, null, null, "PREMIUM@DICCIONARIO.COM", "AQAAAAEAACcQAAAAEA+ZBYz3bAqrP9bsbk3p6zfyaWdx0LtaRkl9AoZCu+9NdReCNral3o1N4VWdYfmnYg==", null, false, "1a4db1f8-37be-4623-a8c1-7dcfa5df5086", false, "premium@diccionario.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "43593827-057f-4cc7-a73b-4f52a7a9d708", "172e831a-915e-44de-84ae-1263fcd467c4" },
                    { "f21cfc8b-d40c-4a76-a45e-a1aac9a0c0a4", "6455ad8c-07a6-4aa4-84ac-294a931b0498" },
                    { "67d37a7a-4cb8-4708-8b93-190f1959618c", "f43ff7af-623b-44e7-baf1-233d962c9534" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43593827-057f-4cc7-a73b-4f52a7a9d708", "172e831a-915e-44de-84ae-1263fcd467c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f21cfc8b-d40c-4a76-a45e-a1aac9a0c0a4", "6455ad8c-07a6-4aa4-84ac-294a931b0498" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67d37a7a-4cb8-4708-8b93-190f1959618c", "f43ff7af-623b-44e7-baf1-233d962c9534" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43593827-057f-4cc7-a73b-4f52a7a9d708");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67d37a7a-4cb8-4708-8b93-190f1959618c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f21cfc8b-d40c-4a76-a45e-a1aac9a0c0a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "172e831a-915e-44de-84ae-1263fcd467c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6455ad8c-07a6-4aa4-84ac-294a931b0498");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f43ff7af-623b-44e7-baf1-233d962c9534");
        }
    }
}
