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

namespace Payroll_Management_System.User_Controls.View
{
    public partial class ucViewDepartment : UserControl
    {
        public ucViewDepartment()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Object o = new object();
            EventArgs e = new EventArgs();
            TxtSearch_KeyUp(o, e);
        }

        private void UcViewDepartment_Load(object sender, EventArgs e)
        {

        }
        private void setIntoDepTextBox(Department dep)
        {
            txtDepartmentId.Text = dep.depId.ToString();
            txtDepartmentName.Text = dep.depName;
            if (!string.IsNullOrWhiteSpace(dep.depDescription))
                txtDescription.Text = dep.depDescription;

        }
        private void DgvDepSearch_DoubleClick(object sender, EventArgs e)
        {
           
            try
            {

                int depId = int.Parse(dgvDepSearch.CurrentRow.Cells[0].Value.ToString());
                Department dep = DBlayer.fetchDepartment(depId);
                setIntoDepTextBox(dep);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
        private void TxtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvDepSearch.DataSource = DBlayer.searchDepartment(sk);
            }
            catch (Exception ex)
            {

            }
        }

        private void TxtSearch_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
