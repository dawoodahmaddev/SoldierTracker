using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoldierTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddRankAsForeignInSoldier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RankId",
                table: "Soldiers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Soldiers_RankId",
                table: "Soldiers",
                column: "RankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Soldiers_Ranks_RankId",
                table: "Soldiers",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "RankId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Soldiers_Ranks_RankId",
                table: "Soldiers");

            migrationBuilder.DropIndex(
                name: "IX_Soldiers_RankId",
                table: "Soldiers");

            migrationBuilder.DropColumn(
                name: "RankId",
                table: "Soldiers");
        }
    }
}
