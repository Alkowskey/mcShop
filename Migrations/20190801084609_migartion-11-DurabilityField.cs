using Microsoft.EntityFrameworkCore.Migrations;

namespace mcShopServer.Migrations
{
    public partial class migartion11DurabilityField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Durablity",
                table: "Items",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durablity",
                table: "Items");
        }
    }
}
