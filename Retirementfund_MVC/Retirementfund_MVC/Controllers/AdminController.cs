using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Retirementfund_MVC.Data;
using Retirementfund_MVC.Middlewares;
using Retirementfund_MVC.Models;
namespace Retirementfund_MVC.Controllers
{

    [RFAuthorize]
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
        public IActionResult CRequestCheck()
        {

            var viewModel = _context.Request.Join(_context.Users,
                requ => requ.UserId,
                user => user.Id,
                (requ, user) => new AdminCheckUserView
                {
                    Id=requ.Id,
                    Type = requ.Type,
                    discription = requ.discription,
                    price = requ.price,
                    Username=user.FirstName+user.LastName,
                    DateTime = requ.DateTime,
                    adminCheck = requ.adminCheck,
                   
                }).ToList();


            return View(viewModel);
        }

        [HttpGet]
        [Route("CRequest/{RequestId}/{IsAccept}")]
        public IActionResult CRequest([FromRoute] int RequestId,[FromRoute] bool IsAccept)
        {
            var request = _context.Request.Where(item => item.Id == RequestId).FirstOrDefault();
            request.adminCheck = IsAccept;
            _context.Request.Update(request);
            _context.SaveChanges();


            return RedirectToAction("CRequestCheck");
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
