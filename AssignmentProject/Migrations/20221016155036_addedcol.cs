using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentProject.Migrations
{
    public partial class addedcol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "EventAdd",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EventAdd",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalInvites",
                table: "EventAdd",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "EventAdd");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EventAdd");

            migrationBuilder.DropColumn(
                name: "TotalInvites",
                table: "EventAdd");
        }
    }
}
