using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management_System.Model_Classes
{
    public class User
    {
        public  int userId;
        public string username;
        public string password;
        public string firstname;
        public string lastname;
        public Stream imageRecieve;
        public byte[] imageSend;
        public string Role;

    }
}
