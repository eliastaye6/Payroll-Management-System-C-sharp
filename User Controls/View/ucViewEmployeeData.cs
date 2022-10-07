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

namespace Payroll_Management_System.User_Controls.View
{
    public partial class ucViewEmployeeData : UserControl
    {
        public ucViewEmployeeData()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Object o = new Object();
            EventArgs e = new EventArgs();
            TxtSearch_KeyUp(o, e);
        }


        SortedList<int, string> lsDepartment;
        SortedList<int, string> lsGroup;
        SortedList<int, string> lsEmpType;
        private void loadIntoComboBoxes()
        {
            lsDepartment = DBlayer.fetchAllDepartment();

            lsGroup = DBlayer.fetchAllGroups();
         
            lsEmpType = DBlayer.fetchAllEmpTypes();
  
        }
        private void UcViewEmployeeData_Load(object sender, EventArgs e)
        {

        }

        private void TxtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvEmpSearch.DataSource = DBlayer.searchEmployee(sk);
            }
            catch (Exception ex)
            {

            }
        }
        private void setIntoTextBox(Employee emp)
        {
            if (emp.imageRecieve != null)
                employeePicBox.Image = Image.FromStream(emp.imageRecieve);

            if (emp.employeeId != null)
            {
                string barCode = lblEmpId.Text = emp.employeeId.ToString();
                //setting barcode below

                try
                {
                    //Zen.Barcode.Code93BarcodeDraw brCode =
                    //Zen.Barcode.BarcodeDrawFactory.Code93WithChecksum;

                    Zen.Barcode.Code39BarcodeDraw brCode =
                    Zen.Barcode.BarcodeDrawFactory.Code39WithChecksum;


                    picBoxBarcode.Image = brCode.Draw(barCode, 60);
                }
                catch (Exception e)
                {

                }

            }
            if (emp.firstname != null)
                txtFirstName.Text = emp.firstname;
            if (emp.lastname != null)
                txtLastName.Text = emp.lastname;
            char sex = emp.sex;
            if (emp.sex != null)
            {
                if (sex == 'M')
                    txtSex.Text = "MALE";
                else if (sex == 'F')
                    txtSex.Text = "FEMALE;";
            }
            if (emp.salary != null)
                txtSalary.Text = emp.salary.ToString();
            if (emp.DOB != DateTime.MinValue)
                dateTimeDOB.Value = emp.DOB;
            else
            {
                dateTimeDOB.Value = DateTime.Now;

            }
            if (emp.DOE != DateTime.MinValue)
                dateTimeDOE.Value = emp.DOE;
            else
            {
                dateTimeDOE.Value = DateTime.Now;
            }
            loadIntoComboBoxes();
            for (int i = 0; i < lsDepartment.Count; i++)
            {
                if (emp.depId == lsDepartment.Keys[i])
                {

                    txtDepartment.Text = (string)lsDepartment.Values[i];
                    break;
                }
            }
           for(int i = 0; i < lsGroup.Count; i++)
            {
                if (emp.groupId == lsGroup.Keys[i])
                {
                    txtGroup.Text = (string)lsGroup.Values[i];
                    break;
                }
            }
           for(int i = 0; i < lsEmpType.Count; i++)
            {
                if (emp.typeId == lsEmpType.Keys[i])
                {
                    txtEmployeeType.Text = (string)lsEmpType.Values[i];
                }
            }
            if (emp.telNo != null)
                txtTel.Text = emp.telNo;
            if (emp.emergencyNo != null)
                txtEmergency.Text = emp.emergencyNo;

            
        }
        private void clearEmp()
        {
            
            employeePicBox.Image = Resources.icons8_payroll_480px;
            picBoxBarcode.Image = null;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSex.Text = "";
            txtSalary.Text = "";
            dateTimeDOB.Value = DateTime.Now;
            dateTimeDOE.Value = DateTime.Now;
            txtDepartment.Text = "";
            txtGroup.Text = "";
            txtEmployeeType.Text = "";
           
            txtTel.Text = "";
            txtEmergency.Text = "";

        }
        private void DgvEmpSearch_DoubleClick(object sender, EventArgs e)
        {
            clearMon();
            clearEmp();
            employeePicBox.Image = Resources.icons8_payroll_480px;
            try
            {

                int empId = int.Parse(dgvEmpSearch.CurrentRow.Cells[0].Value.ToString());

                Employee emp = DBlayer.fetchEmployee(empId);
                setIntoTextBox(emp);

            }
            catch (Exception eee)
            {
               // MessageBox.Show(eee.Message);
            }


            //    employeePicBox.Image = Image.FromFile(@"C:\Users\ELA.T\Desktop\School\2nd year\1st semester\Windows Programming C#\assignment\Project\Image\icons8_payroll_480px.png");
            try
            {

                int empId = int.Parse(dgvEmpSearch.CurrentRow.Cells[0].Value.ToString());

                MonthlyData mon = DBlayer.fetchMonthlyDataDate(empId,searchDate.Value.Date);
                setIntoMonTextBox(mon);

            }
            catch (Exception eee)
            {
                Driver.Message("NO MONTHLY DATA IS AVAILABLE FOR THE EMPLOYEE IN THE SUPPLIED DATE", false);

            }
            try
            {
                int empId = int.Parse(dgvEmpSearch.CurrentRow.Cells[0].Value.ToString());
                int count = DBlayer.fetchAttendanceCount(empId, searchDate.Value.Date);
                progressBar.Value = (count/26)*100;
                if(count==0)
                    Driver.Message("NO ATTENDANCE DATA IS AVAILABLE FOR THE EMPLOYEE IN THE SUPPLIED DATE", false);

            }
            catch(Exception r)
            {
                Driver.Message("NO ATTENDANCE DATA IS AVAILABLE FOR THE EMPLOYEE IN THE SUPPLIED DATE", false);
            }
            try
            {
                int empId = int.Parse(dgvEmpSearch.CurrentRow.Cells[0].Value.ToString());
                dgvOverTime.DataSource= DBlayer.fetchOverTime(empId, searchDate.Value.Date);
                
               
            }
            catch (Exception r)
            {
                Driver.Message("NO OVERTIME DATA IS AVAILABLE FOR THE EMPLOYEE IN THE SUPPLIED DATE", false);
            }
        }
        private void clearMon()
        {
            


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
            txtOverPayement.Text = "";
            txtActingAllowance.Text = "";
            txtMobile.Text = "";
            txtSaving.Text = "";
            txtOther.Text = "";
        }

        private void setIntoMonTextBox(MonthlyData mon)
        {


            txtUnpaidSalary.Text = mon.UnpaidSalary.ToString();
            txtUnpaidPension.Text = mon.UnpaidPension.ToString();
            txtUnpaidTax.Text = mon.UnpaidIncomeTax.ToString();
            txtIncentive.Text = mon.Incentive.ToString();
            txtMedical.Text = mon.Medical.ToString();
            txtCourtCase.Text = mon.CourtCase.ToString();
            txtFine.Text = mon.Fine.ToString();
            txtOverPayement.Text = mon.OverPayment.ToString();
            txtActingAllowance.Text = mon.ActingAllowance.ToString();
            txtMobile.Text = mon.MobileandTransport.ToString();
            txtSaving.Text = mon.Saving.ToString();
            txtOther.Text = mon.OtherContribution.ToString();

            
        }

        private void DgvEmpSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
