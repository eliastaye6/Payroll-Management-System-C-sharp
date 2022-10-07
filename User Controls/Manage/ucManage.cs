using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_Management_System.User_Controls.Manage;

namespace Payroll_Management_System.User_Controls
{
    public partial class ucManage : UserControl
    {
        public ucManage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            ucGroup = new ucManageGroup();
            insidePanel.Controls.Add(ucGroup);
           
            ucEmployee = new ucManageEmployee();
            insidePanel.Controls.Add(ucEmployee);

            ucDepartment = new ucManageDepartment();
            insidePanel.Controls.Add(ucDepartment);

            ucMonthlyData = new ucManageMonthlyData();
            insidePanel.Controls.Add(ucMonthlyData);

            ucEmployeeType = new ucManageEmployeeType();
            insidePanel.Controls.Add(ucEmployeeType);

            ucOvertime = new ucManageOverTime();
            insidePanel.Controls.Add(ucOvertime);

            ucUsers = new ucManageUsers();
            insidePanel.Controls.Add(ucUsers);


            changeControls(ucEmployee);

           
          

        }
        ucManageGroup ucGroup; 
        ucManageEmployee ucEmployee;
        ucManageDepartment ucDepartment;
        ucManageMonthlyData ucMonthlyData;
        ucManageEmployeeType ucEmployeeType;
        ucManageOverTime ucOvertime;
        ucManageUsers ucUsers;
        private void changeControls(UserControl uc)
        {


            ucGroup.Visible = false;
            ucEmployee.Visible = false;
            ucDepartment.Visible = false;
            ucMonthlyData.Visible = false;
            ucEmployeeType.Visible = false;
            ucOvertime.Visible = false;
            ucUsers.Visible = false;
            uc.Visible = true;
        }
        private void BtnEmployee_Click(object sender, EventArgs e)
        {
         
        }

        private void UcManage_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            changeControls(ucEmployee);
        }

        private void InsidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            changeControls(ucDepartment);
        }

        private void BtnMonthlyData_Click(object sender, EventArgs e)
        {

            changeControls(ucMonthlyData);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            changeControls(ucGroup);
        }

        private void BtnEmployeeType_Click(object sender, EventArgs e)
        {
            changeControls(ucEmployeeType);
        }

        private void BtnOvertime_Click(object sender, EventArgs e)
        {
            changeControls(ucOvertime);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            changeControls(ucUsers);
        }
    }
}
