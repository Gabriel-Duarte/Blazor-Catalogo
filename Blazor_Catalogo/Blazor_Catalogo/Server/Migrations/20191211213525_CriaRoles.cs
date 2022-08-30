using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor_Catalogo.Server.Migrations
{
    public partial class CriaRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd15fae6-e1b1-4dfd-aa33-350d691049b1", "b17d42b9-8cdd-4f62-9e5a-8b121f59bb96", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cce6ff5d-a60c-4022-972f-6fc4cf839c3e", "150bfd1b-3850-4f08-ab7f-2b51f2df383d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd15fae6-e1b1-4dfd-aa33-350d691049b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cce6ff5d-a60c-4022-972f-6fc4cf839c3e");
        }
    }
}
