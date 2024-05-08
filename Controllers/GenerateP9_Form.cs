using PAYROL_SYSTEM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAYROL_SYSTEM.Controllers
{
    public class GenerateP9_Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenerateP9_Form(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<P9Info>> P9InfoMethod(string UserId)
        {
            int date = DateTime.UtcNow.AddHours(3).Month;
            int Dateofmonth = DateTime.UtcNow.AddHours(3).Day;
            var jaandate = DateTime.UtcNow.AddHours(3).AddDays(-(Dateofmonth - 1)).AddMonths(-(date - 1));
            List<YearMonths> dataatat = new List<YearMonths>();
            dataatat.Clear();

            for (int i = 1; i <= 12; i++)
            {
                YearMonths y = new YearMonths();
                y.MonthName = jaandate.ToString("MMMM");
                y.Code = jaandate.ToString("MMM");
                dataatat.Add(y);
                jaandate = jaandate.AddMonths(1);
            }
            List<P9Info> p9Infos = new List<P9Info>();
            p9Infos.Clear();
            foreach (var item in dataatat)
            {
                P9Info p = new P9Info();
                var Record =( await _unitOfWork.payslipInfo.GetAll()).FirstOrDefault(k=>k.strMonthYear.Split('/')[0]== item.Code &&k.strUserId== UserId);
                if (Record != null)
                {
                    //not null
                    p.Month = item.MonthName;
                    p.Actual = 0;
                    p.Basic_Salary = Record.strBasicSalary;
                    p.Benefits_Non_Cash = 0;
                    p.Chargable_Pay = 0;
                    p.Fixed = 0;
                    p.Payee = 0;
                    p.P_Relief = Record.PAYE;
                    p.Standard_Smount = 0;
                    p.Tax = Record.PAYE;
                    p.TheLowestOf_E_and_F = 0;
                    p.ThirtyPerCent = (30* Record.strBasicSalary)/100;
                    p.Total_Gross_pay = 0;
                    p.Value_of_Quarter = 0;
                    p9Infos.Add(p);
                }
                else
                {
                    // its null
                    p.Month = item.MonthName;
                    p.Actual = 0;
                    p.Basic_Salary = 0;
                    p.Benefits_Non_Cash = 0;
                    p.Chargable_Pay = 0;
                    p.Fixed = 0;
                    p.Payee = 0;
                    p.P_Relief = 0;
                    p.Standard_Smount = 0;
                    p.Tax = 0;
                    p.TheLowestOf_E_and_F = 0;
                    p.ThirtyPerCent = 0;
                    p.Total_Gross_pay = 0;
                    p.Value_of_Quarter = 0;
                    p9Infos.Add(p);
                }
               

              
            }
            return p9Infos;
        }

    }

    public class P9Info
    {
        public string Month { get; set; }
        public double Basic_Salary { get; set; }
        public double Benefits_Non_Cash { get; set; }
        public double Value_of_Quarter { get; set; }
        public double Total_Gross_pay { get; set; }
        public double ThirtyPerCent { get; set; }
        public double Actual { get; set; }
        public double Fixed { get; set; }
        public double Standard_Smount { get; set; }
        public double TheLowestOf_E_and_F { get; set; }
        public double Chargable_Pay { get; set; }
        public double Tax { get; set; }
        public double P_Relief { get; set; }
        public double Payee { get; set; }

    }


    public class YearMonths
    {
        public string Code { get; set; }
        public string MonthName { get; set; }
    }
}
