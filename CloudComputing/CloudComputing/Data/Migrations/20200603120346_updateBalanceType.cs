using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudComputing.Data.Migrations
{
    public partial class updateBalanceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "amount",
                table: "balance",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "amount",
                table: "balance",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
