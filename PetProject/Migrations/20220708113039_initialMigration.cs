using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    TranslationText = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.TranslationText);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    WordText = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.WordText);
                    table.ForeignKey(
                        name: "FK_Words_Languages_LanguageName",
                        column: x => x.LanguageName,
                        principalTable: "Languages",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslationWord",
                columns: table => new
                {
                    TranslationsTranslationText = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WordsWordText = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslationWord", x => new { x.TranslationsTranslationText, x.WordsWordText });
                    table.ForeignKey(
                        name: "FK_TranslationWord_Translations_TranslationsTranslationText",
                        column: x => x.TranslationsTranslationText,
                        principalTable: "Translations",
                        principalColumn: "TranslationText",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TranslationWord_Words_WordsWordText",
                        column: x => x.WordsWordText,
                        principalTable: "Words",
                        principalColumn: "WordText",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TranslationWord_WordsWordText",
                table: "TranslationWord",
                column: "WordsWordText");

            migrationBuilder.CreateIndex(
                name: "IX_Words_LanguageName",
                table: "Words",
                column: "LanguageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranslationWord");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}