using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    public class AllowancesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AllowancesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> AddAllowanceTransaction(AllowancePayment_Transactions allowance)
        {
            //  return Json(allowance);
            if (allowance != null)
            {
                await _unitOfWork.allowancePayment_Transactions.AddNew(allowance);
                _unitOfWork.save();
                TempData["successs"] = $"{allowance.strAmount} was added successfully into the system";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/Allowances/Index");
        }



        [HttpPost]
        public async Task<IActionResult> EditAllowanceTransactions(AllowancePayment_Transactions allowance, string Employeename)
        {
            // return Json(allowance);
            if (allowance != null)
            {
                // return Json(overTime);
                await _unitOfWork.allowancePayment_Transactions.Update(allowance);
                _unitOfWork.save();
                TempData["successs"] = $"Allowance amount of {allowance.strAmount} for {Employeename}  was Updated successfully";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }

            return Redirect("~/Allowances/Index");
        }


        //
        [HttpPost]
        public async Task<IActionResult> RemoveAllowanceTransaction(string id, string Employeename)
        {

         
            //   return Json(employees);
            if (id != null)
            {
                AllowancePayment_Transactions e = await _unitOfWork.allowancePayment_Transactions.GetById(id);
                if (e != null)
                {
                    await _unitOfWork.allowancePayment_Transactions.Remove(e);
                    _unitOfWork.save();
                    TempData["Err"] = $"Allowance amount of {e.strAmount} for {Employeename}  was Removed";
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
            return Redirect("~/Allowances/Index");
        }


    }
}