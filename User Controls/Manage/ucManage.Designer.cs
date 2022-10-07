namespace Payroll_Management_System.User_Controls
{
    partial class ucManage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManage));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnOvertime = new System.Windows.Forms.Button();
            this.btnEmployeeType = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnMonthlyData = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.insidePanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.topPanel.Controls.Add(this.btnUsers);
            this.topPanel.Controls.Add(this.btnOvertime);
            this.topPanel.Controls.Add(this.btnEmployeeType);
            this.topPanel.Controls.Add(this.btnDepartment);
            this.topPanel.Controls.Add(this.btnGroup);
            this.topPanel.Controls.Add(this.btnMonthlyData);
            this.topPanel.Controls.Add(this.btnEmployee);
            this.topPanel.Location = new System.Drawing.Point(38, 23);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(910, 32);
            this.topPanel.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSize = true;
            this.btnUsers.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(794, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(128, 32);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnOvertime
            // 
            this.btnOvertime.AutoSize = true;
            this.btnOvertime.BackColor = System.Drawing.Color.DimGray;
            this.btnOvertime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOvertime.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOvertime.FlatAppearance.BorderSize = 0;
            this.btnOvertime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnOvertime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOvertime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOvertime.ForeColor = System.Drawing.Color.White;
            this.btnOvertime.Image = ((System.Drawing.Image)(resources.GetObject("btnOvertime.Image")));
            this.btnOvertime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOvertime.Location = new System.Drawing.Point(671, 0);
            this.btnOvertime.Name = "btnOvertime";
            this.btnOvertime.Size = new System.Drawing.Size(123, 32);
            this.btnOvertime.TabIndex = 6;
            this.btnOvertime.Text = "Overtime";
            this.btnOvertime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOvertime.UseVisualStyleBackColor = false;
            this.btnOvertime.Click += new System.EventHandler(this.BtnOvertime_Click);
            // 
            // btnEmployeeType
            // 
            this.btnEmployeeType.AutoSize = true;
            this.btnEmployeeType.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEmployeeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeType.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployeeType.FlatAppearance.BorderSize = 0;
            this.btnEmployeeType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEmployeeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeType.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeType.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeType.Image")));
            this.btnEmployeeType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeType.Location = new System.Drawing.Point(506, 0);
            this.btnEmployeeType.Name = "btnEmployeeType";
            this.btnEmployeeType.Size = new System.Drawing.Size(165, 32);
            this.btnEmployeeType.TabIndex = 5;
            this.btnEmployeeType.Text = "Employee Type";
            this.btnEmployeeType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployeeType.UseVisualStyleBackColor = false;
            this.btnEmployeeType.Click += new System.EventHandler(this.BtnEmployeeType_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.AutoSize = true;
            this.btnDepartment.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartment.Image")));
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.Location = new System.Drawing.Point(366, 0);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(140, 32);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.BtnDepartment_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.AutoSize = true;
            this.btnGroup.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.ForeColor = System.Drawing.Color.White;
            this.btnGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnGroup.Image")));
            this.btnGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroup.Location = new System.Drawing.Point(267, 0);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(99, 32);
            this.btnGroup.TabIndex = 3;
            this.btnGroup.Text = "Group";
            this.btnGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnMonthlyData
            // 
            this.btnMonthlyData.AutoSize = true;
            this.btnMonthlyData.BackColor = System.Drawing.Color.DarkViolet;
            this.btnMonthlyData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlyData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMonthlyData.FlatAppearance.BorderSize = 0;
            this.btnMonthlyData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnMonthlyData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyData.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyData.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthlyData.Image")));
            this.btnMonthlyData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthlyData.Location = new System.Drawing.Point(120, 0);
            this.btnMonthlyData.Name = "btnMonthlyData";
            this.btnMonthlyData.Size = new System.Drawing.Size(147, 32);
            this.btnMonthlyData.TabIndex = 2;
            this.btnMonthlyData.Text = "Monthly Data";
            this.btnMonthlyData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonthlyData.UseVisualStyleBackColor = false;
            this.btnMonthlyData.Click += new System.EventHandler(this.BtnMonthlyData_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Chocolate;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(120, 32);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.Button1_Click);
            // 
            // insidePanel
            // 
            this.insidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insidePanel.AutoSize = true;
            this.insidePanel.Location = new System.Drawing.Point(38, 62);
            this.insidePanel.Name = "insidePanel";
            this.insidePanel.Size = new System.Drawing.Size(910, 481);
            this.insidePanel.TabIndex = 1;
            this.insidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InsidePanel_Paint);
            // 
            // ucManage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.insidePanel);
            this.Controls.Add(this.topPanel);
            this.Name = "ucManage";
            this.Size = new System.Drawing.Size(984, 561);
            this.Load += new System.EventHandler(this.UcManage_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel insidePanel;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnOvertime;
        private System.Windows.Forms.Button btnEmployeeType;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnMonthlyData;
    }
}
