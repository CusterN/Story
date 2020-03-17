using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Story.Migrations
{
    public partial class changedstorysubmittertocreator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Submitter",
                table: "Story");

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "Story",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Story",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creator",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Story");

            migrationBuilder.AddColumn<string>(
                name: "Submitter",
                table: "Story",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
