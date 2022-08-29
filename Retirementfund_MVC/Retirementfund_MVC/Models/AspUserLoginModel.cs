using System;

namespace Retirementfund_MVC.Models
{
    public class AspUserLoginModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime MyProperty { get; set; }
        public string token { get; set; }
    }
}
