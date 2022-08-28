using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Retirementfund_MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Confrance()
        {
            return View();
        }
        public IActionResult CRequest()
        {
            return View();
        }
        public IActionResult Fund()
        {
            return View();
        }
    }
}
