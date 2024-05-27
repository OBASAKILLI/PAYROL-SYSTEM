using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<PAYROL_SYSTEM.Models.Users> Users { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.Employees> Employees { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.Departments> Departments { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.Designation_Role> designation_Roles { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.OverTime> OverTimes { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.Commission> Commissions { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.Allowances> Allowances { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.Job_Groups> Job_Groups { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.Allowance_Type> GetAllowance_Types { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.PaymentHistory> PaymentHistories { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.PayslipMonthlyInfo> payslipMonthlyInfos { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.AllowancePayment_Transactions> allowancePayment_Transactions { get; set; }
        public DbSet<PAYROL_SYSTEM.Models.DeductionSettings> deductionSettings { get; set; }
    }

}
