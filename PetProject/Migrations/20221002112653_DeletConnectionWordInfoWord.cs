using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class DeletConnectionWordInfoWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WordInfos_Words_WordId",
                table: "WordInfos");

            migrationBuilder.DropIndex(
                name: "IX_WordInfos_WordId",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "WordInfoId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "WordId",
                table: "WordInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WordInfoId",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WordId",
                table: "WordInfos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_WordInfos_WordId",
                table: "WordInfos",
                column: "WordId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WordInfos_Words_WordId",
                table: "WordInfos",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "WordText",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
