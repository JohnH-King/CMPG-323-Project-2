using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_2__26047179.Data.Migrations
{
    public partial class ChangeToJobRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeNumber",
                table: "JobSpecs");

            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "JobSpecs",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "JobSpecs");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeNumber",
                table: "JobSpecs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
