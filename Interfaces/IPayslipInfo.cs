using PAYROL_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Interfaces
{
    public interface IPayslipInfo : IGenericRepository<PayslipMonthlyInfo>
    {
        Task<PayslipMonthlyInfo> GetMonthlyUserPaySlip(string UserId, string MonthYear);
    }
}
