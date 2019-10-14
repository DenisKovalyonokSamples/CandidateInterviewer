using Microsoft.EntityFrameworkCore.Migrations;

namespace DK.DataAccess.Migrations
{
    public partial class Type_Update_For_Response : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Response");

            migrationBuilder.AddColumn<int>(
                name: "ApprovalType",
                table: "Response",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalType",
                table: "Response");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Response",
                nullable: false,
                defaultValue: 0);
        }
    }
}
