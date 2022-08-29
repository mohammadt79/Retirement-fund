using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Retirementfund_MVC.Data;
namespace Retirementfund_MVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _context;
        public AdminController(DataContext context) {
            _context = context;
        }
        [HttpGet]
        public IActionResult Confrance()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Confrance(Models.TheConferenceModel Conference)
        {
            var data = new Models.TheConferenceModel
            {
                Name = Conference.Name,
                discription = Conference.discription,
                PlaceName = Conference.PlaceName,
                Date = Conference.Date,
                Address = Conference.Address,
            };
            _context.TheConference.Add(data);
            _context.SaveChanges();
            return Json(data: Ok());

        }
        public IActionResult CRequest()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Fund()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Fund(Models.FundModel fund)
        {
            try
            {
                var data = new Models.FundModel
                {
                    Name=fund.Name,
                    discription = fund.discription,
                    Value = fund.Value,
                    Number = fund.Number,
                    date = fund.date,

                };
                _context.Fund.Add(data);
                _context.SaveChanges();
                return Json(data: Ok());
            }
            catch
            {
                return Json(data: BadRequest());
            }
        }
    }
}
