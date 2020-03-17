using Microsoft.EntityFrameworkCore.Migrations;

namespace Story.Migrations
{
    public partial class AddValueWeightAndHints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hint",
                table: "ValueType",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hint",
                table: "ValueFrequency",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ValueWeightId",
                table: "Story",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Hint",
                table: "Status",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hint",
                table: "Group",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ValueWeight",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    Hint = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueWeight", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Story_ValueWeightId",
                table: "Story",
                column: "ValueWeightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Story_ValueWeight_ValueWeightId",
                table: "Story",
                column: "ValueWeightId",
                principalTable: "ValueWeight",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Story_ValueWeight_ValueWeightId",
                table: "Story");

            migrationBuilder.DropTable(
                name: "ValueWeight");

            migrationBuilder.DropIndex(
                name: "IX_Story_ValueWeightId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "Hint",
                table: "ValueType");

            migrationBuilder.DropColumn(
                name: "Hint",
                table: "ValueFrequency");

            migrationBuilder.DropColumn(
                name: "ValueWeightId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "Hint",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "Hint",
                table: "Group");
        }
    }
}
