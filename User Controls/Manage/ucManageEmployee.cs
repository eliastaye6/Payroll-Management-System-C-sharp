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
using System.Drawing.Imaging;
using Payroll_Management_System.Forms;
using Payroll_Management_System.Properties;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
//using Payroll_Management_System.Print_ID.IdGenerator;
//using Payroll_Management_System.Print_ID.IdGenerator.EmployeeDataSet;

//using Payroll_Management_System.Print_ID;
//using Payroll_Management_System.Print_ID;
//using Payroll_Management_System.Print_ID;
//using Payroll_Management_System.Print_ID.IdGenerator.CrystalReport;
namespace Payroll_Management_System.User_Controls
{
    public partial class ucManageEmployee : UserControl
    {
        private Boolean insert = true;
        public ucManageEmployee()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnClear.Enabled = false;
            Object o = new Object();
            EventArgs e = new EventArgs();
            TxtSearch_KeyUp(o, e);
            
            
        }
        SortedList<int, string> lsDepartment;
        SortedList<int, string> lsGroup;
        SortedList<int, string> lsEmpType;
        private void clear() {
         hideInfo();
        employeePicBox.Image = Resources.icons8_payroll_480px;
            picBoxBarcode.Image=null;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            radbtnFemale.Checked = false;
            radbtnMale.Checked = false;
            txtSalary.Text = "";
            dateTimeDOB.Value = DateTime.Now;
            dateTimeDOE.Value = DateTime.Now;
        //    comboDepartment.Items.Clear();
        //    comboEmployeeType.Items.Clear();
        //    comboGroup.Items.Clear();
            txtTel.Text = "";
            txtEmergency.Text = "";

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

        private void DgvEmpSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadIntoComboBoxes()
        {
            lsDepartment = DBlayer.fetchAllDepartment();
           
                comboDepartment.DataSource=lsDepartment.Values.ToArray<string>();
            lsGroup = DBlayer.fetchAllGroups();
            comboGroup.DataSource = lsGroup.Values.ToArray<string>();
            lsEmpType = DBlayer.fetchAllEmpTypes();
            comboEmployeeType.DataSource = lsEmpType.Values.ToArray<string>();
        }
        private void setIntoTextBox(Employee emp)
        {
            loadIntoComboBoxes();
            
           
            
            //comboEmployeeType.Items.Add(DBlayer.searchEmpType(""));
            //comboGroup.Items.Add(DBlayer.searchGroup(""));
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
                catch(Exception e)
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
                    radbtnMale.Checked = true;
                else if (sex == 'F')
                    radbtnFemale.Checked = true;
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
            if (emp.depId != null)
            {
                comboDepartment.SelectedIndex = lsDepartment.IndexOfKey(emp.depId);
            }
            else
            {

            }
            if (emp.groupId != null)
            {
                comboGroup.SelectedIndex = lsGroup.IndexOfKey(emp.groupId);
            }
            else
            {

            }
            if (emp.typeId != null)
            {
                comboEmployeeType.SelectedIndex = lsEmpType.IndexOfKey(emp.typeId);
            }
            else
            {

            }
            
            if (emp.telNo != null)
                txtTel.Text = emp.telNo;
            if (emp.emergencyNo != null)
                txtEmergency.Text = emp.emergencyNo;

            insert = false;
            btnSave.Text = "Save";
        }
        private void DgvEmpSearch_DoubleClick(object sender, EventArgs e)
        {
            loadIntoComboBoxes();
            hideInfo();
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            
            btnPrint.Enabled = true;
            btnClear.Enabled = true;
            employeePicBox.Image = Resources.icons8_payroll_480px;
            try
            {

                int empId = int.Parse(dgvEmpSearch.CurrentRow.Cells[0].Value.ToString());

                Employee emp = DBlayer.fetchEmployee(empId);
                setIntoTextBox(emp);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
         
            clear();
        }

        private Employee getFromTextBox()
        {
           
                Employee emp = new Employee();
            if(!string.IsNullOrWhiteSpace(lblEmpId.Text))
                emp.employeeId = int.Parse(lblEmpId.Text);
            if (!string.IsNullOrWhiteSpace(txtFirstName.Text))
                emp.firstname = txtFirstName.Text;
            else
                lblFNinfo.Visible = true;
            if (!string.IsNullOrWhiteSpace(txtLastName.Text))
                emp.lastname = txtLastName.Text;
            else lblLNinfo.Visible = true;
                if (radbtnFemale.Checked == true)
                    emp.sex = 'F';
                else if (radbtnMale.Checked == true)
                    emp.sex = 'M';
                else if (radbtnFemale.Checked == false && radbtnMale.Checked == false)
            {
                lblSexInfo.Visible = true;
               
            }
           
                emp.salary = Double.Parse(txtSalary.Text);
            
             //   
                emp.DOB = dateTimeDOB.Value;
                emp.DOE = dateTimeDOE.Value;
                MemoryStream ms = new MemoryStream();
                employeePicBox.Image.Save(ms, employeePicBox.Image.RawFormat);
                emp.imageSend = ms.ToArray();
                emp.telNo = txtTel.Text;
                emp.emergencyNo = txtEmergency.Text;
            if (comboDepartment.SelectedIndex > -1)
            {
                int index = comboDepartment.SelectedIndex;
                
                emp.depId = lsDepartment.Keys[index];
            }
         
           if (comboGroup.SelectedIndex > -1)
            {
                int index = comboGroup.SelectedIndex;
                emp.groupId = lsGroup.Keys[index];
            }
            if (comboEmployeeType.SelectedIndex > -1)
            {
                int index = comboEmployeeType.SelectedIndex;
                emp.typeId = lsEmpType.Keys[index];

            }
            
            emp.insertedBy = Main_Form.userId;
                return emp;
            
            
            }
       
        private void hideInfo()
        {
            lblLNinfo.Visible = false;
            lblFNinfo.Visible = false;
            lblSalaryInfo.Text = "Salary cannot be empty";
            lblSalaryInfo.Visible = false;
            lblSexInfo.Visible = false;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            hideInfo();
            try
            {
                Employee emp = new Employee();

                emp = getFromTextBox();


                if (insert == true)
                {
                    DBlayer.insertEmployee(emp);
                    Driver.Message("A NEW EMPLOYEE IS ADDED SUCCESFULLY",false);
                    //Employee empp=DBlayer.fetchEmployee(lastId);
                    //setIntoTextBox(empp);
                    insert = false;
                    clear();
                    btnSave.Text = "Save";
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    btnClear.Enabled = false;
                    TxtSearch_KeyUp(sender, e);
                }
                else
                {
                    //update proc
                    DBlayer.updateEmployee(emp);
                    Driver.Message("EMPLOYEE IS UPDATED  SUCCESFULLY", false);
                    TxtSearch_KeyUp(sender, e);
                    

                }
            }
            catch (FormatException eee)
            {
                lblSalaryInfo.Text = "Only numbers are allowed in salary";
                lblSalaryInfo.Visible = true;
            }
            catch (Exception r)
            {
               // Driver.Message(r.Message, false);
                //Driver.Message("UNABLE TO PERFORM ACTION", false);

            }
        }

        private void EmployeePicBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (op.ShowDialog() == DialogResult.OK)
            {
                employeePicBox.Image = Image.FromFile(op.FileName);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            loadIntoComboBoxes();
            hideInfo();
            insert = true;
            lblEmpId.Text = "";
            btnSave.Text = "Insert";
            clear();
            txtFirstName.Focus();
            txtFirstName.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void UcManageEmployee_Load(object sender, EventArgs e)
        {

        }
       
       
   


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO DELETE?", true);
            if (Driver.getAns() == "YES")
            {
                try
                {
                    DBlayer.deleteEmployee(int.Parse(lblEmpId.Text));
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    btnClear.Enabled = false;
                    lblEmpId.Text = "";
                    clear();
                    Driver.Message("EMPLOYEE IS DELETED SUCCESFULLY", false);

                    TxtSearch_KeyUp(sender, e);
                }

                catch (Exception eeee)
                {
                }
            }
        }

        private void PicBoxBarcode_Click(object sender, EventArgs e)
        {

        }

        private void PrintIdDialog_Load(object sender, EventArgs e)
        {

        }


        private void TxtSearch_OnTextChange(object sender, EventArgs e)
        {

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp = DBlayer.fetchEmployee(int.Parse(lblEmpId.Text));
            
            using(Print_ID pi=new Print_ID(emp))
            {
                pi.ShowDialog();
            }
        }
    }
}
