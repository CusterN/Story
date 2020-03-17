using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Story.Migrations
{
    public partial class changestoryenterdatetocreatedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnterDate",
                table: "Story");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Story",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Story");

            migrationBuilder.AddColumn<DateTime>(
                name: "EnterDate",
                table: "Story",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
