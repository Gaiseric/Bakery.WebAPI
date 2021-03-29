using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.WebAPI.Data.Migrations
{
    public partial class OrderStatusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderStatus",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "New"
            );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");
        }
    }
}
