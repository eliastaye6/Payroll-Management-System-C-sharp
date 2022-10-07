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
using Payroll_Management_System.Properties;

namespace Payroll_Management_System.User_Controls
{
    public partial class ucScheduleOvertime : UserControl
    {
        public ucScheduleOvertime()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            object o = new object();
            EventArgs e = new EventArgs();
            TxtSearch_KeyUp(o, e);
            lblEinfo.Visible = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            
        }
        bool insert = false;
        SortedList<int, string> ls;
        private void clear()
        {
            lblEinfo.Visible = false;
            txtEmpId.Text = "";
        }
        private void loadIntoCombo()
        {
            try
            {
                ls = DBlayer.fetchAllOvertime();
                comboOT.DataSource = ls.Values.ToArray<string>();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UcScheduleOvertime_Load(object sender, EventArgs e)
        {

        }

        private void TxtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvUserSearch.DataSource = DBlayer.searchScheduledOt(sk);
            }
            catch (Exception ex)
            {

            }
        }
        private void setIntoTextBox(Employee emp,OtSchedule ot)
        {
            loadIntoCombo();
            txtEmpId.Text = emp.employeeId.ToString();
            if (emp.imageRecieve != null)
                userPicBox.Image = Image.FromStream(emp.imageRecieve);
            lblFullName.Text= emp.firstname + " " + emp.lastname;
            date.Value = ot.date;


            comboOT.SelectedIndex = ls.IndexOfKey(ot.typeId);
                
            
        }
        private OtSchedule getFromTextBox()
        {
            
            OtSchedule ot = new OtSchedule();
            if (!string.IsNullOrWhiteSpace(txtEmpId.Text))
                ot.empId = int.Parse(txtEmpId.Text);
            else
                lblEinfo.Visible = true;
            ot.date = date.Value.Date;
            if (comboOT.SelectedIndex > -1) {
                
                    int idx= ls.Keys[comboOT.SelectedIndex];
                ot.typeId = idx;
            }
            return ot;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            loadIntoCombo();
            
            date.Enabled = true;
            lblEinfo.Visible = false;
            userPicBox.Image = Resources.icons8_payroll_480px;
            lblFullName.Text = "FULLNAME";
            insert = true;
            txtEmpId.Text = "";
            btnSave.Text = "Insert";
            txtEmpId.Enabled = true;
            txtEmpId.Focus();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void DgvUserSearch_DoubleClick(object sender, EventArgs e)
        {
            date.Enabled = false;

            clear();
            loadIntoCombo();
            txtEmpId.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnDelete.Enabled = true;
            userPicBox.Image = Resources.icons8_payroll_480px;
            try
            {

                int empId = int.Parse(dgvUserSearch.CurrentRow.Cells[0].Value.ToString());

                Employee emp = DBlayer.fetchEmployee(empId);
                OtSchedule ot = DBlayer.fetchOtSchedule(empId);
                setIntoTextBox(emp,ot);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                OtSchedule ot=new OtSchedule();

                ot = getFromTextBox();


                if (insert == true)
                {
                   DBlayer.insertOvertimeSchedule(ot);
                    
                    
                    insert = false;
                    clear();
                    btnSave.Text = "Save";
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    lblEinfo.Visible = false;
                    btnClear.Enabled = false;
                    TxtSearch_KeyUp(sender, e);
                }
                else
                {
                    lblEinfo.Visible = false;
                    //update proc
                    DBlayer.updateOvertimeSchedule(ot);
                    Driver.Message("EMPLOYEE IS UPDATED  SUCCESFULLY", false);
                    TxtSearch_KeyUp(sender, e);
                    

                }
            }
            catch (FormatException eee)
            {
                
            }
            catch (Exception r)
            {
                Driver.Message(r.Message, false);
                

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO DELETE?", true);
            if (Driver.getAns() == "YES")
            {
                OtSchedule ot = new OtSchedule();
                ot = getFromTextBox();
                try
                {
                    DBlayer.deleteOvertimeSchedule(ot);
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                   
                    btnClear.Enabled = false;
                    lblEinfo.Text = "";
                    clear();
                    Driver.Message("SCHEDULE IS DELETED SUCCESFULLY", false);

                    TxtSearch_KeyUp(sender, e);
                }

                catch (Exception eeee)
                {
                }
            }
        }
    }
}
