using PAYROL_SYSTEM.Context;
using PAYROL_SYSTEM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {


            _appDbContext = appDbContext;
            userRepo = new UserRepo(_appDbContext);
            IpaymentRepo = new PaymentRepo(_appDbContext);
            overTimeRepo = new OverTimeRepo(_appDbContext);
            jobGroupRepo = new JobGroupRepo(_appDbContext);
            employeeRepo = new EmployeeRepo(_appDbContext);
            departmentRepo = new DepartmentRepo(_appDbContext);
            Idesignation_RoleRepo = new Designation_RoleRepo(_appDbContext);
            Icommissionrepo = new CommissionRepo(_appDbContext);
            allowanceTypeRepo = new AllowanceTypeRepo(_appDbContext);
            allowancesRepo = new AllowanceRepo(_appDbContext);
            allowancePayment_Transactions = new AllowancePayment_Transactions_Repo(_appDbContext);
            payslipInfo = new PayslipMonthlyInfoRepo(_appDbContext);
            deductionsRepository = new DeductionsSettingsRepository(_appDbContext);

        }
        public IAllowancesRepo allowancesRepo { get; private set; }

        public IAllowanceTypeRepo allowanceTypeRepo { get; private set; }

        public Icommissionrepo Icommissionrepo { get; private set; }

        public Idesignation_RoleRepo Idesignation_RoleRepo { get; private set; }

        public IDepartmentRepo departmentRepo { get; private set; }

        public IEmployeeRepo employeeRepo { get; private set; }

        public IJobGroupRepo jobGroupRepo { get; private set; }

        public IOverTimeRepo overTimeRepo { get; private set; }

        public IpaymentRepo IpaymentRepo { get; private set; }

        public IUserRepo userRepo { get; private set; }      

        
        public IAllowancePayment_Transactions allowancePayment_Transactions { get; private set; }

        public IPayslipInfo payslipInfo { get; private set; }

        public IDeductionsRepository deductionsRepository { get; private set; }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }

        public int save()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
