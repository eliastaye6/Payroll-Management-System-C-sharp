using Payroll_Management_System.DB_connection;
using Payroll_Management_System.Model_Classes;
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
    public partial class Print_ID : Form
    {
        public Print_ID(Employee emp)
        {
            InitializeComponent();
            txtEmpId.Text = emp.employeeId.ToString();
            txtFullname.Text = emp.firstname + " " + emp.lastname;
            txtTel.Text = emp.telNo;
            if (emp.imageRecieve != null)
                employeePicBox.Image = Image.FromStream(emp.imageRecieve);
            try
            {
                string barCode = emp.employeeId.ToString();

                Zen.Barcode.Code39BarcodeDraw brCode =
                   Zen.Barcode.BarcodeDrawFactory.Code39WithChecksum;
                picBoxBarcode.Image = brCode.Draw(barCode, 80);

                
            }
            catch(Exception e)
            {

            }
            txtDOB.Text = DateTime.Now.Date.AddYears(1).ToString("MM/dd/yyyy");
            SortedList<int, string> ls =DBlayer.fetchAllDepartment();
            try
            {
                if (emp.depId > -1)
                    txtDepartment.Text = ls.Values[ls.IndexOfKey(emp.depId)];
                else
                    txtDepartment.Text = "UNASSIGNED";
            }catch(Exception e)
            {
                txtDepartment.Text = "UNASSIGNED";
            }
        }
       private Image id;
        private Bitmap bt;
        private void LblEmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //private void CaptureScreen()
        //{
        //    Graphics myGraphics = PrintPanel.CreateGraphics();
        //    Size s = PrintPanel.Size;
        //    memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
        //    Graphics memoryGraphics = Graphics.FromImage(memoryImage);
        //    memoryGraphics.CopyFromScreen(PrintPanel.Location.X, PrintPanel.Location.Y, 0, 0, s); ;
        //}
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            using (Graphics gfx = PrintPanel.CreateGraphics())
            {
                
                using (Bitmap bmp = new Bitmap(PrintPanel.Width, PrintPanel.Height, gfx))
                {
                    //this.Prin
                    //Graphics memoryGraphics = Graphics.FromImage(bmp);
                    //memoryGraphics.CopyFromScreen(0,0,PrintPanel.Location.X, PrintPanel.Location.Y, PrintPanel.Size); ;


                    PrintPanel.DrawToBitmap(bmp, new Rectangle(0, 0, PrintPanel.Width, PrintPanel.Height)); ;
                    bt = bmp;
                    //MemoryStream ms = new MemoryStream();
                    bmp.Save("E://NEW.JPG");
                    //id = Image.FromStream(ms);

                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        print.Print();
                    }
                }
            }
        }

        private void PicBoxBarcode_Click(object sender, EventArgs e)
        {

        }

        private void Print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bt, 0, 0);
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
