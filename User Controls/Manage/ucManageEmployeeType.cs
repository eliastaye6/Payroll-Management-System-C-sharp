using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_Management_System.Model_Classes;
using Payroll_Management_System.DB_connection;

namespace Payroll_Management_System.User_Controls.Manage
{
    public partial class ucManageEmployeeType : UserControl
    {
        public ucManageEmployeeType()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            lblTNinfo.Visible = false;
            Object o = new object();
            EventArgs e = new EventArgs();
            txtSearch_KeyUp(o, e);
        }
        bool insert = false;

        private void UcManageEmployeeType_Load(object sender, EventArgs e)
        {

        }
        private void txtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvEmpTypeSearch.DataSource = DBlayer.searchEmpType(sk);
            }
            catch (Exception ex)
            {

            }
        }

        private EmpType getFromTextBox()
        {
            
            EmpType emp = new EmpType();
            if (!string.IsNullOrWhiteSpace(txtGroupId.Text))
                emp.TypeID = int.Parse(txtGroupId.Text);
            if (!string.IsNullOrWhiteSpace(txtName.Text))
                emp.TypeName = txtName.Text;
            else
            {
                lblTNinfo.Visible = true;

            }
            if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                emp.TypeDescription = txtDescription.Text;
            else
            {

            }

            return emp;
        }
        private void clear()
        {
            lblTNinfo.Visible = false;
            txtDescription.Text = "";
            txtName.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                EmpType emp = new EmpType();

                emp = getFromTextBox();

                if (insert == true)
                {
                    DBlayer.insertEmpType(emp);
                    Driver.Message("NEW EMPLOYEE TYPE ADDED SUCCESFULLY",false); 
                    //Employee empp=DBlayer.fetchEmployee(lastId);
                    //setIntoTextBox(empp);
                    insert = false;
                    lblTNinfo.Visible = false;
                    clear();
                    btnSave.Text = "Save";
                    txtSearch_KeyUp(sender, e);
                    btnSave.Enabled = false;
                    btnClear.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    //update proc
                    DBlayer.updateEmpType(emp);
                    lblTNinfo.Visible = false;
                    Driver.Message("EMPLOYEE TYPE IS SAVED SUCCESFULLY", false);
                    txtSearch_KeyUp(sender, e);


                }
            }
            catch (FormatException eee)
            {

            }
            catch (Exception r)
            {
                //Driver.Message(r.Message, false);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO DELETE EMPLOYEE TYPE", true);
            if (Driver.getAns() == "YES")
            {
                try
                {
                    DBlayer.deleteEmpType(int.Parse(txtGroupId.Text));
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClear.Enabled = false;
                    txtGroupId.Text = "";
                    clear();

                    Driver.Message("EMPLOYEE TYPE IS DELETED SUCCESFULLY", false);
                    txtSearch_KeyUp(sender, e);
                }
                catch (Exception exxx)
                {

                }
            }
            }
        private void TxtSearch_OnTextChange(object sender, EventArgs e)
        {

        }
        private void setIntoTextBox(EmpType emp)
        {
            if (emp.TypeID != null)
                txtGroupId.Text = emp.TypeID.ToString();
            if (emp.TypeName != null)
                txtName.Text = emp.TypeName;
            if (emp.TypeDescription != null)
                txtDescription.Text = emp.TypeDescription;


            insert = false;
            btnSave.Text = "Save";
        }



        private void dgvEmpTypeSearch_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            //    employeePicBox.Image = Image.FromFile(@"C:\Users\ELA.T\Desktop\School\2nd year\1st semester\Windows Programming C#\assignment\Project\Image\icons8_payroll_480px.png");
            try
            {

                int empId = int.Parse(dgvEmpTypeSearch.CurrentRow.Cells[0].Value.ToString());

                EmpType emp = DBlayer.fetchEmpType(empId);
                setIntoTextBox(emp);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }

        private void DgvEmpTypeSearch_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            clear();
            txtGroupId.Text = "";
            insert = true;
            txtName.Focus();
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }
    }
}
