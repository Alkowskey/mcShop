using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class Migrate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_userId1",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_userId1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "userId1",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "mcItemName",
                table: "Items",
                newName: "McItemName");

            migrationBuilder.RenameColumn(
                name: "mcItemId",
                table: "Items",
                newName: "McItemId");

            migrationBuilder.RenameColumn(
                name: "itemQuantity",
                table: "Items",
                newName: "ItemQuantity");

            migrationBuilder.RenameColumn(
                name: "itemPrice",
                table: "Items",
                newName: "ItemPrice");

            migrationBuilder.RenameColumn(
                name: "dateOfCreation",
                table: "Items",
                newName: "DateOfCreation");

            migrationBuilder.RenameColumn(
                name: "itemId",
                table: "Items",
                newName: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "McItemName",
                table: "Items",
                newName: "mcItemName");

            migrationBuilder.RenameColumn(
                name: "McItemId",
                table: "Items",
                newName: "mcItemId");

            migrationBuilder.RenameColumn(
                name: "ItemQuantity",
                table: "Items",
                newName: "itemQuantity");

            migrationBuilder.RenameColumn(
                name: "ItemPrice",
                table: "Items",
                newName: "itemPrice");

            migrationBuilder.RenameColumn(
                name: "DateOfCreation",
                table: "Items",
                newName: "dateOfCreation");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Items",
                newName: "itemId");

            migrationBuilder.AddColumn<long>(
                name: "userId1",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_userId1",
                table: "Items",
                column: "userId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_userId1",
                table: "Items",
                column: "userId1",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
