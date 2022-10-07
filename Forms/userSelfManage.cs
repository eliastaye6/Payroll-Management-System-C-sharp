using Payroll_Management_System.DB_connection;
using Payroll_Management_System.Model_Classes;
using Payroll_Management_System.User_Controls.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms
{
    public partial class userSelfManage : Form
    {

        Form Login;
        Form MainForm;

        public userSelfManage(Form Login,Form MainForm,User user)
        {
            this.Login = Login;
            this.MainForm = MainForm;
            InitializeComponent();
            this.Size = new Size(468, 418);
            //setting labels below

            lblDisplayUserId.Text = user.userId.ToString();
            lblDisplayfirstName.Text = user.firstname;
            lblDisplayLastName.Text = user.lastname;
            lblDisplayUserName.Text = user.username;
            lblRole.Text = user.Role;
            if(user.imageRecieve!=null)
            userPicBox.Image = Image.FromStream(user.imageRecieve);
            

        }

        private void UserSelfManage_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Driver.image = userPicBox.Image;
            
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO LOGOUT",true);
            if (Driver.getAns() == "YES")
            {
                this.Dispose();
                MainForm.Dispose();
                Login.Show();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            this.Size = new Size(468, 573);
            ucPasswordChange uc = new ucPasswordChange(Login,MainForm,this);
            bottomPanel.Controls.Add(uc);
            
            
        }

        private void BtnPicChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (op.ShowDialog() == DialogResult.OK)
            {
                Image oldImage = userPicBox.Image;
               userPicBox.Image = Image.FromFile(op.FileName);
                Driver.Message("ARE YOU SURE YOU WANT TO CHANGE PHOTO?",true);
                if (Driver.getAns() == "YES")
                {
                    MemoryStream ms = new MemoryStream();
                    userPicBox.Image.Save(ms, userPicBox.Image.RawFormat);
                    byte[] image = ms.ToArray();
                    DBlayer.changeUserImage(Main_Form.userId, image);
                    Driver.Message("YOUR PHOTO HAS BEEN CHANGED SUCCESFULLY", false);
                }
                else
                {
                    userPicBox.Image = oldImage;
                }
            }
        }

        private void LblDisplayfirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
