using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Retirementfund_MVC.Data;

namespace Retirementfund_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly DataContext _context;
        public AuthenticationController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Signin()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SignUp(Models.Users users)
        {
            try {
               
                var data = new Models.Users
                {
                    FirstName = users.FirstName,
                    LastName = users.LastName,
                    Pass = users.Pass,
                    Email = users.Email,
                    PhoneNumber = users.PhoneNumber,
                };
                _context.Users.Add(data);
                _context.SaveChanges();
                return Json(data: Ok());
            }
            catch
            {
                return Json(data:BadRequest());
            }
            }


    }
}
