using Microsoft.EntityFrameworkCore.Migrations;

namespace PAYROL_SYSTEM.Migrations
{
    public partial class senebthh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "strBasicSalary",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "strBasicSalary",
                table: "Employees");
        }
    }
}
