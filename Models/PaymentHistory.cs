using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Models
{
    public class PaymentHistory
    {
        [Key]
[MaxLength(50)]
        public string strId { get; set; }
        public string struSERiD { get; set; }
        public double strToTal_Overtime { get; set; }
        public double strToTal_Commission { get; set; }
        public double strToTal_Allowances { get; set; }
        public double strNHIF{ get; set; }
        public double strNSSF { get; set; }
        public double strhOUSElEVVY { get; set; }
        public double strSalary { get; set; }


    }
}
