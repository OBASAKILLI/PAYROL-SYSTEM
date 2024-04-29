using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Models
{
    public class Commission
    {
        [Key]
        [MaxLength(50)]
        [Required]
        public string strId { get; set; }
        [Required]
        [DisplayName("Employee")]
        public string strUserId { get; set; }
        [Required]
        [DisplayName("Date")]
        public DateTime strDate { get; set; }
        [Required]
        [DisplayName("Amount")]
        public double strAmount { get; set; }
        [Required]
        [DisplayName("Paid Status")]
        public PaidStatus strPaidStatus { get; set; }


    }
   
}
