using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoldierTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryAsForeignInSoldier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Soldiers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Soldiers_CountryId",
                table: "Soldiers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Soldiers_Countries_CountryId",
                table: "Soldiers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Soldiers_Countries_CountryId",
                table: "Soldiers");

            migrationBuilder.DropIndex(
                name: "IX_Soldiers_CountryId",
                table: "Soldiers");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Soldiers");
        }
    }
}
