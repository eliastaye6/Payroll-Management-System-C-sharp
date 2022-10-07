using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management_System.Model_Classes
{
   public class Employee
    {
        public int employeeId;
        public string firstname;
        public string lastname;
        public char sex;
        public double salary;
        public DateTime DOB = DateTime.MinValue;
        public DateTime DOE = DateTime.MinValue;
        public Stream imageRecieve;
        public int MyProperty { get; set; }
        
        public byte[] imageSend;
        public string telNo;
        public string emergencyNo;
        public int depId;
        public int typeId;
        public int groupId;
        public int insertedBy;



    }
}
