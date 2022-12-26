using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElevenNote.Data.Migrations
{
    /// <inheritdoc />
    public partial class TbInitColumnsCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatetoryId",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CatetoryId",
                table: "Notes",
                column: "CatetoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Categories_CatetoryId",
                table: "Notes",
                column: "CatetoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Categories_CatetoryId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_CatetoryId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "CatetoryId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Categories");
        }
    }
}
