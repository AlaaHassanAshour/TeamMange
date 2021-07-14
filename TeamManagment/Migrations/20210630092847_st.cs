using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamManagment.Migrations
{
    public partial class st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "States",
                table: "WorkTimes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "States",
                table: "WorkTimes");
        }
    }
}
