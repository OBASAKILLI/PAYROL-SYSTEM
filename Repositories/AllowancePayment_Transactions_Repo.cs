using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Repositories
{
    public class AllowancePayment_Transactions_Repo : GenericRepo<AllowancePayment_Transactions>, IAllowancePayment_Transactions
    {
        public AllowancePayment_Transactions_Repo(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
