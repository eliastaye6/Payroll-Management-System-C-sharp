using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management_System.Model_Classes
{
  public  class MonthlyData
    {
        public int empId;
        public string FullName;
        public double UnpaidSalary;
        public double UnpaidPension;
        public double UnpaidIncomeTax;
        public double Incentive;
        public double salary;
        public double Medical;
        public double CourtCase;
        public double Fine;
        public double OverPayment;
        public double ActingAllowance;
        public double MobileandTransport;
        public double Saving;
        public double OtherContribution;
        public Stream imageRecieve;
        public int MyProperty { get; set; }
        public byte[] imageSend;
        public int insertedBy;
    }
}
