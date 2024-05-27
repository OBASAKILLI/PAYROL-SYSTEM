using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    public class DesignationRoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DesignationRoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }



        public async Task<IActionResult> CreateDesignation(string strDesignation_Role)
        {
            Designation_Role d = new Designation_Role();
            d.strDesignation_Role = strDesignation_Role;
            d.strId = Guid.NewGuid().ToString();

            await _unitOfWork.Idesignation_RoleRepo.AddNew(d);
            _unitOfWork.save();
            TempData["successs"] = $"{strDesignation_Role} was added successfully";
            return Redirect("~/DesignationRole/Index");
        }


        public async Task<IActionResult> EdfitDesignationRole(string id, string strDesignation_Role)
        {
            if (id != null)
            {
                Designation_Role designation_Role = await _unitOfWork.Idesignation_RoleRepo.GetById(id);
                if (designation_Role != null)
                {
                    designation_Role.strDesignation_Role = strDesignation_Role;
                    await _unitOfWork.Idesignation_RoleRepo.Update(designation_Role);
                    _unitOfWork.save();
                    TempData["successs"] = $"{strDesignation_Role} Updated successfully";
                }
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/DesignationRole/Index");
        }



        public async Task<IActionResult> DeleteDesignationRole(string id)
        {
            if (id != null)
            {
                Designation_Role designation_Role = await _unitOfWork.Idesignation_RoleRepo.GetById(id);
                if (designation_Role != null)
                {
                    await _unitOfWork.Idesignation_RoleRepo.Remove(designation_Role);
                    _unitOfWork.save();
                    TempData["successs"] = $"{designation_Role.strDesignation_Role} Romeved successfully";
                }
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }
            return Redirect("~/DesignationRole/Index");
        }


    }
}