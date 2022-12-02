using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class clearAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friend");

            migrationBuilder.DropColumn(
                name: "OtherNumberOfFriends",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "NumberOfFriends",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "WordInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "WordInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WordInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfFriends",
                table: "WordInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Password",
                table: "WordInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OtherNumberOfFriends",
                table: "WordInfos",
                type: "int",
                nullable: false,
                computedColumnSql: "123");

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
    }
}
