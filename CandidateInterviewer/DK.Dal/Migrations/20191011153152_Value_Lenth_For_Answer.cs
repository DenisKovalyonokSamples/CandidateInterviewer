using Microsoft.EntityFrameworkCore.Migrations;

namespace DK.DataAccess.Migrations
{
    public partial class Value_Lenth_For_Answer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answer",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Answer",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
