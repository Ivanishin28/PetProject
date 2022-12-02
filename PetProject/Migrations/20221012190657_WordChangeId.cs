using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class WordChangeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranslationWord_Words_WordsWordText",
                table: "TranslationWord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Words",
                table: "Words");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TranslationWord",
                table: "TranslationWord");

            migrationBuilder.DropIndex(
                name: "IX_TranslationWord_WordsWordText",
                table: "TranslationWord");

            migrationBuilder.DropColumn(
                name: "WordsWordText",
                table: "TranslationWord");

            migrationBuilder.AlterColumn<string>(
                name: "WordText",
                table: "Words",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "WordId",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "WordsWordId",
                table: "TranslationWord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Words",
                table: "Words",
                column: "WordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TranslationWord",
                table: "TranslationWord",
                columns: new[] { "TranslationsTranslationText", "WordsWordId" });

            migrationBuilder.CreateIndex(
                name: "IX_TranslationWord_WordsWordId",
                table: "TranslationWord",
                column: "WordsWordId");

            migrationBuilder.AddForeignKey(
                name: "FK_TranslationWord_Words_WordsWordId",
                table: "TranslationWord",
                column: "WordsWordId",
                principalTable: "Words",
                principalColumn: "WordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranslationWord_Words_WordsWordId",
                table: "TranslationWord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Words",
                table: "Words");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TranslationWord",
                table: "TranslationWord");

            migrationBuilder.DropIndex(
                name: "IX_TranslationWord_WordsWordId",
                table: "TranslationWord");

            migrationBuilder.DropColumn(
                name: "WordId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "WordsWordId",
                table: "TranslationWord");

            migrationBuilder.AlterColumn<string>(
                name: "WordText",
                table: "Words",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "WordsWordText",
                table: "TranslationWord",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Words",
                table: "Words",
                column: "WordText");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TranslationWord",
                table: "TranslationWord",
                columns: new[] { "TranslationsTranslationText", "WordsWordText" });

            migrationBuilder.CreateIndex(
                name: "IX_TranslationWord_WordsWordText",
                table: "TranslationWord",
                column: "WordsWordText");

            migrationBuilder.AddForeignKey(
                name: "FK_TranslationWord_Words_WordsWordText",
                table: "TranslationWord",
                column: "WordsWordText",
                principalTable: "Words",
                principalColumn: "WordText",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
