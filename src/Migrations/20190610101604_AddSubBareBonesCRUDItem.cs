using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BareBonesCRUDMicroservice.Migrations
{
    public partial class AddSubBareBonesCRUDItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubBareBonesCRUDItems",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    BareBonesCRUDItem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubBareBonesCRUDItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubBareBonesCRUDItems");
        }
    }
}
