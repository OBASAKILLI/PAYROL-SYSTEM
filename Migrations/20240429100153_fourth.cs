using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PAYROL_SYSTEM.Migrations
{
    public partial class fourth : Migration
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
                    strAllowanvcetypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_allowancePayment_Transactions", x => x.strId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "allowancePayment_Transactions");
        }
    }
}
