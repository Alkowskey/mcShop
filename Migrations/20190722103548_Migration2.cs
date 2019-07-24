using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "userId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.CreateIndex(
                name: "IX_Items_userId",
                table: "Items",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_userId",
                table: "Items",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_userId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_userId",
                table: "Items");

            migrationBuilder.AlterColumn<long>(
                name: "userId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);
        }
    }
}
