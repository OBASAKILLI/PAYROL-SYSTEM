using Microsoft.EntityFrameworkCore.Migrations;

namespace PAYROL_SYSTEM.Migrations
{
    public partial class secondmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "strGender",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "strGender",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
