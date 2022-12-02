using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class ChangeThemeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_Themes_Languages_LanguageName",
                table: "Themes");
            /*migrationBuilder.AlterColumn<string>(
                name: "LanguageName",
                table: "Themes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");*/

            migrationBuilder.DropIndex(
                name: "IX_Themes_LanguageName",
                table: "Themes");

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

            migrationBuilder.AlterColumn<string>(
                name: "LanguageName",
                table: "Themes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Themes_Languages_ThemeName",
                table: "Themes",
                column: "ThemeName",
                principalTable: "Languages",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
