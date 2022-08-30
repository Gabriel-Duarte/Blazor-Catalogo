using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor_Catalogo.Server.Migrations
{
    public partial class AjusteImagemUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagemUrl",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagemUrl",
                table: "Produtos",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
