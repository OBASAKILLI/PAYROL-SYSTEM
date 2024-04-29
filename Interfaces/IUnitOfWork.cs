using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Interfaces
{
 public   interface IUnitOfWork:IDisposable
    {
        IAllowancesRepo allowancesRepo { get; }
        IAllowanceTypeRepo allowanceTypeRepo { get; }
        Icommissionrepo Icommissionrepo { get; }
        Idesignation_RoleRepo Idesignation_RoleRepo { get; }
        IDepartmentRepo departmentRepo { get; }
        IEmployeeRepo employeeRepo { get; }
        IJobGroupRepo jobGroupRepo { get; }
        IOverTimeRepo overTimeRepo { get; }
        IpaymentRepo IpaymentRepo { get; }
        IUserRepo userRepo { get; }
        IAllowancePayment_Transactions allowancePayment_Transactions { get; }
        int save();

    }
}
