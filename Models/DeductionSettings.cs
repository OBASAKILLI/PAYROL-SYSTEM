using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Models
{
    public class DeductionSettings
    {
        [Key]
      [MaxLength(50)]
        public string strId { get; set; }
        [Required]
        public double strNHIFDeduction { get; set; }
        [Required]
        public double strNSSFDeduction { get; set; }
        [Required]
        public double strHouseLevy { get; set; }
    }
}
