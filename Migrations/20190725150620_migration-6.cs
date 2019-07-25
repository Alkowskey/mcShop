using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemPrice",
                table: "Items",
                newName: "ItemPriceItemId");

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ItemPriceItemId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemPriceItemId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ItemPriceItemId",
                table: "Items",
                newName: "ItemPrice");
        }
    }
}
