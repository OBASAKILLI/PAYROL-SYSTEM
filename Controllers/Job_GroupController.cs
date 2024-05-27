using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    public class Job_GroupController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public Job_GroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> CreateJobGroup(Job_Groups job_Groups)
        {
            job_Groups.strId = Guid.NewGuid().ToString();
            // return Json(job_Groups);
            if (!ModelState.IsValid)
            {
                // return Json(job_Groups);
                await _unitOfWork.jobGroupRepo.AddNew(job_Groups);
                _unitOfWork.save();

                TempData["successs"] = $"{job_Groups.strGroupName} was added successfully";
            }
            else
            {
                TempData["Err"] = "Something went wrong..";
            }
            return Redirect("~/Job_Group/Index");
        }

        public async Task<IActionResult> UpdateJobGroup(Job_Groups job_Groups)
        {
            if (ModelState.IsValid)
            {

                await _unitOfWork.jobGroupRepo.Update(job_Groups);
                _unitOfWork.save();

                TempData["successs"] = $"{job_Groups.strGroupName} Updated successfully";
            }
            else
            {
                TempData["Err"] = "Something went wrong..";
            }
            return Redirect("~/Job_Group/Index");
        }
        public async Task<IActionResult> RemoveJobGroup(string id)
        {
            Job_Groups j = await _unitOfWork.jobGroupRepo.GetById(id);

            if (j != null)
            {
                await _unitOfWork.jobGroupRepo.Remove(j);
                _unitOfWork.save();

                TempData["Err"] = $"{j.strGroupName} Removed successfully";
            }
            else
            {
                TempData["Err"] = "Something went wrong";
            }

            return Redirect("~/Job_Group/Index");
        }

    }
}