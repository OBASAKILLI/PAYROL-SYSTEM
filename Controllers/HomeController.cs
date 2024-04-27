using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PAYROL_SYSTEM.Interfaces;
using PAYROL_SYSTEM.Models;

namespace PAYROL_SYSTEM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [AllowAnonymous]
        public IActionResult LoginUser(Users user)
        {
            // return Json(user);
            if (user.strUsername == null || user.strUsername == null)
            {
                TempData["Err"] = "Username or password fields cannot be empty";
                //return Redirect("~/Home/Index");
                return Content("Username or password fields cannot be empty");
            }
            // var pass = user.strUserName;

            TokenProvider TokenProvider = new TokenProvider(_unitOfWork);
          
            var userToken = TokenProvider.LoginUser(user.strUsername, user.strPassword);
        
            if (userToken != null)
            {
              


                HttpContext.Session.SetString("Name", TokenProvider.GetUserDetails(user.strUsername, user.strPassword).strFullName);
                HttpContext.Session.SetString("JWToken", userToken);

                // return Redirect("~/Home/HomePage");
                return Content("Login Success");

            }
            else
            {
                TempData["Err"] = "Wrong password or username";
                //  return RedirectToAction("Index", "Home");

                return Content("Wrong User credentials");
            }


        }
        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return Redirect("~/Home/Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
