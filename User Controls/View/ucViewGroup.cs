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
    public partial class ucViewGroup : UserControl
    {
        public ucViewGroup()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            object o = new object();
            EventArgs e = new EventArgs();
            TxtSearch_KeyUp(o, e);
        }

        private void UcViewGroup_Load(object sender, EventArgs e)
        {

        }
        private void DgvGroupSearch_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                int groupId = int.Parse(dgvGroupSearch.CurrentRow.Cells[0].Value.ToString());
                Groups group = DBlayer.fetchGroup(groupId);
                setIntoGroupTextBox(group);

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
        private void setIntoGroupTextBox(Groups group)
        {
            txtGroupId.Text = group.groupId.ToString();
            txtGroupName.Text = group.groupName;
            if (!string.IsNullOrWhiteSpace(group.groupDescription))
                txtGroupDescription.Text = group.groupDescription;

        }
        private void TxtSearch_KeyUp(object sender, EventArgs e)
        {
            try
            {
                string sk = txtSearch.text;
                dgvGroupSearch.DataSource = DBlayer.searchGroup(sk);
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
