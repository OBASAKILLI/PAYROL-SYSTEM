using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Controllers
{
    public class UpdatePayrol
    {
        private readonly IUnitOfWork _unitOfWork;
        //My Constractor
        public UpdatePayrol(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // MainMethod of managine the whole classss....
        public async Task ManageMonthlyPayrolRecord()
        {
            var Users = (await _unitOfWork.employeeRepo.GetAll()).Where(k => k.strActive_Status == Active_Status.Active);

            if (Users != null)
            {
                foreach (var item in Users)
                {
                    await GetJobGroup(item.strJobGroupId);
                    var ifexist = await _unitOfWork.payslipInfo.GetMonthlyUserPaySlip(item.strId, GetCurrentMonthYear());
                    if (ifexist != null)
                    {
                        //update 
                        await UpdateExistingRecord(ifexist, item);
                    }
                    else
                    {
                        //add new
                        await AddNewRecord(item);
                    }


                }
                _unitOfWork.save();
            }

        }

        //Get Job GroupObject
        public Job_Groups Job_Groups = new Job_Groups();
        public async Task GetJobGroup(string JobGroup)
        {
            Job_Groups = null;
            Job_Groups job_ = await _unitOfWork.jobGroupRepo.GetById(JobGroup);
            if (job_ != null)
            {
                Job_Groups = job_;
            }
        }
        //Get Designation Role       
        public async Task<string> GetDesignationName(string designationId)
        {
            var designation = "";
            Designation_Role designation_ = await _unitOfWork.Idesignation_RoleRepo.GetById(designationId);
            if (designation_ != null)
            {
                designation = designation_.strDesignation_Role;
            }
            return designation;
        }
        //Get Allowance
        public async Task<double> GetAllAllowance(string UserId)
        {
            double TT = 0;
            var data = (await _unitOfWork.allowancePayment_Transactions.GetAll()).Where(k => k.strUserId == UserId && k.strPaidStatus == PaidStatus.Pending);
            foreach (var item in data)
            {
                TT += item.strAmount;
            }
            return TT;
        }
        //Get Commission
        public async Task<double> GetAllCommission(string UserId)
        {
            double TT = 0;
            var data = (await _unitOfWork.Icommissionrepo.GetAll()).Where(k => k.strUserId == UserId && k.strPaidStatus == PaidStatus.Pending);
            foreach (var item in data)
            {
                TT += item.strAmount;
            }
            return TT;
        }
        //Get OverTime
        public async Task<double> GetAllOverTime(string UserId)
        {
            double TT = 0;
            var data = (await _unitOfWork.overTimeRepo.GetAll()).Where(k => k.strUserId == UserId && k.strPaidStatus == PaidStatus.Pending);
            foreach (var item in data)
            {
                TT += item.strAmount;
            }
            return TT;
        }
        //Get Department Name
        public async Task<string> GetDepartmentName(string UserId)
        {
            var DepName = "";
            Departments d = await _unitOfWork.departmentRepo.GetById(UserId);
            if (d != null)
            {
                DepName = d.strDepartmentId;
            }
            return DepName;
        }
        public string GetCurrentMonthYear()
        {
            return DateTime.UtcNow.AddHours(3).ToString("MMM/yy");
        }
        // Add new Record       
        public async Task AddNewRecord(Employees item)
        {
            PayslipMonthlyInfo p = new PayslipMonthlyInfo
            {
                stBankAccount = item.strAccountNo,
                strBankName = item.strBank_Name,
                strBasicSalary = Job_Groups.strBasicSalary,
                strDepartment = await GetDepartmentName(item.strDetartmentId),
                strDesignation = await GetDesignationName(item.strRole),
                strFullName = item.strFullName,
                strHousingLevvy = (Job_Groups.strHouseLevy * Job_Groups.strBasicSalary) / 100,
                strId = Guid.NewGuid().ToString(),
                strIsPaidStatus = false,
                strJobGroup = Job_Groups.strGroupName,
                strMonthYear = GetCurrentMonthYear(),
                strNHIF = Job_Groups.strNHIFDeduction,
                strNSSF = Job_Groups.strNSSFDeduction,
                strSaccoDeduction = item.strSacco_Deductyion,
                strTotalAllowance = await GetAllAllowance(item.strId),
                strTotalCommission = await GetAllCommission(item.strId),
                strTotalOvertime = await GetAllOverTime(item.strId),
                strUserId = item.strId,

            };
            await _unitOfWork.payslipInfo.AddNew(p);
        }

        //Update Existing Record
        public async Task UpdateExistingRecord(PayslipMonthlyInfo payslipMonthlyInfo, Employees item)
        {

            payslipMonthlyInfo.stBankAccount = item.strAccountNo;
            payslipMonthlyInfo.strBankName = item.strBank_Name;
            payslipMonthlyInfo.strBasicSalary = Job_Groups.strBasicSalary;
            payslipMonthlyInfo.strDepartment = await GetDepartmentName(item.strDetartmentId);
            payslipMonthlyInfo.strDesignation = await GetDesignationName(item.strRole);
            payslipMonthlyInfo.strFullName = item.strFullName;
            payslipMonthlyInfo.strHousingLevvy = (Job_Groups.strHouseLevy * Job_Groups.strBasicSalary) / 100;
            payslipMonthlyInfo.strIsPaidStatus = false;
            payslipMonthlyInfo.strJobGroup = Job_Groups.strGroupName;
            payslipMonthlyInfo.strMonthYear = GetCurrentMonthYear();
            payslipMonthlyInfo.strNHIF = Job_Groups.strNHIFDeduction;
            payslipMonthlyInfo.strNSSF = Job_Groups.strNSSFDeduction;
            payslipMonthlyInfo.strSaccoDeduction = item.strSacco_Deductyion;
            payslipMonthlyInfo.strTotalAllowance = await GetAllAllowance(item.strId);
            payslipMonthlyInfo.strTotalCommission = await GetAllCommission(item.strId);
            payslipMonthlyInfo.strTotalOvertime = await GetAllOverTime(item.strId);
            payslipMonthlyInfo.strUserId = item.strId;

            await _unitOfWork.payslipInfo.Update(payslipMonthlyInfo);
        }

    }
}
