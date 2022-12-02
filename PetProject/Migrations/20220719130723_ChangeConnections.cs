using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class ChangeConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LangaugeId",
                table: "Themes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LanguageName",
                table: "Themes",
                type: "nvarchar(450)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Themes_LanguageName",
                table: "Themes",
                column: "LanguageName");

            migrationBuilder.AddForeignKey(
                name: "FK_Themes_Languages_LanguageName",
                table: "Themes",
                column: "LanguageName",
                principalTable: "Languages",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Themes_Languages_LanguageName",
                table: "Themes");

            migrationBuilder.DropIndex(
                name: "IX_Themes_LanguageName",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "LangaugeId",
                table: "Themes");

            migrationBuilder.DropColumn(
                name: "LanguageName",
                table: "Themes");
        }
    }
}
