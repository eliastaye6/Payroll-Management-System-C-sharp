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

namespace Payroll_Management_System.User_Controls.Manage
{
    public partial class ucManageUsers : UserControl
    {
        private Boolean insert = true;
        public ucManageUsers()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            hideInfo();
            object o = new object();
            EventArgs e = new EventArgs();
            txtSearch_KeyUp(o, e);
        }

        private void UcManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvUserSearch.DataSource = DBlayer.searchUser(sk);
            }
            catch (Exception ex)
            {

            }
        }
        private void hideInfo (){
            lblFNinfo.Visible = false;
            lblLNinfo.Visible = false;
            lblPWinfo.Visible = false;
            lblRinfo.Visible = false;
            lblUNinfo.Visible = false;
            
                }

        private void clear()
        {
           // hideInfo();
            //    employeePicBox.Image = Image.FromFile(@"C:\Users\ELA.T\Desktop\School\2nd year\1st semester\Windows Programming C#\assignment\Project\Image\icons8_payroll_480px.png");
            userPicBox.Image = Resources.icons8_user_96px;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private User getFromTextBox()
        {
            User usr = new User();
            if (!string.IsNullOrWhiteSpace(txtUserID.Text))
                usr.userId = int.Parse(txtUserID.Text);
            if (!string.IsNullOrWhiteSpace(txtFirstName.Text))
                usr.firstname = txtFirstName.Text;
            else

            {
                lblFNinfo.Visible = true;

            }
            if (!string.IsNullOrWhiteSpace(txtLastName.Text))
                usr.lastname = txtLastName.Text;
            else
            {
                lblLNinfo.Visible = true;
            }
            if (!string.IsNullOrWhiteSpace(txtUserName.Text))
                usr.username = txtUserName.Text;
            else
            {
                lblUNinfo.Visible = true;
            }
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                usr.password = txtPassword.Text;
            else
            {
                lblPWinfo.Visible = true;
            }
            if(!string.IsNullOrWhiteSpace(comboRole.Text))
            usr.Role = comboRole.Text;

            else
            {
                lblRinfo.Visible = true;
            }
            //   

            MemoryStream ms = new MemoryStream();
            userPicBox.Image.Save(ms, userPicBox.Image.RawFormat);
            usr.imageSend = ms.ToArray();            
            
            return usr;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert = true;
            txtUserID.Text = "";
            btnSave.Text = "Insert";
            clear();
            txtFirstName.Focus();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void userPicBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (op.ShowDialog() == DialogResult.OK)
            {
                userPicBox.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
               User usr = new User();
            
                usr = getFromTextBox();

                if (insert == true)
                {
                    DBlayer.insertUser(usr);
                    Driver.Message("A NEW USER IS ADDED SUCCESFULLY", false);
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
                    DBlayer.updateUser(usr);
                    Driver.Message("THE USER IS SAVED SUCCESFULLY", false);
                    hideInfo();
                    txtPassword.Text = "";
                    txtSearch_KeyUp(sender, e);
                    
                }
            }
            catch (FormatException eee)
            {
                
            }
            catch (Exception r)
            {
            
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            hideInfo();
            try
            {
                DBlayer.deleteUser(int.Parse(txtUserID.Text));
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                txtUserID.Text = "";
                clear();
                Driver.Message("USER IS DELETED SUCCESFULLY", false);
                
                txtSearch_KeyUp(sender, e);
            }

            catch (Exception eeee)
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            hideInfo();
            clear();
        }

        private void setIntoTextBox(User usr)
        {
            if (usr.imageRecieve != null)
                userPicBox.Image = Image.FromStream(usr.imageRecieve);

            if (usr.userId != null)
            {      txtUserID.Text = usr.userId.ToString();                                
            }
            if (usr.firstname != null)
                txtFirstName.Text = usr.firstname;
            if (usr.lastname != null)
                txtLastName.Text = usr.lastname;
            if (usr.username != null)
                txtUserName.Text = usr.username;
            if (usr.password != null)
                txtPassword.Text = usr.password;
                if (usr.Role != null)
                comboRole.SelectedItem = usr.Role;
            insert = false;
            btnSave.Text = "Save";
        }


        private void dgvUserSearch_DoubleClick(object sender, EventArgs e)
        {
            hideInfo();
            clear();
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            //    employeePicBox.Image = Image.FromFile(@"C:\Users\ELA.T\Desktop\School\2nd year\1st semester\Windows Programming C#\assignment\Project\Image\icons8_payroll_480px.png");
            try
            {

                int userId = int.Parse(dgvUserSearch.CurrentRow.Cells[0].Value.ToString());
                if (userId ==Main_Form.userId)
                {
                    btnDelete.Enabled = false;
                }
                User usr = DBlayer.fetchUser(userId);
                setIntoTextBox(usr);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void ViewEmpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblUsername_Click(object sender, EventArgs e)
        {

        }

        private void LblLastName_Click(object sender, EventArgs e)
        {

        }

        private void LblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void TxtFirstName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtLastName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtUserName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LblUserID_Click(object sender, EventArgs e)
        {

        }

        private void LblPassword_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LblRinfo_Click(object sender, EventArgs e)
        {

        }

        private void LblPWinfo_Click(object sender, EventArgs e)
        {

        }

        private void LblUNinfo_Click(object sender, EventArgs e)
        {

        }

        private void LblLNinfo_Click(object sender, EventArgs e)
        {

        }

        private void LblFNinfo_Click(object sender, EventArgs e)
        {

        }

        private void TxtUserID_Click(object sender, EventArgs e)
        {

        }

        private void ComboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblRole_Click(object sender, EventArgs e)
        {

        }

        private void BottomButtonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvUserSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtSearch_OnTextChange(object sender, EventArgs e)
        {

        }
    }
    }

