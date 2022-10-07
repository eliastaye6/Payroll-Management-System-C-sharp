using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Payroll_Management_System.User_Controls;
using Payroll_Management_System.Model_Classes;

using Payroll_Management_System.Forms;
using Payroll_Management_System.DB_connection;
using Payroll_Management_System.Properties;
//using test;

namespace Payroll_Management_System
{
    public partial class Main_Form : Form
    {
        public static int userId;
        User user;
        public Main_Form(Form parent,User user)
        {
            this.parent = parent;
           
            InitializeComponent();
            ////setting user property below
            ///
            userPicBox.Image = Resources.icons8_payroll_480px;
            this.user = user;

            try
            {
                userPicBox.Image = Image.FromStream(user.imageRecieve);
            }
            catch(Exception e)
            {

            }
           

            lblUsername.Text = user.firstname + " " + user.lastname;
            lblRole.Text = user.Role;
            userId = user.userId;


            _start = DateTime.Now;
            timer1.Start();
        }
        private Form parent; //to close parent form when close button is pressed
        private DateTime _start;
      
        private void LblTiime_Click(object sender, EventArgs e)
        {
            
        }


      






        //code below is to make the form window movable since we dont have the title bar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //upto here

        private void changeColor(Button btn)
        {
            btnManage.BackColor = Color.FromArgb(50, 160, 250);
            btnView.BackColor = Color.FromArgb(50, 160, 250);
            btnReport.BackColor = Color.FromArgb(50, 160, 250);
            btnHelp.BackColor = Color.FromArgb(50, 160, 250);
            btnSchedule.BackColor = Color.FromArgb(50, 160, 250);
            btn.BackColor = Color.DodgerBlue;

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Form1_MouseDown(sender, e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Driver.Message("ARE YOU SURE YOU WANT TO EXIT? \n YOU WILL BE LOGGED OUT", true);
            if (Driver.getAns() == "YES")
            {
                this.Dispose();
                parent.Dispose();
            }
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        

        private void Main_Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.Form1_MouseDown(sender, e);
        }

        

        private void LblHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BtnMaximize_Click(sender, e);
        }

        private void TopPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BtnMaximize_Click(sender, e);
        }

        private void LblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            this.Form1_MouseDown(sender, e);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Form1_MouseDown(sender, e);
        }

        private void LblHeader_Click(object sender, EventArgs e)
        {

        }

        private void InfoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Form1_MouseDown(sender, e);
        }

        private void LogoPicBox_MouseDown(object sender, MouseEventArgs e)
        {

            this.Form1_MouseDown(sender, e);
        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            changeColor(btnManage);
            ucManage manage = new ucManage();
            ucPanel.Controls.Clear();
            ucPanel.Controls.Add(manage);
        }

        private void UcPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - _start;
            

            //\\:ss
            lblTime.Text = duration.ToString("hh\\:mm");
        }

       
        private void BtnView_Click(object sender, EventArgs e)
        {
            changeColor(btnView);
            ucView view = new ucView();
            ucPanel.Controls.Clear();
            ucPanel.Controls.Add(view);
        }

        private void UserPicBox_Click(object sender, EventArgs e)
        {
            using (userSelfManage uc = new userSelfManage(parent, this, user))
            {
                
                uc.ShowDialog();
            }
            userPicBox.Image = Driver.image;

        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            bool status = DBlayer.checkConnection();
            if (status == false)
            {

                btnConnection.Text = "Disconnected";
                btnConnection.ForeColor = Color.Red;
                btnConnection.Image = Resources.icons8_sad_cloud_32px;
                Driver.Message("DISCONNECTED", false);
            }
            else if (status == true)
            {
                btnConnection.ForeColor = Color.Lime;
                btnConnection.Text = "Connected";
                btnConnection.Image = Resources.icons8_happy_cloud_32px_1; 
                Driver.Message("CONNECTED", false);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            changeColor(btnSchedule);
            ucScheduleOvertime schedule = new ucScheduleOvertime();
            ucPanel.Controls.Clear();
            ucPanel.Controls.Add(schedule);

        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            changeColor(btnHelp);
            ucHelp help= new ucHelp();
            ucPanel.Controls.Clear();
            ucPanel.Controls.Add(help);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            changeColor(btnReport);
          // Form1 report = new Form1();
            ucPanel.Controls.Clear();
            
        }
    }
}
