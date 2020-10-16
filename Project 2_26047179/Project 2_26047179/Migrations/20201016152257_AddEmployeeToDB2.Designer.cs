﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_2_26047179.Model;

namespace Project_2_26047179.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201016152257_AddEmployeeToDB2")]
    partial class AddEmployeeToDB2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project_2_26047179.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Attrition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessTravel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DailyRate")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistanceFromHome")
                        .HasColumnType("int");

                    b.Property<int>("Education")
                        .HasColumnType("int");

                    b.Property<string>("EducationField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeNumber")
                        .HasColumnType("int");

                    b.Property<int>("EnvironmentSatisfaction")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HourlyRate")
                        .HasColumnType("int");

                    b.Property<int>("JobInvolvement")
                        .HasColumnType("int");

                    b.Property<int>("JobLevel")
                        .HasColumnType("int");

                    b.Property<string>("JobRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobSatisfaction")
                        .HasColumnType("int");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthlyIncome")
                        .HasColumnType("int");

                    b.Property<int>("MonthlyRate")
                        .HasColumnType("int");

                    b.Property<int>("NumCompaniesWorked")
                        .HasColumnType("int");

                    b.Property<string>("Over18")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("OverTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PercentSalaryHike")
                        .HasColumnType("int");

                    b.Property<int>("PerformanceRating")
                        .HasColumnType("int");

                    b.Property<int>("RelationshipSatisfaction")
                        .HasColumnType("int");

                    b.Property<int>("StandardHours")
                        .HasColumnType("int");

                    b.Property<int>("StockOptionLevel")
                        .HasColumnType("int");

                    b.Property<int>("TotalWorkingYears")
                        .HasColumnType("int");

                    b.Property<int>("TrainingTimesLastYear")
                        .HasColumnType("int");

                    b.Property<int>("WorkLifeBalance")
                        .HasColumnType("int");

                    b.Property<int>("YearsAtCompany")
                        .HasColumnType("int");

                    b.Property<int>("YearsInCurrentRole")
                        .HasColumnType("int");

                    b.Property<int>("YearsSinceLastPromotion")
                        .HasColumnType("int");

                    b.Property<int>("YearsWithCurrManager")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
