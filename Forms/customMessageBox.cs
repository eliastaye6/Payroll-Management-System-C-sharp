using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms
{
    public partial class customMessageBox : Form
    {
        public static string ans = "NO";       
        public customMessageBox(string Message,bool controls)
        {
            InitializeComponent();
           lblInfo.Text = Message;
            if (controls == false)
            {
                btnNo.Visible = false;
                btnYes.Visible = false;
            }
            else
            {
                btnOk.Visible = false;
            }

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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void LblInfo_Click(object sender, EventArgs e)
        {

        }

        private void LblInfo_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown(sender, e);
        }

        private void CustomMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown(sender, e);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown(sender, e);
        }

        private  void BtnNo_Click(object sender, EventArgs e)
        {
            ans="NO";
            this.Dispose();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            ans = "YES";
            this.Dispose();
        }
    }
}
