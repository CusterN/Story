using Microsoft.EntityFrameworkCore.Migrations;

namespace Story.Migrations
{
    public partial class AddingVisibleFlags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ValueWeight",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ValueType",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ValueFrequency",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Story",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Status",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Group",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Comment",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ValueWeight");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ValueType");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ValueFrequency");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Comment");
        }
    }
}
