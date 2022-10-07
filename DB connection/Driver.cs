using Payroll_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management_System.DB_connection
{
    class Driver
    {
        public static Image image;
        public static void Message(string Message,bool controls)
        {
            using (customMessageBox cm = new customMessageBox(Message, controls))
            {
                cm.ShowDialog();
            }
        }
        public static string getAns()
        {
            return customMessageBox.ans;
        }
    }
}
