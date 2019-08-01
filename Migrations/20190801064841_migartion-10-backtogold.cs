using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class migartion10backtogold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ItemPriceItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemPriceItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemPriceItemId",
                table: "Items");

            migrationBuilder.AddColumn<long>(
                name: "ItemPrice",
                table: "Items",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "Items");

            migrationBuilder.AddColumn<long>(
                name: "ItemPriceItemId",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemPriceItemId",
                table: "Items",
                column: "ItemPriceItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ItemPriceItemId",
                table: "Items",
                column: "ItemPriceItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
