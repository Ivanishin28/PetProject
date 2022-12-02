using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class DelClones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LangaugeName",
                table: "Themes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
