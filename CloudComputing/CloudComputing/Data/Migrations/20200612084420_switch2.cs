using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudComputing.Data.Migrations
{
    public partial class switch2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "switch",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    virtualswitch = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_switch", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "switch");
        }
    }
}
