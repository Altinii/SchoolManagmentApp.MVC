using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagmentApp.MVC
{
    public class ControllersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}