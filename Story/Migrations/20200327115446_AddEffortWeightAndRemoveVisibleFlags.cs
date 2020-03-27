using Microsoft.EntityFrameworkCore.Migrations;

namespace Story.Migrations
{
    public partial class AddEffortWeightAndRemoveVisibleFlags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "EffortWeightId",
                table: "Story",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EffortWeight",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    Hint = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffortWeight", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Story_EffortWeightId",
                table: "Story",
                column: "EffortWeightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Story_EffortWeight_EffortWeightId",
                table: "Story",
                column: "EffortWeightId",
                principalTable: "EffortWeight",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Story_EffortWeight_EffortWeightId",
                table: "Story");

            migrationBuilder.DropTable(
                name: "EffortWeight");

            migrationBuilder.DropIndex(
                name: "IX_Story_EffortWeightId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "EffortWeightId",
                table: "Story");

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ValueWeight",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ValueType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ValueFrequency",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Story",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Status",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Group",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Comment",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
