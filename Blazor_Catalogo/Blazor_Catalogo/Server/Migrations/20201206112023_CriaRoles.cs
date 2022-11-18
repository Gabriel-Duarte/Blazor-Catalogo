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
                values: new object[] { "5ab9618a-a958-49b1-8f35-63191d7d9681", "1862655c-8735-402c-8d77-8241214d096e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0983ef4d-8205-49e6-be54-8898de26effd", "dbb4f7b2-5c9c-4dcd-9226-b29f747223eb", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0983ef4d-8205-49e6-be54-8898de26effd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ab9618a-a958-49b1-8f35-63191d7d9681");
        }
    }
}
