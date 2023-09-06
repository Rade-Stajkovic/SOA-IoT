using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrpcService.Migrations
{
    public partial class V100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "AirPiValues");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "AirPiValues",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
