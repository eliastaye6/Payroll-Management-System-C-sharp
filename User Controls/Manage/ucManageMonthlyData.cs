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
using System.IO;
using Payroll_Management_System.Properties;
using System.Data.SqlClient;

namespace Payroll_Management_System.User_Controls
{
    public partial class ucManageMonthlyData : UserControl
    {
        private bool insert = true;
        public ucManageMonthlyData()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            lblEIDinfo.Visible = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            txtEmployeeID.ReadOnly = true;
            Object o = new Object();
            EventArgs e = new EventArgs();
            txtSearch_KeyUp(o, e);
        }

        private void UcManageMonthlyData_Load(object sender, EventArgs e)
        {

        }

        private void ViewEmpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvMonthlyDataSearch.DataSource = DBlayer.searchMonthlyData(sk);
            }
            catch (Exception ex)
            {

            }
        }

        private MonthlyData getFromTextBox()
        {
            MonthlyData mon = new MonthlyData();
            if (!string.IsNullOrWhiteSpace(txtEmployeeID.Text))
                mon.empId = int.Parse(txtEmployeeID.Text);
            else
            {
                lblEIDinfo.Visible = true;
                throw new Exception();
            }
            if (!string.IsNullOrWhiteSpace(txtUnpaidSalary.Text))
                mon.UnpaidSalary = double.Parse(txtUnpaidSalary.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtUnpaidPension.Text))
                mon.UnpaidPension = double.Parse(txtUnpaidPension.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtUnpaidTax.Text))
                mon.UnpaidIncomeTax = double.Parse(txtUnpaidTax.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtIncentive.Text))
                mon.Incentive = double.Parse(txtIncentive.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtMedical.Text))
                mon.Medical = double.Parse(txtMedical.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtCourtCase.Text))
                mon.CourtCase = double.Parse(txtCourtCase.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtFine.Text))
                mon.Fine = double.Parse(txtFine.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtOverPayment.Text))
                mon.OverPayment = double.Parse(txtOverPayment.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtActingAllowance.Text))
                mon.ActingAllowance = double.Parse(txtActingAllowance.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtMobile.Text))
                mon.MobileandTransport = double.Parse(txtMobile.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtSaving.Text))
                mon.Saving = double.Parse(txtSaving.Text);
            else { }
            if (!string.IsNullOrWhiteSpace(txtOther.Text))
                mon.OtherContribution = double.Parse(txtOther.Text);
            else { }  //   
                      return mon;
        }

        private void setIntoTextBox(MonthlyData mon)
        {
            if (mon.imageRecieve != null)
                empPicBox.Image = Image.FromStream(mon.imageRecieve);
            if (mon.empId != null)
            {
                string barCode = txtEmployeeID.Text = mon.empId.ToString();
                //setting barcode below
                try
                {
                    Zen.Barcode.Code39BarcodeDraw brCode =
                    Zen.Barcode.BarcodeDrawFactory.Code39WithChecksum;
                    PicBoxBarcode.Image = brCode.Draw(barCode, 60);
                }
                catch (Exception e)
                {

                }
            }
            if (mon.FullName != null)
                lblfullName.Text = mon.FullName;

            txtUnpaidSalary.Text = mon.UnpaidSalary.ToString();
            txtUnpaidPension.Text = mon.UnpaidPension.ToString();
            txtUnpaidTax.Text = mon.UnpaidIncomeTax.ToString();
            txtIncentive.Text = mon.Incentive.ToString();
            txtMedical.Text = mon.Medical.ToString();
            txtCourtCase.Text = mon.CourtCase.ToString();
            txtFine.Text = mon.Fine.ToString();
            txtOverPayment.Text = mon.OverPayment.ToString();
            txtActingAllowance.Text = mon.ActingAllowance.ToString();
            txtMobile.Text = mon.MobileandTransport.ToString();
            txtSaving.Text = mon.Saving.ToString();
            txtOther.Text = mon.OtherContribution.ToString();

            insert = false;
            btnSave.Text = "Save";
        }


        private void clear()
        {
            lblEIDinfo.Visible = false;
         

            //empPicBox.Image = Resources.icons8_payroll_480px;
            // PicBoxBarcode.Image = null;

            //lblFullName.Text= "Fullname";
            txtUnpaidSalary.Text = "";
            txtUnpaidPension.Text = "";
            txtUnpaidTax.Text = "";
            txtIncentive.Text = "";
            txtMedical.Text = "";
            txtCourtCase.Text = "";
            txtFine.Text = "";
            txtOverPayment.Text = "";
            txtActingAllowance.Text = "";
            txtMobile.Text = "";
            txtSaving.Text = "";
            txtOther.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblEIDinfo.Visible = false;
                try
                {
                    MonthlyData mon = new MonthlyData();

                    mon = getFromTextBox();

                    if (insert == true)
                    {
                        DBlayer.insertMonthlyData(mon);
                    Driver.Message("A NEW MONTHLY DATA IS ADDED SUCCESFULLY", false);
                    //Employee empp=DBlayer.fetchEmployee(lastId);
                    //setIntoTextBox(empp);
                    insert = false;
                        clear();
                        btnSave.Text = "Save";
                        txtSearch_KeyUp(sender, e);
                    }
                    else
                    {
                        //update proc
                        DBlayer.updateMonthlyData(mon);
                    Driver.Message("MONTHLY DATA IS SAVED SUCCESFULLY", false);
                    txtSearch_KeyUp(sender, e);

                    }
                }
                catch (SqlException eee)
                {
                Driver.Message(eee.Message, false);
            }
                catch (Exception r)
                {
                
            }
            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert = true;
            empPicBox.Image = Resources.icons8_payroll_480px;
            PicBoxBarcode.Image = null;
            lblEIDinfo.Visible = false;
            txtEmployeeID.ReadOnly = false;

            //lblFullName.Text = null;
            //  txtEmployeeID.Text = "";
            btnSave.Text = "Insert";
           clear();
            txtEmployeeID.Focus();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO DELETE?", true);
            if (Driver.getAns ()== "YES")
            {
                try
                {
                    DBlayer.deleteMonthlyData(int.Parse(txtEmployeeID.Text));
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClear.Enabled = false;
                    txtEmployeeID.Text = "";
                    clear();
                    Driver.Message("MONTHLY DATA IS DELETED SUCCESFULLY", false);

                    txtSearch_KeyUp(sender, e);
                }

                catch (Exception eeee)
                {
                 
                }
            }
        }

        private void dgvMonthlyDataSearch_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            txtEmployeeID.ReadOnly = true;
            //    employeePicBox.Image = Image.FromFile(@"C:\Users\ELA.T\Desktop\School\2nd year\1st semester\Windows Programming C#\assignment\Project\Image\icons8_payroll_480px.png");
            try
            {

                int empId = int.Parse(dgvMonthlyDataSearch.CurrentRow.Cells[0].Value.ToString());

                MonthlyData mon = DBlayer.fetchMonthlyData(empId);
                setIntoTextBox(mon);

            }
            catch (Exception eee)
            {
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
    }

