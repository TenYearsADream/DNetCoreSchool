using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Service;
using Microsoft.AspNetCore.Mvc;
using CoreApp2.Models;

namespace CoreApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAdminUserService _adminUserService;
        private readonly IUserService _userService;

        public HomeController(IAdminUserService adminUserService, IUserService userService)
        {
            this._adminUserService = adminUserService;
            this._userService = userService;
        }
        public IActionResult Index()
        {
            string a = null;
            a.ToString();
            return Content(_adminUserService.GetUserPassWord("leo") + _userService.GetUserCount());
            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
