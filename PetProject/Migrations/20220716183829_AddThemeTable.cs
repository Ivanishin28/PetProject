using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class AddThemeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThemeId",
                table: "Words",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Words_ThemeId",
                table: "Words",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Themes_ThemeId",
                table: "Words",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "ThemeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_Themes_ThemeId",
                table: "Words");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropIndex(
                name: "IX_Words_ThemeId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "Words");
        }
    }
}
