using Payroll_Management_System.DB_connection;
using Payroll_Management_System.Model_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms
{
    public partial class ATTENDANCE : Form
    {
        public ATTENDANCE()
        {
            InitializeComponent();
            textBox4.Focus();
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void v(object sender, EventArgs e)
        {

        }
private void clear()
        {
            lblName.Text = "";
            userPicBox.Image = null;
        }
        private void TextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = 0;
                try
                {

                    double  num = double.Parse(textBox4.Text);
                    id = (int)num;
                    //id = 100000;
                    //DBlayer.insertAttendance(id);

                    textBox4.Text = "";
                    textBox4.Focus();

                }
                catch (FormatException es)
                {
                    //Driver.Message("INVALID CARD PLEASE SCAN AGAIN", false);
                    textBox4.Text = "";
                    textBox4.Focus();

                }
                catch (SqlException sq)
                {
                    Driver.Message(sq.Message, false);
                    textBox4.Text = "";
                    textBox4.Focus();
                    try
                    {
                        Employee emp = new Employee();
                        emp = DBlayer.fetchEmployee(id);
                        
                        userPicBox.Image = Image.FromStream(emp.imageRecieve);
                        lblName.Text = emp.firstname + " " + emp.lastname;
                    }
                    catch (Exception eee)
                    {
                        //MessageBox.Show(eee.Message);
                        
                    }
                }
                catch (Exception esd)
                {
                   // Driver.Message(esd.Message, false);
                    textBox4.Text = "";
                    textBox4.Focus();
                }
            }
        }

        private void ATTENDANCE_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
