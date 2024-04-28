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

        public async Task<IActionResult> CreateNewEmployee()
        {
          
            return View();
        }
        public async Task<IActionResult> EditEmployee(string id)
        {
            if (id != null) {
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
        public async Task<IActionResult> CreateNewEmployee(Employees employees)
        {
            //return Json(employees);
            if (employees!=null)
            {
                await _unitOfWork.employeeRepo.AddNew(employees);
                _unitOfWork.save();
                TempData["successs"] = $"{employees.strFullName} was added successfully into the system";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
           
            return Redirect("~/Employees/Index");
        }


    }
}