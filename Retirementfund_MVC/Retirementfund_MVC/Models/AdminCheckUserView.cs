using System;

namespace Retirementfund_MVC.Models
{
    public class AdminCheckUserView
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string discription { get; set; }
        public string price { get; set; }
        public string Username { get; set; }
        public DateTime DateTime { get; set; }
        public bool? adminCheck { get; set; }
     
    }
}
