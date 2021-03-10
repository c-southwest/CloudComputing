using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudComputing.Data.Migrations
{
    public partial class bandwidth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bandwidth",
                table: "server",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bandwidth",
                table: "server");
        }
    }
}
