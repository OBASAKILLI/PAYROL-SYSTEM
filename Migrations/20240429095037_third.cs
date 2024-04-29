using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PAYROL_SYSTEM.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "strAmount",
                table: "Allowances");

            migrationBuilder.DropColumn(
                name: "strDate",
                table: "Allowances");

            migrationBuilder.DropColumn(
                name: "strPaidStatus",
                table: "Allowances");

            migrationBuilder.AlterColumn<int>(
                name: "strPaidStatus",
                table: "OverTimes",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<double>(
                name: "strSalary_Rate",
                table: "GetAllowance_Types",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "strMarital_Status",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "strActive_Status",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "strPaidStatus",
                table: "Commissions",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "strSalary_Rate",
                table: "GetAllowance_Types");

            migrationBuilder.AlterColumn<bool>(
                name: "strPaidStatus",
                table: "OverTimes",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "strMarital_Status",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "strActive_Status",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "strPaidStatus",
                table: "Commissions",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<double>(
                name: "strAmount",
                table: "Allowances",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "strDate",
                table: "Allowances",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "strPaidStatus",
                table: "Allowances",
                nullable: false,
                defaultValue: false);
        }
    }
}
