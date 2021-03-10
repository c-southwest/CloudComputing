using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudComputing.Data.Migrations
{
    public partial class switchname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "switchname",
                table: "server",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "switchname",
                table: "server");
        }
    }
}
