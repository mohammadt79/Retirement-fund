using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Retirementfund_MVC.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string discription { get; set; }
        public string price { get; set; }
        public int? UserId { get; set; }
        public DateTime DateTime { get; set; }
        public bool? adminCheck { get; set; } = null;
        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }
    }
}
