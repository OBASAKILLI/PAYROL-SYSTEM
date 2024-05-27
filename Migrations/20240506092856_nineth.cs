using Microsoft.EntityFrameworkCore.Migrations;

namespace PAYROL_SYSTEM.Migrations
{
    public partial class nineth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PAYE",
                table: "payslipMonthlyInfos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PAYE",
                table: "payslipMonthlyInfos");
        }
    }
}
