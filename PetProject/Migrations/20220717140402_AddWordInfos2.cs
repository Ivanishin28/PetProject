using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class AddWordInfos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WordInfos_WordId",
                table: "WordInfos");

            migrationBuilder.AddColumn<int>(
                name: "WordInfoId",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WordInfos_WordId",
                table: "WordInfos",
                column: "WordId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WordInfos_WordId",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "WordInfoId",
                table: "Words");

            migrationBuilder.CreateIndex(
                name: "IX_WordInfos_WordId",
                table: "WordInfos",
                column: "WordId");
        }
    }
}
