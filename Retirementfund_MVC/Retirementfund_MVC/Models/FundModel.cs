using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Retirementfund_MVC.Models
{
    public class FundModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string discription { get; set; }
        public int Value { get; set; }
        public  int Number { get; set; }
        public DateTime date { get; set; }



    }
}
