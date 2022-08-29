using Microsoft.EntityFrameworkCore.Migrations;

namespace Retirementfund_MVC.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FundModel",
                table: "FundModel");

            migrationBuilder.RenameTable(
                name: "FundModel",
                newName: "Fund");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fund",
                table: "Fund",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fund",
                table: "Fund");

            migrationBuilder.RenameTable(
                name: "Fund",
                newName: "FundModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundModel",
                table: "FundModel",
                column: "Id");
        }
    }
}
