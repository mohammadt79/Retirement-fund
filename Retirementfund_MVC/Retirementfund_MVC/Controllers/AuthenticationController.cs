using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Retirementfund_MVC.Data;
using Retirementfund_MVC;


namespace Retirementfund_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly DataContext _context;
        public AuthenticationController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Signin()
        {
            return View();    
        }
        [HttpPost]
        public ActionResult Signin(LoginView login)
        {
            try
            {

             var userInfo= _context.Users.Where(s=>s.Email==login.Email && s.Pass==login.Pass).ToList();
                if(userInfo != null)
                {
                    HttpContext.Response.Cookies.Append("access_token", , new CookieOptions { HttpOnly = true });
                    userInfo[0].Admin;   
                }
                return Redirect("");
            }
            catch
            {
                return BadRequest();
            }
           
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
