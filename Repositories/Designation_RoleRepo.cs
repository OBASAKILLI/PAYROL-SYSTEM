using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Repositories
{
    public class Designation_RoleRepo : GenericRepo<Designation_Role>,Idesignation_RoleRepo
    {
        public Designation_RoleRepo(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
