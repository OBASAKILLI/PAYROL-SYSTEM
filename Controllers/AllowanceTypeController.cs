using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    public class AllowanceTypesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AllowanceTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.allowanceTypeRepo.GetAll());
        }



        public async Task<IActionResult> CreateAllowanceTypes(string strAllowanceTypeName)
        {
            Allowance_Type d = new Allowance_Type();
            d.strAllowanceTypeName = strAllowanceTypeName;
            d.strId = Guid.NewGuid().ToString();

            await _unitOfWork.allowanceTypeRepo.AddNew(d);
            _unitOfWork.save();

            TempData["successs"] = $"{strAllowanceTypeName} was added successfully";
            return Redirect("~/AllowanceTypes/Index");
        }


        public async Task<IActionResult> EdfitAllowanceType(string id, string strAllowanceTypeName)
        {
            if (id != null)
            {
                Allowance_Type allowance_Type = await _unitOfWork.allowanceTypeRepo.GetById(id);
                if (allowance_Type != null)
                {
                    allowance_Type.strAllowanceTypeName = strAllowanceTypeName;
                    await _unitOfWork.allowanceTypeRepo.Update(allowance_Type);
                    _unitOfWork.save();
                    TempData["successs"] = $"{strAllowanceTypeName} Updated successfully";
                }
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/AllowanceTypes/Index");
        }



        public async Task<IActionResult> Deleteallowance_Type(string id)
        {
            if (id != null)
            {
                Allowance_Type allowance_Type = await _unitOfWork.allowanceTypeRepo.GetById(id);
                if (allowance_Type != null)
                {

                    await _unitOfWork.allowanceTypeRepo.Remove(allowance_Type);
                    _unitOfWork.save();
                    TempData["successs"] = $"{allowance_Type.strAllowanceTypeName} Romeved successfully";
                }
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/AllowanceTypes/Index");
        }
    }
}