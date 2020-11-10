using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_2__26047179.Data.Migrations
{
    public partial class RevertToOneTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobInfo");

            migrationBuilder.DropTable(
                name: "JobSpecs");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.RenameColumn(
                name: "Overtime",
                table: "Employee",
                newName: "OverTime");

            migrationBuilder.AlterColumn<string>(
                name: "OverTime",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeNumber",
                table: "Employee",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Attrition",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessTravel",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DailyRate",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistanceFromHome",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Education",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EducationField",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HourlyRate",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobInvolvement",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobLevel",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobSatisfaction",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthlyIncome",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonthlyRate",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumCompaniesWorked",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Over18",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PercentSalaryHike",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RelationshipSatisfaction",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StandardHours",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalWorkingYears",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingTimesLastYear",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkLifeBalance",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsAtCompany",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsInCurrentRole",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsSinceLastPromotion",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsWithCurrManager",
                table: "Employee",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Attrition",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "BusinessTravel",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DailyRate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DistanceFromHome",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EducationField",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HourlyRate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobInvolvement",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobLevel",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobSatisfaction",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MonthlyIncome",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MonthlyRate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "NumCompaniesWorked",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Over18",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PercentSalaryHike",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RelationshipSatisfaction",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "StandardHours",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TotalWorkingYears",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TrainingTimesLastYear",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "WorkLifeBalance",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "YearsAtCompany",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "YearsInCurrentRole",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "YearsSinceLastPromotion",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "YearsWithCurrManager",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "OverTime",
                table: "Employee",
                newName: "Overtime");

            migrationBuilder.AlterColumn<string>(
                name: "Overtime",
                table: "Employee",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeNumber",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "JobInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationField = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    NumCompaniesWorked = table.Column<int>(type: "int", nullable: false),
                    TotalWorkingYears = table.Column<int>(type: "int", nullable: false),
                    TrainingTimesLastYear = table.Column<int>(type: "int", nullable: false),
                    WorkLifeBalance = table.Column<int>(type: "int", nullable: false),
                    YearsAtCompany = table.Column<int>(type: "int", nullable: false),
                    YearsInCurrentRole = table.Column<int>(type: "int", nullable: false),
                    YearsWithCurrManager = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobInfo_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    HourlyRate = table.Column<int>(type: "int", nullable: false),
                    JobInvolvement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLevel = table.Column<int>(type: "int", nullable: false),
                    JobRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobSatisfaction = table.Column<int>(type: "int", nullable: false),
                    MonthlyIncome = table.Column<int>(type: "int", nullable: false),
                    MonthylyRate = table.Column<int>(type: "int", nullable: false),
                    PercentSalaryHike = table.Column<int>(type: "int", nullable: false),
                    StandardHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSpecs_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Attrition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinesssTravel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DailyRate = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    MaritialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Over18 = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    RelationshipSatisfaction = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personal_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobInfo_EmployeeId",
                table: "JobInfo",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSpecs_EmployeeId",
                table: "JobSpecs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_EmployeeId",
                table: "Personal",
                column: "EmployeeId");
        }
    }
}
