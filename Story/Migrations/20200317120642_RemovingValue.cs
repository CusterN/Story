using Microsoft.EntityFrameworkCore.Migrations;

namespace Story.Migrations
{
    public partial class RemovingValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Story");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Value",
                table: "Story",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
