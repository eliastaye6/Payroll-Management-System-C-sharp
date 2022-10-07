using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_Management_System.DB_connection;
using Payroll_Management_System.Model_Classes;

namespace Payroll_Management_System.User_Controls.View
{
    public partial class ucViewOvertime : UserControl
    {
        public ucViewOvertime()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            object o = new object();
            EventArgs e = new EventArgs();
            txtSearch_KeyUp(o, e);
        }

        private void UcViewOvertime_Load(object sender, EventArgs e)
        {

        }



        private void setIntoTextBox(OverTime ot)
        {
            if (ot.otId != null)
                txtOtID.Text = ot.otId.ToString();
            if (ot.otName != null)
                txtName.Text = ot.otName;
            if (ot.hrRate != null)
                txtHourlyRate.Text = ot.hrRate.ToString();

            StartTime.Value = ot.TimeStart;

            EndTime.Value = ot.TimeEnd; ;
            if (ot.otDesc != null)
                txtDescription.Text = ot.otDesc;


        
        }
        private void txtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvOverTimeSearch.DataSource = DBlayer.searchOverTime(sk);
            }
            catch (Exception ex)
            {

            }
        }
        private void clear()
        {

            //    employeePicBox.Image = Image.FromFile(@"C:\Users\ELA.T\Desktop\School\2nd year\1st semester\Windows Programming C#\assignment\Project\Image\icons8_payroll_480px.png");
            txtOtID.Text = "";
            txtName.Text = "";
            txtHourlyRate.Text = "";
            StartTime.Value = DateTime.Now;
            EndTime.Value = DateTime.Now;
            txtDescription.Text = "";
            

        }
        private void dgvOverTimeSearch_DoubleClick(object sender, EventArgs e)
        {
            clear();
           
            //    employeePicBox.Image = Image.FromFile(@"C:\Users\ELA.T\Desktop\School\2nd year\1st semester\Windows Programming C#\assignment\Project\Image\icons8_payroll_480px.png");
            try
            {

                int otId = int.Parse(dgvOverTimeSearch.CurrentRow.Cells[0].Value.ToString());

                OverTime ot = new OverTime();
                ot = DBlayer.fetchOverTime(otId);
                setIntoTextBox(ot);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }



    }
}
