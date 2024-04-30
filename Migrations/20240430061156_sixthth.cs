using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PAYROL_SYSTEM.Migrations
{
    public partial class sixthth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "allowancePayment_Transactions",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strUserId = table.Column<string>(nullable: false),
                    strDate = table.Column<DateTime>(nullable: false),
                    strAmount = table.Column<double>(nullable: false),
                    strPaidStatus = table.Column<int>(nullable: false),
                    strAllowanvcetypeId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allowancePayment_Transactions", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "Allowances",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strUserId = table.Column<string>(nullable: false),
                    strAllowanceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowances", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "Commissions",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strUserId = table.Column<string>(nullable: false),
                    strDate = table.Column<DateTime>(nullable: false),
                    strAmount = table.Column<double>(nullable: false),
                    strPaidStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commissions", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strDepartmentId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "designation_Roles",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strDesignation_Role = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_designation_Roles", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strFullName = table.Column<string>(nullable: false),
                    strIdNo = table.Column<string>(nullable: false),
                    strNHIF_No = table.Column<string>(nullable: true),
                    strNSSF_NO = table.Column<string>(nullable: true),
                    strEmail = table.Column<string>(nullable: true),
                    strIdKRAPIN = table.Column<string>(nullable: false),
                    strDetartmentId = table.Column<string>(nullable: true),
                    strRole = table.Column<string>(nullable: false),
                    strPhoneNo = table.Column<string>(nullable: true),
                    strDate_Of_Join = table.Column<DateTime>(nullable: false),
                    strActive_Status = table.Column<int>(nullable: false),
                    strJobGroupId = table.Column<string>(nullable: false),
                    strGender = table.Column<int>(nullable: false),
                    strReligion = table.Column<string>(nullable: true),
                    strDateOfBirth = table.Column<DateTime>(nullable: false),
                    strMarital_Status = table.Column<int>(nullable: false),
                    strBank_Name = table.Column<string>(nullable: true),
                    strAccountNo = table.Column<string>(nullable: true),
                    strStaff_No = table.Column<string>(nullable: true),
                    strSacco_Deductyion = table.Column<double>(nullable: false),
                    strLoan = table.Column<double>(nullable: false),
                    strPenalties = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "GetAllowance_Types",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strAllowanceTypeName = table.Column<string>(nullable: false),
                    strSalary_Rate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetAllowance_Types", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "Job_Groups",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strGroupName = table.Column<string>(nullable: false),
                    strBasicSalary = table.Column<double>(nullable: false),
                    strNHIFDeduction = table.Column<double>(nullable: false),
                    strNSSFDeduction = table.Column<double>(nullable: false),
                    strHouseLevy = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Groups", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "OverTimes",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strUserId = table.Column<string>(nullable: false),
                    strDate = table.Column<DateTime>(nullable: false),
                    strAmount = table.Column<double>(nullable: false),
                    strPaidStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverTimes", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentHistories",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    struSERiD = table.Column<string>(nullable: true),
                    strToTal_Overtime = table.Column<double>(nullable: false),
                    strToTal_Commission = table.Column<double>(nullable: false),
                    strToTal_Allowances = table.Column<double>(nullable: false),
                    strNHIF = table.Column<double>(nullable: false),
                    strNSSF = table.Column<double>(nullable: false),
                    strhOUSElEVVY = table.Column<double>(nullable: false),
                    strSalary = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistories", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "payslipMonthlyInfos",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strUserId = table.Column<string>(nullable: false),
                    strBasicSalary = table.Column<double>(nullable: false),
                    strTotalAllowance = table.Column<double>(nullable: false),
                    strTotalCommission = table.Column<double>(nullable: false),
                    strTotalOvertime = table.Column<double>(nullable: false),
                    strNSSF = table.Column<double>(nullable: false),
                    strNHIF = table.Column<double>(nullable: false),
                    strHousingLevvy = table.Column<double>(nullable: false),
                    strMonthYear = table.Column<string>(nullable: false),
                    strIsPaidStatus = table.Column<bool>(nullable: false),
                    strSaccoDeduction = table.Column<double>(nullable: false),
                    strBankName = table.Column<string>(nullable: false),
                    stBankAccount = table.Column<string>(nullable: false),
                    strFullName = table.Column<string>(nullable: false),
                    strDesignation = table.Column<string>(nullable: false),
                    strJobGroup = table.Column<string>(nullable: false),
                    strDepartment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payslipMonthlyInfos", x => x.strId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strFullName = table.Column<string>(nullable: false),
                    strUsername = table.Column<string>(nullable: false),
                    strRole = table.Column<string>(nullable: false),
                    strPassword = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.strId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "allowancePayment_Transactions");

            migrationBuilder.DropTable(
                name: "Allowances");

            migrationBuilder.DropTable(
                name: "Commissions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "designation_Roles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "GetAllowance_Types");

            migrationBuilder.DropTable(
                name: "Job_Groups");

            migrationBuilder.DropTable(
                name: "OverTimes");

            migrationBuilder.DropTable(
                name: "PaymentHistories");

            migrationBuilder.DropTable(
                name: "payslipMonthlyInfos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
