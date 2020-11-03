using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_2__26047179.Data.Migrations
{
    public partial class EmployeeFullAddToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeCount",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnvironmentSatisfaction",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Overtime",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PerformanceRating",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StockOptionLevel",
                table: "Employee",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeCount",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EnvironmentSatisfaction",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Overtime",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PerformanceRating",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "StockOptionLevel",
                table: "Employee");
        }
    }
}
