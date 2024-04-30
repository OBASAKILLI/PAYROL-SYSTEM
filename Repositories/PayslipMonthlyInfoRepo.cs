using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Repositories
{
    public class PayslipMonthlyInfoRepo : GenericRepo<PayslipMonthlyInfo>, IPayslipInfo
    {
        public PayslipMonthlyInfoRepo(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<PayslipMonthlyInfo> GetMonthlyUserPaySlip(string UserId, string MonthYear)
        {
            PayslipMonthlyInfo p = _appDbContext.payslipMonthlyInfos.FirstOrDefault(k => k.strUserId == UserId && k.strMonthYear == MonthYear);
            return p;
        }
    }
}
