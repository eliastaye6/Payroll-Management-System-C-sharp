using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.user_control.usReport
{
    public partial class PayrollReport : UserControl
    {
        public PayrollReport()
        {
            InitializeComponent();
        }
        SortedList<int, string> lsDepartment;
    private void loadIntoCombo()
        {
         //   Dblayer
        }
        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnIncomeTax_Click(object sender, EventArgs e)
        {
            reports.CrystalReport3 crpt3 = new reports.CrystalReport3();
            crpt3.SetParameterValue("@depId", 1);
            crpt3.SetParameterValue("@month", 1);
            crpt3.SetParameterValue("@year", 2020);
            crystalReportViewer.ReportSource = null;
            crystalReportViewer.ReportSource = crpt3;
        }

        private void BtnDepSummary_Click(object sender, EventArgs e)
        {
            reports.CrystalReport3 crpt3 = new reports.CrystalReport3();
            crpt3.SetParameterValue("@depId", 1);
            crpt3.SetParameterValue("@month", 1);
            crpt3.SetParameterValue("@year", 2020);
            crystalReportViewer.ReportSource = null;
            crystalReportViewer.ReportSource = crpt3;
        }

        private void BtnPayroll_Click(object sender, EventArgs e)
        {
            reports.CrystalReport1 crpt = new reports.CrystalReport1();
            crpt.SetParameterValue("@groupId", 2);
            crpt.SetParameterValue("@month", 1);
            crpt.SetParameterValue("@year", 2020);
            crystalReportViewer.ReportSource = null;
            crystalReportViewer.ReportSource = crpt;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CrystalReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
