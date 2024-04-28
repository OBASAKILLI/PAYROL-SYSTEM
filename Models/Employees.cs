using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Full Name")]
        public string strFullName { get; set; }
        [Required]
        [DisplayName("Id No")]
        public string strIdNo { get; set; }
        [DisplayName("NHIF")]
        public string strNHIF_No { get; set; }
        [DisplayName("NSSF")]
        public string strNSSF_NO { get; set; }
        [DisplayName("Email")]
        public string strEmail { get; set; }
        [Required]
        [DisplayName("KRA PIN")]
        public string strIdKRAPIN { get; set; }
        [DisplayName("Department")]
        public string strDetartmentId { get; set; }
        [Required]
        [DisplayName("Role")]
        public string strRole { get; set; }
        [DisplayName("Phone No")]
        public string strPhoneNo { get; set; }
        [Required]
        [DisplayName("Joining Date")]
        public DateTime strDate_Of_Join { get; set; }
        [Required]
        [DisplayName("Active Status")]
        public bool strActive_Status { get; set; }
        [Required]
        [DisplayName("Job Group")]
        public string strJobGroupId { get; set; }
        [DisplayName("Gender")]
        public Gender strGender { get; set; }///........
        [DisplayName("Religion")]
        public string strReligion { get; set; }
        [Required]
        [DisplayName("D.O.B")]
        public DateTime strDateOfBirth { get; set; }
        [DisplayName("Marital Status")]
        public Marital_Status strMarital_Status { get; set; }
        [DisplayName("Bank")]
        public string strBank_Name { get; set; }
        [DisplayName("Acc No")]
        public string strAccountNo { get; set; }
        [DisplayName("Staff No")]
        public string strStaff_No { get; set; }
        [DisplayName("Sacco Deduction")]
        public double strSacco_Deductyion { get; set; }
        [DisplayName("Loan Deduction")]
        public double strLoan { get; set; }
        [DisplayName("Penalties")]
        public double strPenalties { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
        
    }
    public enum Marital_Status
    {
        Single,
        Marred,
        Rather_not_say
    }
    public enum Active_Status
    {
        Active,
        In_Active
    }
}
