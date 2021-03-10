using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudComputing.Data.Migrations
{
    public partial class servertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "server",
                columns: table => new
                {
                    serverid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    servername = table.Column<string>(nullable: true),
                    os = table.Column<string>(nullable: true),
                    ip = table.Column<string>(nullable: true),
                    cpu = table.Column<int>(nullable: false),
                    memory = table.Column<float>(nullable: false),
                    disk = table.Column<int>(nullable: false),
                    expire = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_server", x => x.serverid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "server");
        }
    }
}
