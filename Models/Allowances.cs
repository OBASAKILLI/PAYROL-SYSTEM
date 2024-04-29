using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Models
{
    public class Allowances
    {
        [Key]
        [MaxLength(50)]
        [Required]
        public string strId { get; set; }
        [Required]
        [DisplayName("Employee")]
        public string strUserId { get; set; }
      
        [DisplayName("Type of Allawance")]
        public string strAllowanceId { get; set; }


    }
}
