using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class Migrate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
