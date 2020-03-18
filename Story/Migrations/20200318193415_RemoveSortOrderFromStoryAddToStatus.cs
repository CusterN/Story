using Microsoft.EntityFrameworkCore.Migrations;

namespace Story.Migrations
{
    public partial class RemoveSortOrderFromStoryAddToStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Story");

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Status",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Status");

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Story",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
