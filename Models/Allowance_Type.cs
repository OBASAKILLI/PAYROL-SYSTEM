using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Models
{
    public class Allowance_Type
    {
        [Key]
        [MaxLength(50)]
        [Required]
        public string strId { get; set; }
        [Required]
        [DisplayName("Allowance Type")]
       // [DataType(DataType.EmailAddress)]
        public string strAllowanceTypeName { get; set; }
        [Required]
        [DisplayName("Salary % Rate")]
        public double strSalary_Rate { get; set; }
    }
}
