using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> OverTime()
        {
            return View();
        }


        public async Task<IActionResult> Commission()
        {
            return View();
        }



        public async Task<IActionResult> CreateNewEmployee()
        {
            return View();
        }



        public async Task<IActionResult> EditEmployee(string id)
        {
            if (id != null)
            {
                Employees e = await _unitOfWork.employeeRepo.GetById(id);
                if (e != null)
                {
                    return View(e);
                }
                else
                {
                    TempData["Err"] = "Something went wrong";
                    return Redirect("~/Employees/Index");
                }
            }
            TempData["Err"] = "Something went wrong";
            return Redirect("~/Employees/Index");
        }


        [HttpPost]
        public async Task<IActionResult> AddOverTime(OverTime overTime)
        {
            //return Json(employees);
            if (overTime != null)
            {
                await _unitOfWork.overTimeRepo.AddNew(overTime);
                _unitOfWork.save();
                TempData["successs"] = $"{overTime.strAmount} was added successfully into the system";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Employees/OverTime");
        }


        [HttpPost]
        public async Task<IActionResult> AddCommission(Commission commission)
        {
            //return Json(employees);
            if (commission != null)
            {
                await _unitOfWork.Icommissionrepo.AddNew(commission);
                _unitOfWork.save();
                TempData["successs"] = $"{commission.strAmount} was added successfully into the system";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Employees/Commission");
        }



        [HttpPost]
        public async Task<IActionResult> UpdateOverTime(OverTime overTime, string Employeename)
        {
            if (overTime != null)
            {
                // return Json(overTime);
                await _unitOfWork.overTimeRepo.Update(overTime);
                _unitOfWork.save();
                TempData["successs"] = $"Overtime amount of {overTime.strAmount} for {Employeename}  was Updated successfully";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Employees/OverTime");
        }




        [HttpPost]
        public async Task<IActionResult> UpdateCommission(Commission commission, string Employeename)
        {
            if (commission != null)
            {
                // return Json(overTime);
                await _unitOfWork.Icommissionrepo.Update(commission);
                _unitOfWork.save();
                TempData["successs"] = $"Commission amount of {commission.strAmount} for {Employeename}  was Updated successfully";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Employees/Commission");
        }


        [HttpPost]
        public async Task<IActionResult> CreateNewEmployee(Employees employees, CheckedAllowanceType checkedAllowanceType)
        {
            if (employees != null)
            {
                await _unitOfWork.employeeRepo.AddNew(employees);
                foreach (var data in checkedAllowanceType.checkedAllowances.Where(k => k.strIsChecked == true))
                {
                    Allowances allowances = new Allowances();
                    allowances.strId = Guid.NewGuid().ToString();
                    allowances.strUserId = employees.strId;
                    allowances.strAllowanceId = data.strAllowancetypeId;
                    await _unitOfWork.allowancesRepo.AddNew(allowances);
                }
                _unitOfWork.save();
                TempData["successs"] = $"{employees.strFullName} was added successfully into the system";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Employees/Index");
        }




        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employees employees)
        {
            //   return Json(employees);
            if (employees != null)
            {
                // return Json(employees);
                await _unitOfWork.employeeRepo.Update(employees);
                _unitOfWork.save();
                TempData["successs"] = $"{employees.strFullName}'s info Updated successfully into the system";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Employees/Index");
        }




        [HttpPost]
        public async Task<IActionResult> RemoveEMployee(string id)
        {
            //   return Json(employees);
            if (id != null)
            {
                Employees e = await _unitOfWork.employeeRepo.GetById(id);
                if (e != null)
                {
                    e.strActive_Status = Active_Status.In_Active;
                    await _unitOfWork.employeeRepo.Update(e);
                    _unitOfWork.save();
                    TempData["Err"] = $"{e.strFullName} is now in Active";
                }
                else
                {
                    TempData["Err"] = "Something went wrong";
                }
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Employees/Index");
        }



        [HttpPost]
        public async Task<IActionResult> RemoveOverTime(string id, string Employeename)
        {
            //   return Json(employees);
            if (id != null)
            {
                OverTime e = await _unitOfWork.overTimeRepo.GetById(id);
                if (e != null)
                {
                    await _unitOfWork.overTimeRepo.Remove(e);
                    _unitOfWork.save();
                    TempData["Err"] = $"Overtime amount of {e.strAmount} for {Employeename}  was Removed";
                }
                else
                {
                    TempData["Err"] = "Something went wrong";
                }
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }

            return Redirect("~/Employees/OverTime");
        }




        [HttpPost]
        public async Task<IActionResult> RemoveCommission(string id, string Employeename)
        {
            //   return Json(employees);
            if (id != null)
            {
                Commission e = await _unitOfWork.Icommissionrepo.GetById(id);
                if (e != null)
                {
                    await _unitOfWork.Icommissionrepo.Remove(e);
                    _unitOfWork.save();
                    TempData["Err"] = $"Commission amount of {e.strAmount} for {Employeename}  was Removed";
                }
                else
                {
                    TempData["Err"] = "Something went wrong";
                }
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }

            return Redirect("~/Employees/Commission");
        }


    }
}