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

namespace Payroll_Management_System.User_Controls.Manage
{
    public partial class ucManageOverTime : UserControl
    {
        private Boolean insert = true;

        public ucManageOverTime()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            lblOTNinfo.Visible = false;
            lblOTHRinfo.Visible = false;
            object o = new object();
            EventArgs e = new EventArgs();
            txtSearch_KeyUp(o, e);
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
            lblOTNinfo.Visible = false;
            lblOTHRinfo.Visible = false;

        }

        private OverTime getFromTextBox()
        {

            OverTime ot = new OverTime();
            
            if (!string.IsNullOrWhiteSpace(txtOtID.Text))
                ot.otId = int.Parse(txtOtID.Text);
            if (!string.IsNullOrWhiteSpace(txtName.Text))
                ot.otName = txtName.Text;
            else
            {
                lblOTNinfo.Visible = true;

            }
            if (!string.IsNullOrWhiteSpace(txtHourlyRate.Text))
                ot.hrRate =Double.Parse(txtHourlyRate.Text);
            else
            {
                lblOTHRinfo.Visible = true;
            }
            ot.TimeStart = StartTime.Value;
            ot.TimeEnd = EndTime.Value;
           
                ot.otDesc = txtDescription.Text;
           

            return ot;
        }

        private void setIntoTextBox(OverTime ot)
        {
            if (ot.otId != null)
                txtOtID.Text = ot.otId.ToString();
            if (ot.otName != null)
                txtName.Text = ot.otName;
            if (ot.hrRate != null)
                txtHourlyRate.Text = ot.hrRate.ToString();

            StartTime.Value=ot.TimeStart;
           
            EndTime.Value = ot.TimeEnd; ;
            if (ot.otDesc != null)
                txtDescription.Text = ot.otDesc;


            insert = false;
            btnSave.Text = "Save";
        }


        private void UcManageOverTime_Load(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert = true;

            txtOtID.Text = "";
            btnSave.Text = "Insert";
            clear();
            txtName.Focus();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OverTime ot = new OverTime();

                ot = getFromTextBox();

                if (insert == true)
                {
                    DBlayer.insertOverTime(ot);
                    Driver.Message("A NEW OVERTIME IS ADDED SUCCESFULLY",false);
                    //Employee empp=DBlayer.fetchEmployee(lastId);
                    //setIntoTextBox(empp);
                    insert = false;
                    clear();
                    btnSave.Enabled = false;
                    btnClear.Enabled = false;
                    btnSave.Text = "Save";
                    txtSearch_KeyUp(sender, e);
                }
                else
                {
                    // update proc
                    DBlayer.updateOverTime(ot);
                    
                    Driver.Message("OVERTIME IS SAVED SUCCESFULLY", false);
                    txtSearch_KeyUp(sender, e);


                }
            }
            catch(FormatException fe)
            {
                lblOTHRinfo.Visible = true;
            }
            catch (Exception r)
            {
                Driver.Message(r.Message, false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO DELETE?", true);
            if (Driver.getAns() == "YES")
            {
                try
                {
                    DBlayer.deleteOverTime(int.Parse(txtOtID.Text));
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClear.Enabled = false;
                    txtOtID.Text = "";
                    clear();
                    Driver.Message("THE OVERTIME IS DELETED SUCCESFULLY", false);
                    txtSearch_KeyUp(sender, e);
                }

                catch (Exception eeee)
                {
                }
            }
        }

        private void dgvOverTimeSearch_DoubleClick(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
        
            clear();
        }

        private void TxtSearch_OnTextChange(object sender, EventArgs e)
        {

        }

        private void DgvOverTimeSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
