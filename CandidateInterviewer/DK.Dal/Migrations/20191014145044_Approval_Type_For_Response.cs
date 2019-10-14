using Microsoft.EntityFrameworkCore.Migrations;

namespace DK.DataAccess.Migrations
{
    public partial class Approval_Type_For_Response : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Response_Answer_AnswerId",
                table: "Response");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "Response",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Response_AnswerId",
                table: "Response",
                newName: "IX_Response_QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Response_Question_QuestionId",
                table: "Response",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Response_Question_QuestionId",
                table: "Response");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Response",
                newName: "AnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Response_QuestionId",
                table: "Response",
                newName: "IX_Response_AnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Response_Answer_AnswerId",
                table: "Response",
                column: "AnswerId",
                principalTable: "Answer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
