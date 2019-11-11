using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cashback.Context.Migrations
{
    public partial class SaleAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleItem_Cashbacks_CashbackID",
                table: "SaleItem");

            migrationBuilder.DropIndex(
                name: "IX_SaleItem_CashbackID",
                table: "SaleItem");

            migrationBuilder.DropColumn(
                name: "CashbackID",
                table: "SaleItem");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "SaleItem",
                newName: "UnitaryValue");

            migrationBuilder.RenameColumn(
                name: "CashbackValue",
                table: "SaleItem",
                newName: "TotalValue");

            migrationBuilder.AddColumn<decimal>(
                name: "CashbackTotalValue",
                table: "SaleItem",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CashbackUnitaryValue",
                table: "SaleItem",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Sale",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CashbackTotalValue",
                table: "SaleItem");

            migrationBuilder.DropColumn(
                name: "CashbackUnitaryValue",
                table: "SaleItem");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Sale");

            migrationBuilder.RenameColumn(
                name: "UnitaryValue",
                table: "SaleItem",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "TotalValue",
                table: "SaleItem",
                newName: "CashbackValue");

            migrationBuilder.AddColumn<int>(
                name: "CashbackID",
                table: "SaleItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_CashbackID",
                table: "SaleItem",
                column: "CashbackID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleItem_Cashbacks_CashbackID",
                table: "SaleItem",
                column: "CashbackID",
                principalTable: "Cashbacks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
