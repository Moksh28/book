using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentProject.Migrations
{
    public partial class addedchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "EventAdd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "EventAdd",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
