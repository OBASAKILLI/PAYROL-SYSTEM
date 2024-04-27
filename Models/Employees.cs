using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Models
{
    public class Employees
    {
        [Key]
        [MaxLength(50)]
        [Required]
        public string strId { get; set; }
        [Required]
        public string strFullName { get; set; }
        [Required]
        public string strIdNo { get; set; }
        public string strNHIF_No { get; set; }
        public string strNSSF_NO { get; set; }
        public string strEmail { get; set; }
        [Required]
        public string strIdKRAPIN { get; set; }
        public string strDetartmentId { get; set; }
        [Required]
        public string strRole { get; set; }
        public string strPhoneNo { get; set; }
        [Required]
        public DateTime strDate_Of_Join { get; set; }
        [Required]
        public bool strActive_Status { get; set; }
        [Required]
        public string strJobGroupId { get; set; }
        public string strGender { get; set; }///........
        public string strReligion { get; set; }
        [Required]
        public DateTime strDateOfBirth { get; set; }
        public string strMarital_Status { get; set; }
        public string strBank_Name { get; set; }
        public string strAccountNo { get; set; }
        public string strStaff_No { get; set; }
        public double strSacco_Deductyion { get; set; }
        public double strLoan { get; set; }
        public double strPenalties { get; set; }
    }
}
