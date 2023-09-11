using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentProject.Migrations
{
    public partial class addedevent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventAdd",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    OtherDetails = table.Column<string>(maxLength: 500, nullable: true),
                    InviteByEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAdd", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventAdd");
        }
    }
}
