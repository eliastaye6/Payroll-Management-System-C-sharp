using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Payroll_Management_System.Model_Classes
{
  public  class OverTime
    {
        public int otId;
        public string otName;
        public double hrRate;
        public DateTime TimeStart;
        public DateTime TimeEnd;
        public string otDesc;
    }
}
