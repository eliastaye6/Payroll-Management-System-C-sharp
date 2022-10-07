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
using Payroll_Management_System.Forms;

namespace Payroll_Management_System.User_Controls.Others
{
    public partial class ucPasswordChange : UserControl
    {
        Form Login, MainForm, selfManage;
        public ucPasswordChange(Form Login,Form MainForm,Form selfManage)
        {
            InitializeComponent();
            txtOldPass.Focus();
            this.Login = Login;
            this.MainForm = MainForm;
            this.selfManage = selfManage;
        }

        private void UcPasswordChange_Load(object sender, EventArgs e)
        {

        }

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOldPass.Text))
                    Driver.Message("OLD PASSWORD CANNOT BE EMPTY", false);
                if (string.IsNullOrEmpty(txtNewPass1.Text))
                    Driver.Message("NEW PASSWORD CANNOT BE EMPTY", false);
                if (string.IsNullOrEmpty(txtNewPass2.Text))
                    Driver.Message("RE-TYPE PASSWORD CANNOT BE EMPTY", false);
                if (txtNewPass1.Text.Equals(txtNewPass2.Text) && !string.IsNullOrEmpty(txtNewPass1.Text))
                {
                    //save password
                    Driver.Message("ARE YOU SURE YOU WANT TO CHANGE PASSWORD?", true);
                    if (Driver.getAns() == "YES")
                    {
                        DBlayer.changeUserPassword(Main_Form.userId, txtOldPass.Text, txtNewPass1.Text);
                        Driver.Message("YOUR PASSWORD HAS BEEN CHANGED SUCCESFULLY \n PLEASE LOGIN AGAIN TO CONTINUE ", false);
                        this.Dispose();
                        selfManage.Dispose();
                        MainForm.Dispose();
                        
                        
                        Login.Show();
                        
                    }
                }
                else
                    Driver.Message("NEW PASSWORDS DO NOT MATCH", false);
            }
            catch (Exception exe)
            {
                Driver.Message(exe.Message, false);
            }
        
    }
    }
}
