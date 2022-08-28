using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retirementfund_MVC.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Admin { get; set; }
    }
}
