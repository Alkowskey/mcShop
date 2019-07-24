using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class Migrate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_userId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "mcUsername",
                table: "Users",
                newName: "McUsername");

            migrationBuilder.RenameColumn(
                name: "mcUserId",
                table: "Users",
                newName: "McUserId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Items",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_userId",
                table: "Items",
                newName: "IX_Items_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "McUsername",
                table: "Users",
                newName: "mcUsername");

            migrationBuilder.RenameColumn(
                name: "McUserId",
                table: "Users",
                newName: "mcUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Items",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_UserId",
                table: "Items",
                newName: "IX_Items_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_userId",
                table: "Items",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
