using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Payroll_Management_System.DB_connection;
using Payroll_Management_System.Model_Classes;

namespace Payroll_Management_System.User_Controls
{
    public partial class ucManageGroup : UserControl
    {
        public ucManageGroup()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            object o = new object();
            EventArgs e = new EventArgs();
            TxtSearch_KeyUp(o, e);
        }
        bool insert = false;
        private void clearWithId()
        {
            clearGroup();
            txtGroupId.Text = "";
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            insert = true;
            btnSave.Text = "Insert";
            clearWithId();
            txtGroupName.Focus();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }
        private void TxtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvGroupSearch.DataSource = DBlayer.searchGroup(sk);
            }
            catch (Exception ex)
            {

            }
        }
        //TODO -adds to text boxes
        private void DgvGroupSearch_DoubleClick(object sender, EventArgs e)
        {
            clearWithId();
            btnSave.Text = "Save";
            insert = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            try
            {

                int groupId = int.Parse(dgvGroupSearch.CurrentRow.Cells[0].Value.ToString());
                Groups group = DBlayer.fetchGroup(groupId);
                setIntoGroupTextBox(group);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
        //TODO - to get from textBox
        private Groups getFromTextBox()
        {

            Groups group = new Groups();
            if(!string.IsNullOrWhiteSpace(txtGroupId.Text))
            group.groupId = int.Parse(txtGroupId.Text);
            if (!string.IsNullOrWhiteSpace(txtGroupName.Text))
                group.groupName = txtGroupName.Text;
            else
                lblGNinfo.Visible = true;
            group.groupDescription = txtDescription.Text;

            return group;
        }
        //TODO - to update old record or save new 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Groups group = new Groups();
                group = getFromTextBox();

                if (insert == true)
                {
                    DBlayer.insertGroup(group);
                    Driver.Message("A NEW GROUP HAS BEEN ADDED SUCCESFULLY", false);
                    clearGroup();
                    insert = false;
                    btnSave.Text = "Save";
                    TxtSearch_KeyUp(sender, e);
                }
                else
                {
                    //update proc
                    DBlayer.updateGroup(group);
                    Driver.Message("GROUP HAS BEEN UPDATED SUCCESFULLY", false);
                    TxtSearch_KeyUp(sender, e);


                }
            }
            catch (NoNullAllowedException ex)
            {
                

            }
            catch (Exception ex)
            {
                Driver.Message(ex.Message, false);
            }
        }
        //TODO - clear 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblGNinfo.Visible = false;

            clearGroup();
        }
        //TODO -delete group
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO DELETE?", true);
            if (Driver.getAns() == "YES")
            {
                try
                {
                    DBlayer.deleteGroup(int.Parse(txtGroupId.Text));
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClear.Enabled = false;
                    lblGNinfo.Visible = false;
                    clearWithId();
                    Driver.Message("GROUP HAS BEEN DELETED SUCCESFULLY", false);
                    TxtSearch_KeyUp(sender, e);
                }

                catch (Exception eeee)
                {
                }
            }
        }


        private void setIntoGroupTextBox(Groups group)
        {
            txtGroupId.Text = group.groupId.ToString();
            txtGroupName.Text = group.groupName;
            if (!string.IsNullOrWhiteSpace(group.groupDescription))
                txtDescription.Text = group.groupDescription;

        }

        private void clearGroup()
        {

            txtGroupName.Text = "";
            txtDescription.Text = "";
        }

        private void UcManageGroup_Load(object sender, EventArgs e)
        {
           
        }

        private void TxtSearch_OnTextChange(object sender, EventArgs e)
        {

        }

        private void DgvGroupSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblGNinfo_Click(object sender, EventArgs e)
        {

        }
    }

}


