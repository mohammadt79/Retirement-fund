using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Retirementfund_MVC.Models;
using Retirementfund_MVC.Data;

namespace Retirementfund_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;
        public HomeController(ILogger<HomeController> logger,DataContext context)
        {
            _logger = logger;
            _context = context;
        }
        //public void HomeService(DataContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
           
            ViewBag.Emp_data= _context.TheConferenceModel.ToList();
            return View() ;
        }
       

        public IActionResult RegisterRequest()
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
