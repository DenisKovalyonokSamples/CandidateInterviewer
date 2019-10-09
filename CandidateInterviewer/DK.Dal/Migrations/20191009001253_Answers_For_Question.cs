using Microsoft.EntityFrameworkCore.Migrations;

namespace DK.DataAccess.Migrations
{
    public partial class Answers_For_Question : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "answer_hilo",
                incrementBy: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Question",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 180,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Question",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false),
                    Value = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropSequence(
                name: "answer_hilo");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Question");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Question",
                maxLength: 180,
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
