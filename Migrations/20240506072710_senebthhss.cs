using Microsoft.EntityFrameworkCore.Migrations;

namespace PAYROL_SYSTEM.Migrations
{
    public partial class senebthhss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "strJobGroup",
                table: "payslipMonthlyInfos");

            migrationBuilder.DropColumn(
                name: "strJobGroupId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "deductionSettings",
                columns: table => new
                {
                    strId = table.Column<string>(maxLength: 50, nullable: false),
                    strNHIFDeduction = table.Column<double>(nullable: false),
                    strNSSFDeduction = table.Column<double>(nullable: false),
                    strHouseLevy = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deductionSettings", x => x.strId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "deductionSettings");

            migrationBuilder.AddColumn<string>(
                name: "strJobGroup",
                table: "payslipMonthlyInfos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "strJobGroupId",
                table: "Employees",
                nullable: false,
                defaultValue: "");
        }
    }
}
