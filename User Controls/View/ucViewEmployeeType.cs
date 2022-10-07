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
    public partial class ucViewEmployeeType : UserControl
    {
        public ucViewEmployeeType()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Object o = new object();
            EventArgs e = new EventArgs();
            txtSearch_KeyUp(o, e);
        }
        private void dgvEmpTypeSearch_DoubleClick(object sender, EventArgs e)
        {
           
            //    employeePicBox.Image = Image.FromFile(@"C:\Users\ELA.T\Desktop\School\2nd year\1st semester\Windows Programming C#\assignment\Project\Image\icons8_payroll_480px.png");
            try
            {

                int empId = int.Parse(dgvEmpTypeSearch.CurrentRow.Cells[0].Value.ToString());

                EmpType emp = DBlayer.fetchEmpType(empId);
                setIntoTextBox(emp);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }
        private void setIntoTextBox(EmpType emp)
        {
            if (emp.TypeID != null)
                txtGroupId.Text = emp.TypeID.ToString();
            if (emp.TypeName != null)
                txtName.Text = emp.TypeName;
            if (emp.TypeDescription != null)
                txtDescription.Text = emp.TypeDescription;


          
        }
        private void txtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvEmpTypeSearch.DataSource = DBlayer.searchEmpType(sk);
            }
            catch (Exception ex)
            {

            }
        }

        private void UcViewEmployeeType_Load(object sender, EventArgs e)
        {

        }
    }
}
