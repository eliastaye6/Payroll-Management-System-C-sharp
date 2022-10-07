using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PayrollReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            reports.CrystalReport1 crpt = new reports.CrystalReport1();
            crpt.SetParameterValue("@groupId", 2);
            crpt.SetParameterValue("@month", 1);
            crpt.SetParameterValue("@year", 2020);
            payrollReportViewer1.ReportSource = null;
            payrollReportViewer1.ReportSource = crpt;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            reports.CrystalReport2 crpt2 = new reports.CrystalReport2();
            crpt2.SetParameterValue("@depId", 1);
            crpt2.SetParameterValue("@month", 1);
            crpt2.SetParameterValue("@year", 2020);
            payrollReportViewer1.ReportSource = null;
            payrollReportViewer1.ReportSource = crpt2;
        }

        private void BtnEmployeesTaxCollected_Click(object sender, EventArgs e)
        {
            reports.CrystalReport3 crpt3 = new reports.CrystalReport3();
            crpt3.SetParameterValue("@depId", 1);
            crpt3.SetParameterValue("@month", 1);
            crpt3.SetParameterValue("@year", 2020);
            payrollReportViewer1.ReportSource = null;
            payrollReportViewer1.ReportSource = crpt3;
        }
    }
}
