using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Retirementfund_MVC.Data;
using Retirementfund_MVC;
using Microsoft.AspNetCore.Http;
using Retirementfund_MVC.Services;

namespace Retirementfund_MVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly DataContext _context;
        private readonly AuthTokenCache _authTokenCache;
        public AuthenticationController(DataContext context, AuthTokenCache authTokenCache)
        {
            _context = context;
            _authTokenCache = authTokenCache;   
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

             var userInfo= _context.Users.Where(s=>s.Email==login.Email && s.Pass==login.Pass).SingleOrDefault();
                if(userInfo !=null )
                {
                  
                        var guid =  Guid.NewGuid().ToString();
                        HttpContext.Response.Cookies.Append("access_token", guid, new CookieOptions { HttpOnly = true });
                        _authTokenCache.Set(userInfo, guid);
                   
                    return Redirect("/");
                }
                else
                {

                    ViewBag.error = "نام کاربری و رمز عبور اشتباه است ";
                    return Redirect("/Authentication/Signin");
                }
              
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
