using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_2__26047179.Data.Migrations
{
    public partial class ChnagePKofJobInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalWorkingYears",
                table: "JobInfo");

            migrationBuilder.AddColumn<string>(
                name: "EducationField",
                table: "JobInfo",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationField",
                table: "JobInfo");

            migrationBuilder.AddColumn<int>(
                name: "TotalWorkingYears",
                table: "JobInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
