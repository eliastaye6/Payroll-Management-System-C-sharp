using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCrystalReportsForm
{
    public partial class CrystalReportForm : Form
    {
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp= fetchEmployee(int.Parse(txtEmployeeID.Text))
            DataTable employeeIdCard = new DataTable();
            employeeIdCard.Columns.Add("empId", typeof(string));
            employeeIdCard.Columns.Add("empName", typeof(string));
            employeeIdCard.Columns.Add("empImage", typeof(System.Byte[]));
            employeeIdCard.Columns.Add("telNo", typeof(string));
            employeeIdCard.Columns.Add("emergencyContact", typeof(string));
            employeeIdCard.Columns.Add("expirationDate", typeof(string));
            employeeIdCard.Columns.Add("empBarcode", typeof(System.Byte[]));
            byte[] empImage = (byte[])userPicBox.//dgvUser.CurrentRow.Cells[6].Value;
            byte[] barcode = (byte[])PicBoxBarcode.//dgvUser.CurrentRow.Cells[6].Value;
           //populating the data table
            employeeIdCard.Rows.Add(txtEmployeeID.Text, lblFullName.Text, empImage,emp.telNo,
                emp.emergencyNo, DateTime.Now.AddYears(2).ToString(), barcode);

            IdGenerator.CrystalReport.crptEmployeeIdCard crpt = new IdGenerator.CrystalReport.crptEmployeeIdCard();
            crpt.Database.Tables["Employee"].SetDataSource(employeeIdCard);
            //initializing the crystal report viewer with our crystal report crpt
            crvEmployeeIdCard.ReportSource = null;
            crvEmployeeIdCard.ReportSource = crpt;
        }
    }
}
