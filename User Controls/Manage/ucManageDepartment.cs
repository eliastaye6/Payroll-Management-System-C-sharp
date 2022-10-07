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

namespace Payroll_Management_System.User_Controls
{
    public partial class ucManageDepartment : UserControl
    {
        public ucManageDepartment()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            lblDNinfo.Visible = false;
            object o = new object();
            EventArgs e = new EventArgs();
            TxtSearch_KeyUp(o, e);
        }
        bool insert = false;

        private void UcManageDepartment_Load(object sender, EventArgs e)
        {

        }
        private void clearWithId()
        {
            clearDep();
            txtDepartmentId.Text = "";
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            insert = true;
            btnSave.Text = "Insert";
            clearWithId();
            txtDepartmentName.Focus();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }
        private void TxtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvDepSearch.DataSource = DBlayer.searchDepartment(sk);
            }
            catch (Exception ex)
            {

            }
        }
        //TODO -adds to text boxes
        private void DgvDepSearch_DoubleClick(object sender, EventArgs e)
        {
            lblDNinfo.Visible = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            try
            {

                int depId = int.Parse(dgvDepSearch.CurrentRow.Cells[0].Value.ToString());
                Department dep = DBlayer.fetchDepartment(depId);
                setIntoDepTextBox(dep);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
        //TODO - to get from textBox
        private Department getFromTextBox()
        {

            Department dep = new Department();
            if (!string.IsNullOrWhiteSpace(txtDepartmentName.Text))
                dep.depName = txtDepartmentName.Text;
            else
                lblDNinfo.Visible = true;
            dep.depDescription = txtDescription.Text;

            return dep;
        }
        //TODO - to update old record or save new 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Department dep = new Department();
                dep = getFromTextBox();

                if (insert == true)
                {
                    DBlayer.insertDepartment(dep);
                    Driver.Message("A NEW DEPARTMENT HAS BEEN ADDED SUCCESFULLY", false);
                    clearDep();
                    insert = false;
                    btnSave.Text = "Save";
                    TxtSearch_KeyUp(sender, e);
                }
                else
                {
                    //update proc
                    DBlayer.updateDepartment(dep);
                    Driver.Message("DEPARTMENT HAS BEEN UPDATED SUCCESFULLY", false);
                    TxtSearch_KeyUp(sender, e);


                }
            }
            catch (NoNullAllowedException ex)
            {
                //Driver.Message("UNABLE TO PERFORM ACTION", false);

            }
            catch (Exception ex)
            {
               // Driver.Message("UNABLE TO PERFORM ACTION", false);
            }
        }
        //TODO - clear 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearDep();
            lblDNinfo.Visible = false;
        }
        //TODO -delete department
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO DELETE?", true);
            if (Driver.getAns() == "YES")
            {
                try
                {
                    DBlayer.deleteDepartment(int.Parse(txtDepartmentId.Text));
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClear.Enabled = false;
                    clearWithId();
                    Driver.Message("DEPARTMENT HAS BEEN DELETED SUCCESFULLY", false);
                    TxtSearch_KeyUp(sender, e);
                }

                catch (Exception eeee)
                {
                }
            }
        }


        private void setIntoDepTextBox(Department dep)
        {
            txtDepartmentId.Text = dep.depId.ToString();
            txtDepartmentName.Text = dep.depName;
            if (!string.IsNullOrWhiteSpace(dep.depDescription))
                txtDescription.Text = dep.depDescription;

        }

        private void clearDep()
        {
            lblDNinfo.Visible = false;
            txtDepartmentName.Text = "";
            txtDescription.Text = "";
        }
    }

}

