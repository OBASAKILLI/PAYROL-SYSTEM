using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Models
{
    public class PayslipMonthlyInfo
    {
        [Key]
        [MaxLength(50)]
        public string strId { get; set; }
        [Required]
        public string strUserId { get; set; }
        [Required]
        
        public double strBasicSalary { get; set; }
        [Required]
        public double strTotalAllowance { get; set; }
        [Required]
        public double strTotalCommission { get; set; }
        [Required]
        public double strTotalOvertime { get; set; }
        [Required]
        public double strNSSF { get; set; }
        [Required]
        public double strNHIF { get; set; }
        [Required]
        public double strHousingLevvy { get; set; }
        [Required]
        public string strMonthYear { get; set; }
        [Required]
        public bool strIsPaidStatus { get; set; }
        [Required]
        public double strSaccoDeduction { get; set; }
        [Required]
        public string strBankName { get; set; }
        [Required]
        public string stBankAccount { get; set; }
        [Required]
        public string strFullName { get; set; }
        [Required]
        public string strDesignation { get; set; }
      //  [Required]
      //  public string strJobGroup { get; set; }
        [Required]
        public string strDepartment { get; set; }
        [Required]
        public double PAYE { get; set; }
    
    }
}
