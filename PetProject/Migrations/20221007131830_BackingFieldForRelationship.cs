using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class BackingFieldForRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceOfWork",
                table: "WordInfos");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "WordInfos",
                newName: "NumberOfFriends");

            migrationBuilder.CreateTable(
                name: "Friend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WordInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friend_WordInfos_WordInfoId",
                        column: x => x.WordInfoId,
                        principalTable: "WordInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friend_WordInfoId",
                table: "Friend",
                column: "WordInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friend");

            migrationBuilder.RenameColumn(
                name: "NumberOfFriends",
                table: "WordInfos",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfWork",
                table: "WordInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
