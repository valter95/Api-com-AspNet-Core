using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class UsuarioAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "5f30bc12-1db3-4e59-b371-5b905b2f55a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c0b10fa-53c5-4fd5-87fe-3eb0c3dd979b", "AQAAAAEAACcQAAAAEHD48AjQBxsqUYKfz2Baw5h7muaUQZXOQAnXhp9tgbA1T9hjZhsngIdVMCGBgsEpew==", "b69e8ddd-13c2-45e1-9db4-53fc69b5de51" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "4e6ffc40-550c-4958-89ab-4f1e1b23e517");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2eecc8f-2125-46c9-8fa0-37e9f05c6413", "AQAAAAEAACcQAAAAENNQWq9tCfUjKj8oej/fvousBekVZR5eUu00Z/Jn2eU/ar8agIE/jrHeXsgmsQbfig==", "cecd0cb4-7f8a-45aa-b409-e6e3d2800ec0" });
        }
    }
}
