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
using Payroll_Management_System.DB_connection;
using Payroll_Management_System.Model_Classes;
using System.Data.SqlClient;
using Payroll_Management_System.Forms;

namespace Payroll_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
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

     

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Form1_MouseDown(sender, e);
            //this.Location = new Point(Cursor.Position.X , Cursor.Position.Y);
            //Point newLoc = new Point(e.X + this.Location.X, e.Y + this.Location.Y);
            //this.Location = newLoc;
            //this.Location = new Point(this.Location.X - (this.Location.X - e.X), this.Location.Y - (this.Location.Y - e.Y));


        }

       

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Form1_MouseDown(sender,e);
        }

        private void BunifuCustomLabel4_MouseDown(object sender, MouseEventArgs e)
        {
            this.Form1_MouseDown(sender, e);
        }

        private void TxtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    User user = DBlayer.userLogin(username, password);

                    if (user != null)
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtUsername.Focus();
                        this.Hide();
                        Main_Form mf = new Main_Form(this, user);
                        mf.Show();
                    }
                    else
                    {
                        
                        Driver.Message("INCORRECT USERNAME OR PASSWORD \n TRY AGAIN", false);
                    }
                }
                else
                {
                    Driver.Message("USERNAME OR PASSWORD CANNOT BE EMPTY \n TRY AGAIN", false);
                    
                }
            }
            catch(SqlException sq)
            {
                Driver.Message("CONNECTION CANNOT BE ESTABLISHED \n TRY AGAIN LATER", false);
            }
            catch (Exception eee)
            {
                Driver.Message(eee.Message, false);
            }
            //User user = new User();
            //    this.Hide();
            //    Main_Form mf = new Main_Form(this, user);
            //    mf.Show();











            }

        private void Panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void TopPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                BtnLogin_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                BtnLogin_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            using(ATTENDANCE a=new ATTENDANCE())
            {
                a.ShowDialog();
            }
        }
    }
    
}
