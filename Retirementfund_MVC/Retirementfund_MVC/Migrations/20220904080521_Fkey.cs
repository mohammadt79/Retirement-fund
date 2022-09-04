using Microsoft.EntityFrameworkCore.Migrations;

namespace Retirementfund_MVC.Migrations
{
    public partial class Fkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Request",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserId",
                table: "Request",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Users_UserId",
                table: "Request",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_Users_UserId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_UserId",
                table: "Request");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
