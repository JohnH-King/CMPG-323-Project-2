using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_2__26047179.Data.Migrations
{
    public partial class AddWholeDbImpl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Attrition",
                table: "Personal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BusinesssTravel",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DailyRate",
                table: "Personal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Personal",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaritialStatus",
                table: "Personal",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Over18",
                table: "Personal",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RelationshipSatisfaction",
                table: "Personal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HourlyRate",
                table: "JobSpecs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JobInvolvement",
                table: "JobSpecs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobLevel",
                table: "JobSpecs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobSatisfaction",
                table: "JobSpecs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyIncome",
                table: "JobSpecs",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthylyRate",
                table: "JobSpecs",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PercentSalaryHike",
                table: "JobSpecs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StandardHours",
                table: "JobSpecs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "JobInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumCompaniesWorked",
                table: "JobInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalWorkingYears",
                table: "JobInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingTimesLastYear",
                table: "JobInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkLifeBalance",
                table: "JobInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsAtCompany",
                table: "JobInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsInCurrentRole",
                table: "JobInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsWithCurrManager",
                table: "JobInfo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attrition",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "BusinesssTravel",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "DailyRate",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "MaritialStatus",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "Over18",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "RelationshipSatisfaction",
                table: "Personal");

            migrationBuilder.DropColumn(
                name: "HourlyRate",
                table: "JobSpecs");

            migrationBuilder.DropColumn(
                name: "JobInvolvement",
                table: "JobSpecs");

            migrationBuilder.DropColumn(
                name: "JobLevel",
                table: "JobSpecs");

            migrationBuilder.DropColumn(
                name: "JobSatisfaction",
                table: "JobSpecs");

            migrationBuilder.DropColumn(
                name: "MonthlyIncome",
                table: "JobSpecs");

            migrationBuilder.DropColumn(
                name: "MonthylyRate",
                table: "JobSpecs");

            migrationBuilder.DropColumn(
                name: "PercentSalaryHike",
                table: "JobSpecs");

            migrationBuilder.DropColumn(
                name: "StandardHours",
                table: "JobSpecs");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "JobInfo");

            migrationBuilder.DropColumn(
                name: "NumCompaniesWorked",
                table: "JobInfo");

            migrationBuilder.DropColumn(
                name: "TotalWorkingYears",
                table: "JobInfo");

            migrationBuilder.DropColumn(
                name: "TrainingTimesLastYear",
                table: "JobInfo");

            migrationBuilder.DropColumn(
                name: "WorkLifeBalance",
                table: "JobInfo");

            migrationBuilder.DropColumn(
                name: "YearsAtCompany",
                table: "JobInfo");

            migrationBuilder.DropColumn(
                name: "YearsInCurrentRole",
                table: "JobInfo");

            migrationBuilder.DropColumn(
                name: "YearsWithCurrManager",
                table: "JobInfo");
        }
    }
}
