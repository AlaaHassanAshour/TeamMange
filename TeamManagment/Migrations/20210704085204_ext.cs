using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamManagment.Migrations
{
    public partial class ext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExiteID",
                table: "WorkTimes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_ExiteID",
                table: "WorkTimes",
                column: "ExiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_ExitePrmissions_ExiteID",
                table: "WorkTimes",
                column: "ExiteID",
                principalTable: "ExitePrmissions",
                principalColumn: "ExitID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_ExitePrmissions_ExiteID",
                table: "WorkTimes");

            migrationBuilder.DropIndex(
                name: "IX_WorkTimes_ExiteID",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "ExiteID",
                table: "WorkTimes");
        }
    }
}
