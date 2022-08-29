using Microsoft.EntityFrameworkCore.Migrations;

namespace Retirementfund_MVC.Migrations
{
    public partial class fixTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TheConferenceModel",
                table: "TheConferenceModel");

            migrationBuilder.RenameTable(
                name: "TheConferenceModel",
                newName: "TheConference");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheConference",
                table: "TheConference",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TheConference",
                table: "TheConference");

            migrationBuilder.RenameTable(
                name: "TheConference",
                newName: "TheConferenceModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TheConferenceModel",
                table: "TheConferenceModel",
                column: "Id");
        }
    }
}
