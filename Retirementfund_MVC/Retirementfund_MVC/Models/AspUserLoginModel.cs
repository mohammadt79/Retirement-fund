using System;
using System.ComponentModel.DataAnnotations;

namespace Retirementfund_MVC.Models
{
    public class AspUserLoginModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime MyProperty { get; set; }
        public string token { get; set; }
    }
}
