using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Repositories
{
    public class OverTimeRepo : GenericRepo<OverTime>,IOverTimeRepo
    {
        public OverTimeRepo(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
