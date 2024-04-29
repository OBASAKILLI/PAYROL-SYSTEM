using Microsoft.EntityFrameworkCore.Migrations;

namespace PAYROL_SYSTEM.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "strAllowanvcetypeId",
                table: "allowancePayment_Transactions",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "strAllowanvcetypeId",
                table: "allowancePayment_Transactions",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
