using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyHomies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    quality = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    checkOutTime = table.Column<DateTime>(nullable: false),
                    CheckedOut = table.Column<bool>(nullable: false),
                    maxTimeOut = table.Column<int>(nullable: false),
                    condition = table.Column<string>(nullable: true),
                    lateFee = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
