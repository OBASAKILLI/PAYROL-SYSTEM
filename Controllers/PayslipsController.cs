using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PAYROL_SYSTEM.Controllers
{
    public class PayslipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GeneratePayslip(string id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}