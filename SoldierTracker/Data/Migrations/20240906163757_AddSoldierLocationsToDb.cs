using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoldierTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddSoldierLocationsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoldierLocations",
                columns: table => new
                {
                    SensorID = table.Column<int>(type: "int", nullable: false),
                    SoldierID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldierLocations", x => new { x.SensorID, x.SoldierID });
                    table.ForeignKey(
                        name: "FK_SoldierLocation_Sensor",
                        column: x => x.SensorID,
                        principalTable: "Sensors",
                        principalColumn: "SensorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoldierLocations_Soldier",
                        column: x => x.SoldierID,
                        principalTable: "Soldiers",
                        principalColumn: "SoldierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoldierLocations_SoldierID",
                table: "SoldierLocations",
                column: "SoldierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoldierLocations");
        }
    }
}
