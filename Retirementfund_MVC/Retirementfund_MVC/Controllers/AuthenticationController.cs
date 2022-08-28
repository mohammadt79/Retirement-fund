using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Retirementfund_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Signin()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

    }
}
