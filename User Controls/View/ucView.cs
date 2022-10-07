using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_Management_System.User_Controls.View;

namespace Payroll_Management_System.User_Controls
{
    public partial class ucView : UserControl
    {
        public ucView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            ucGroup = new ucViewGroup();
            insidePanel.Controls.Add(ucGroup);

            ucDepartment = new ucViewDepartment();
            insidePanel.Controls.Add(ucDepartment);
            ucEmployeeData = new ucViewEmployeeData();
            insidePanel.Controls.Add(ucEmployeeData);
            ucOvertime = new ucViewOvertime();
            insidePanel.Controls.Add(ucOvertime);
            ucEmployeeType = new ucViewEmployeeType();
            insidePanel.Controls.Add(ucEmployeeType);
            changeControls(ucEmployeeData);

        }
        ucViewGroup ucGroup;
        ucViewDepartment ucDepartment;
        ucViewEmployeeData ucEmployeeData;
        ucViewEmployeeType ucEmployeeType;
        ucViewOvertime ucOvertime;
        private void changeControls(UserControl uc)
        {


            ucGroup.Visible = false;
            ucEmployeeData.Visible = false;
            ucDepartment.Visible = false;
           
            ucEmployeeType.Visible = false;
            ucOvertime.Visible = false;
         
            uc.Visible = true;
        }
        private void UcView_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            changeControls(ucEmployeeData);
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            changeControls(ucDepartment);
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
    }
}
