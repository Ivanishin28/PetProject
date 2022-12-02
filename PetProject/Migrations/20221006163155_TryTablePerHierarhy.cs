using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class TryTablePerHierarhy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1_Street",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "WordInfos");

            migrationBuilder.RenameColumn(
                name: "Info",
                table: "WordInfos",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "WordInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfWork",
                table: "WordInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "WordInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "PlaceOfWork",
                table: "WordInfos");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "WordInfos");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WordInfos",
                newName: "Info");

            migrationBuilder.AddColumn<string>(
                name: "Address1_Street",
                table: "WordInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "WordInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
