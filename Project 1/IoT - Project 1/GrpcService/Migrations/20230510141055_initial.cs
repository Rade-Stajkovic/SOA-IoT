using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrpcService.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirPiValues",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    LightLevel = table.Column<double>(type: "float", nullable: false),
                    TemperatureDHT = table.Column<double>(type: "float", nullable: false),
                    Pressure = table.Column<double>(type: "float", nullable: false),
                    TemperatureBMP = table.Column<double>(type: "float", nullable: false),
                    RelativeHumidity = table.Column<double>(type: "float", nullable: false),
                    AirQuality = table.Column<double>(type: "float", nullable: false),
                    CarbonMonoxide = table.Column<double>(type: "float", nullable: false),
                    NitrogenDioxide = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirPiValues", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirPiValues");
        }
    }
}
