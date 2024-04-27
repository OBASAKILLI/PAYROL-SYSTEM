using System;
using System.Collections.Generic;
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
        public string strUserId { get; set; }
        [Required]
        public DateTime strDate { get; set; }
        [Required]
        public double strAmount { get; set; }
        [Required]
        public bool strPaidStatus { get; set; }
    }
}
