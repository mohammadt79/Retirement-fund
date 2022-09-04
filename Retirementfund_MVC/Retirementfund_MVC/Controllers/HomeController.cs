using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Retirementfund_MVC.Models;
using Retirementfund_MVC.Controllers;
using Retirementfund_MVC.Services;
using Retirementfund_MVC.Data;

namespace Retirementfund_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AuthTokenCache _authTokenCache;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger,DataContext context,AuthTokenCache auth)
        {
            _logger = logger;
            _context = context;
            _authTokenCache = auth;
        }
        //public void HomeService(DataContext context)
        //{
        //    _context = context;
        //}
        public IActionResult requestSituation()
        {
            var user = new Users();
            user = _authTokenCache.Get(HttpContext.Request.Cookies["access_token"]);
            if (user != null)
            {
                var req = _context.Request.Where(req => req.UserId == user.Id).FirstOrDefault();
                return View(req.adminCheck);

            }
            return View();
        }
        public IActionResult Index()
        {
            
          
            ViewBag.Emp_data= _context.TheConference.ToList();
            return View() ;
        }
       
        [HttpGet]
        public IActionResult RegisterRequest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterRequest(Request request)
        {
            var user = new Users();
            user = _authTokenCache.Get(HttpContext.Request.Cookies["access_token"]);
            var data = new Models.Request
            {
                Type = request.Type,
                discription = request.discription,
                price = request.price,
                UserId=user.Id,
                DateTime = request.DateTime,
                
            };
            _context.Request.Add(data);
            _context.SaveChanges();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
