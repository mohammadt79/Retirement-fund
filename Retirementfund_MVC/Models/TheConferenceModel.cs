using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.SignalR;

namespace Retirementfund_MVC.Models
{
    public class TheConferenceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string discription { get; set; }
        public string PlaceName { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }



    }
}
