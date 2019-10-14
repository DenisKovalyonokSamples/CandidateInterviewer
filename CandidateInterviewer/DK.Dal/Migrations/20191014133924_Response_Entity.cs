using Microsoft.EntityFrameworkCore.Migrations;

namespace DK.DataAccess.Migrations
{
    public partial class Response_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "response_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    InterviewId = table.Column<int>(nullable: false),
                    AnswerId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Response_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Response_Interview_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Response_AnswerId",
                table: "Response",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Response_InterviewId",
                table: "Response",
                column: "InterviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropSequence(
                name: "response_hilo");
        }
    }
}
