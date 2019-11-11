using Microsoft.EntityFrameworkCore.Migrations;

namespace Cashback.Context.Migrations
{
    public partial class SaleTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SaleItem_AlbumID",
                table: "SaleItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
