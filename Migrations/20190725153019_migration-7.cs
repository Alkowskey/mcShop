using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ItemPriceItemId",
                table: "Items");

            migrationBuilder.AlterColumn<long>(
                name: "ItemPriceItemId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ItemPriceItemId",
                table: "Items",
                column: "ItemPriceItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Items_ItemPriceItemId",
                table: "Items");

            migrationBuilder.AlterColumn<long>(
                name: "ItemPriceItemId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Items_ItemPriceItemId",
                table: "Items",
                column: "ItemPriceItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
