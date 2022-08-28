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


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public  HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           var s=_context.TheConferenceModel.Select(x=>x).ToList;
            return View();
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
