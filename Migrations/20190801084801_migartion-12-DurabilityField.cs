using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class migartion12DurabilityField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Durablity",
                table: "Items",
                newName: "ItemDurability");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemDurability",
                table: "Items",
                newName: "Durablity");
        }
    }
}
