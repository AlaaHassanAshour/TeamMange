using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamManagment.Migrations
{
    public partial class hol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HolidayID",
                table: "WorkTimes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HolidayOrNot",
                table: "WorkTimes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<double>(
                name: "DayDifference",
                table: "HolidaySettings",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_HolidayID",
                table: "WorkTimes",
                column: "HolidayID");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_EmployeeHolidays_HolidayID",
                table: "WorkTimes",
                column: "HolidayID",
                principalTable: "EmployeeHolidays",
                principalColumn: "HolidayID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_EmployeeHolidays_HolidayID",
                table: "WorkTimes");

            migrationBuilder.DropIndex(
                name: "IX_WorkTimes_HolidayID",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "HolidayID",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "HolidayOrNot",
                table: "WorkTimes");

            migrationBuilder.AlterColumn<string>(
                name: "DayDifference",
                table: "HolidaySettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
