using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    public class PayslipsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PayslipsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> UpdatepayeeInfo(double Payeeamount,string strId)
        {
            PayslipMonthlyInfo p = await _unitOfWork.payslipInfo.GetById(strId);
            if (p != null)
            {
                p.PAYE = Payeeamount;
               await  _unitOfWork.payslipInfo.Update(p);
                _unitOfWork.save();
                TempData["successs"] = "Payslip info updated Successfully";

            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Payslips/Index"); 
        }
        public IActionResult Index( string id)
        {
            ViewBag.payslipMonthlyInfos = id;

           

            return View();
        }
        public IActionResult GeneratePayslip(string id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}