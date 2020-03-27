using Microsoft.EntityFrameworkCore.Migrations;

namespace Story.Migrations
{
    public partial class AddWeightToValueAndEffort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "ValueWeight",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "EffortWeight",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "ValueWeight");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "EffortWeight");
        }
    }
}
