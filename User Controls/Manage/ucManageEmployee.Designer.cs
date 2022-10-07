namespace Payroll_Management_System.User_Controls
{
    partial class ucManageEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvEmpSearch = new System.Windows.Forms.DataGridView();
            this.viewEmpPanel = new System.Windows.Forms.Panel();
            this.lblSexInfo = new System.Windows.Forms.Label();
            this.lblLNinfo = new System.Windows.Forms.Label();
            this.lblFNinfo = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboEmployeeType = new System.Windows.Forms.ComboBox();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.dateTimeDOE = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.sexGroupBox = new System.Windows.Forms.GroupBox();
            this.lblSalaryInfo = new System.Windows.Forms.Label();
            this.radbtnFemale = new System.Windows.Forms.RadioButton();
            this.radbtnMale = new System.Windows.Forms.RadioButton();
            this.txtEmergency = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSalary = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblDOE = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.picBoxBarcode = new System.Windows.Forms.PictureBox();
            this.employeePicBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.bottomButtonPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpSearch)).BeginInit();
            this.viewEmpPanel.SuspendLayout();
            this.sexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicBox)).BeginInit();
            this.bottomButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(211, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 32);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.PicBoxBarcode_Click);
            this.txtSearch.KeyUp += new System.EventHandler(this.TxtSearch_KeyUp);
            // 
            // dgvEmpSearch
            // 
            this.dgvEmpSearch.AllowUserToAddRows = false;
            this.dgvEmpSearch.AllowUserToDeleteRows = false;
            this.dgvEmpSearch.AllowUserToOrderColumns = true;
            this.dgvEmpSearch.AllowUserToResizeColumns = false;
            this.dgvEmpSearch.AllowUserToResizeRows = false;
            this.dgvEmpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvEmpSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEmpSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpSearch.GridColor = System.Drawing.Color.White;
            this.dgvEmpSearch.Location = new System.Drawing.Point(0, 39);
            this.dgvEmpSearch.MultiSelect = false;
            this.dgvEmpSearch.Name = "dgvEmpSearch";
            this.dgvEmpSearch.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpSearch.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmpSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpSearch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEmpSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvEmpSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvEmpSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvEmpSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmpSearch.RowTemplate.ReadOnly = true;
            this.dgvEmpSearch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpSearch.ShowEditingIcon = false;
            this.dgvEmpSearch.Size = new System.Drawing.Size(424, 442);
            this.dgvEmpSearch.TabIndex = 6;
            this.dgvEmpSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpSearch_CellContentClick);
            this.dgvEmpSearch.DoubleClick += new System.EventHandler(this.DgvEmpSearch_DoubleClick);
            // 
            // viewEmpPanel
            // 
            this.viewEmpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewEmpPanel.AutoScroll = true;
            this.viewEmpPanel.AutoScrollMargin = new System.Drawing.Size(5, 40);
            this.viewEmpPanel.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.viewEmpPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.viewEmpPanel.Controls.Add(this.lblSexInfo);
            this.viewEmpPanel.Controls.Add(this.lblLNinfo);
            this.viewEmpPanel.Controls.Add(this.lblFNinfo);
            this.viewEmpPanel.Controls.Add(this.lblEmpId);
            this.viewEmpPanel.Controls.Add(this.comboGroup);
            this.viewEmpPanel.Controls.Add(this.comboEmployeeType);
            this.viewEmpPanel.Controls.Add(this.comboDepartment);
            this.viewEmpPanel.Controls.Add(this.dateTimeDOE);
            this.viewEmpPanel.Controls.Add(this.dateTimeDOB);
            this.viewEmpPanel.Controls.Add(this.lblEmployeeID);
            this.viewEmpPanel.Controls.Add(this.sexGroupBox);
            this.viewEmpPanel.Controls.Add(this.txtEmergency);
            this.viewEmpPanel.Controls.Add(this.txtTel);
            this.viewEmpPanel.Controls.Add(this.txtSalary);
            this.viewEmpPanel.Controls.Add(this.txtLastName);
            this.viewEmpPanel.Controls.Add(this.lblEmergency);
            this.viewEmpPanel.Controls.Add(this.lblTel);
            this.viewEmpPanel.Controls.Add(this.lblGroup);
            this.viewEmpPanel.Controls.Add(this.txtFirstName);
            this.viewEmpPanel.Controls.Add(this.lblSex);
            this.viewEmpPanel.Controls.Add(this.lblEmployeeType);
            this.viewEmpPanel.Controls.Add(this.lblFirstName);
            this.viewEmpPanel.Controls.Add(this.lblDepartment);
            this.viewEmpPanel.Controls.Add(this.lblLastName);
            this.viewEmpPanel.Controls.Add(this.lblDOB);
            this.viewEmpPanel.Controls.Add(this.lblDOE);
            this.viewEmpPanel.Controls.Add(this.lblSalary);
            this.viewEmpPanel.Controls.Add(this.picBoxBarcode);
            this.viewEmpPanel.Controls.Add(this.employeePicBox);
            this.viewEmpPanel.Location = new System.Drawing.Point(447, 0);
            this.viewEmpPanel.Name = "viewEmpPanel";
            this.viewEmpPanel.Size = new System.Drawing.Size(463, 441);
            this.viewEmpPanel.TabIndex = 7;
            // 
            // lblSexInfo
            // 
            this.lblSexInfo.AutoSize = true;
            this.lblSexInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexInfo.ForeColor = System.Drawing.Color.Red;
            this.lblSexInfo.Location = new System.Drawing.Point(200, 329);
            this.lblSexInfo.Name = "lblSexInfo";
            this.lblSexInfo.Size = new System.Drawing.Size(119, 15);
            this.lblSexInfo.TabIndex = 50;
            this.lblSexInfo.Text = "Sex cannot be empty";
            this.lblSexInfo.Visible = false;
            // 
            // lblLNinfo
            // 
            this.lblLNinfo.AutoSize = true;
            this.lblLNinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNinfo.ForeColor = System.Drawing.Color.Red;
            this.lblLNinfo.Location = new System.Drawing.Point(197, 282);
            this.lblLNinfo.Name = "lblLNinfo";
            this.lblLNinfo.Size = new System.Drawing.Size(153, 15);
            this.lblLNinfo.TabIndex = 49;
            this.lblLNinfo.Text = "Last name cannot be empty";
            this.lblLNinfo.Visible = false;
            // 
            // lblFNinfo
            // 
            this.lblFNinfo.AutoSize = true;
            this.lblFNinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNinfo.ForeColor = System.Drawing.Color.Red;
            this.lblFNinfo.Location = new System.Drawing.Point(197, 232);
            this.lblFNinfo.Name = "lblFNinfo";
            this.lblFNinfo.Size = new System.Drawing.Size(154, 15);
            this.lblFNinfo.TabIndex = 48;
            this.lblFNinfo.Text = "First name cannot be empty";
            this.lblFNinfo.Visible = false;
            // 
            // lblEmpId
            // 
            this.lblEmpId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmpId.Location = new System.Drawing.Point(191, 206);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(0, 18);
            this.lblEmpId.TabIndex = 47;
            // 
            // comboGroup
            // 
            this.comboGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.comboGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(194, 621);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(227, 24);
            this.comboGroup.TabIndex = 46;
            // 
            // comboEmployeeType
            // 
            this.comboEmployeeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEmployeeType.BackColor = System.Drawing.Color.Gainsboro;
            this.comboEmployeeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboEmployeeType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmployeeType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboEmployeeType.FormattingEnabled = true;
            this.comboEmployeeType.Location = new System.Drawing.Point(194, 574);
            this.comboEmployeeType.Name = "comboEmployeeType";
            this.comboEmployeeType.Size = new System.Drawing.Size(227, 24);
            this.comboEmployeeType.TabIndex = 45;
            // 
            // comboDepartment
            // 
            this.comboDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDepartment.BackColor = System.Drawing.Color.Gainsboro;
            this.comboDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(194, 532);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(227, 24);
            this.comboDepartment.TabIndex = 44;
            // 
            // dateTimeDOE
            // 
            this.dateTimeDOE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDOE.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimeDOE.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dateTimeDOE.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dateTimeDOE.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimeDOE.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimeDOE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeDOE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDOE.Location = new System.Drawing.Point(194, 483);
            this.dateTimeDOE.Name = "dateTimeDOE";
            this.dateTimeDOE.Size = new System.Drawing.Size(227, 23);
            this.dateTimeDOE.TabIndex = 43;
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDOB.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimeDOB.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dateTimeDOB.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dateTimeDOB.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimeDOB.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimeDOB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeDOB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDOB.Location = new System.Drawing.Point(194, 437);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(227, 23);
            this.dateTimeDOB.TabIndex = 42;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployeeID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployeeID.Location = new System.Drawing.Point(34, 206);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(102, 18);
            this.lblEmployeeID.TabIndex = 40;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // sexGroupBox
            // 
            this.sexGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sexGroupBox.Controls.Add(this.lblSalaryInfo);
            this.sexGroupBox.Controls.Add(this.radbtnFemale);
            this.sexGroupBox.Controls.Add(this.radbtnMale);
            this.sexGroupBox.Location = new System.Drawing.Point(194, 343);
            this.sexGroupBox.Name = "sexGroupBox";
            this.sexGroupBox.Size = new System.Drawing.Size(279, 39);
            this.sexGroupBox.TabIndex = 39;
            this.sexGroupBox.TabStop = false;
            // 
            // lblSalaryInfo
            // 
            this.lblSalaryInfo.AutoSize = true;
            this.lblSalaryInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryInfo.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryInfo.Location = new System.Drawing.Point(6, 21);
            this.lblSalaryInfo.Name = "lblSalaryInfo";
            this.lblSalaryInfo.Size = new System.Drawing.Size(196, 15);
            this.lblSalaryInfo.TabIndex = 51;
            this.lblSalaryInfo.Text = "Only numbers are allowed in salary";
            this.lblSalaryInfo.Visible = false;
            // 
            // radbtnFemale
            // 
            this.radbtnFemale.AutoSize = true;
            this.radbtnFemale.BackColor = System.Drawing.Color.Gainsboro;
            this.radbtnFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radbtnFemale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnFemale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radbtnFemale.Location = new System.Drawing.Point(97, 0);
            this.radbtnFemale.Name = "radbtnFemale";
            this.radbtnFemale.Size = new System.Drawing.Size(80, 22);
            this.radbtnFemale.TabIndex = 1;
            this.radbtnFemale.TabStop = true;
            this.radbtnFemale.Text = "Female";
            this.radbtnFemale.UseVisualStyleBackColor = false;
            // 
            // radbtnMale
            // 
            this.radbtnMale.AutoSize = true;
            this.radbtnMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radbtnMale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnMale.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radbtnMale.Location = new System.Drawing.Point(6, 0);
            this.radbtnMale.Name = "radbtnMale";
            this.radbtnMale.Size = new System.Drawing.Size(63, 22);
            this.radbtnMale.TabIndex = 0;
            this.radbtnMale.TabStop = true;
            this.radbtnMale.Text = "Male";
            this.radbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtEmergency
            // 
            this.txtEmergency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmergency.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEmergency.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtEmergency.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtEmergency.BorderThickness = 1;
            this.txtEmergency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmergency.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmergency.isPassword = false;
            this.txtEmergency.Location = new System.Drawing.Point(194, 720);
            this.txtEmergency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmergency.Name = "txtEmergency";
            this.txtEmergency.Size = new System.Drawing.Size(227, 27);
            this.txtEmergency.TabIndex = 38;
            this.txtEmergency.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTel.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtTel.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtTel.BorderThickness = 1;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTel.isPassword = false;
            this.txtTel.Location = new System.Drawing.Point(194, 667);
            this.txtTel.Margin = new System.Windows.Forms.Padding(5);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(227, 25);
            this.txtTel.TabIndex = 37;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSalary.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtSalary.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtSalary.BorderThickness = 1;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSalary.isPassword = false;
            this.txtSalary.Location = new System.Drawing.Point(194, 390);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(5);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(209, 25);
            this.txtSalary.TabIndex = 36;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLastName.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtLastName.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtLastName.BorderThickness = 1;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.isPassword = false;
            this.txtLastName.Location = new System.Drawing.Point(194, 299);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(227, 25);
            this.txtLastName.TabIndex = 35;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblEmergency
            // 
            this.lblEmergency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmergency.AutoSize = true;
            this.lblEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmergency.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergency.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmergency.Location = new System.Drawing.Point(34, 720);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(156, 18);
            this.lblEmergency.TabIndex = 33;
            this.lblEmergency.Text = "Emergency Contact";
            // 
            // lblTel
            // 
            this.lblTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTel.AutoSize = true;
            this.lblTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTel.Location = new System.Drawing.Point(34, 674);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(57, 18);
            this.lblTel.TabIndex = 32;
            this.lblTel.Text = "Tel No.";
            // 
            // lblGroup
            // 
            this.lblGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroup.AutoSize = true;
            this.lblGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGroup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGroup.Location = new System.Drawing.Point(34, 627);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(55, 18);
            this.lblGroup.TabIndex = 31;
            this.lblGroup.Text = "Group";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFirstName.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtFirstName.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtFirstName.BorderThickness = 1;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.isPassword = false;
            this.txtFirstName.Location = new System.Drawing.Point(194, 252);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(227, 25);
            this.txtFirstName.TabIndex = 30;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblSex
            // 
            this.lblSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSex.Location = new System.Drawing.Point(34, 343);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(34, 18);
            this.lblSex.TabIndex = 24;
            this.lblSex.Text = "Sex";
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployeeType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployeeType.Location = new System.Drawing.Point(34, 580);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(122, 18);
            this.lblEmployeeType.TabIndex = 29;
            this.lblEmployeeType.Text = "Employee Type";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFirstName.Location = new System.Drawing.Point(34, 252);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 18);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDepartment.Location = new System.Drawing.Point(34, 531);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(95, 18);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Department";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLastName.Location = new System.Drawing.Point(32, 297);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 18);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOB.AutoSize = true;
            this.lblDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDOB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDOB.Location = new System.Drawing.Point(34, 437);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(96, 18);
            this.lblDOB.TabIndex = 26;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblDOE
            // 
            this.lblDOE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOE.AutoSize = true;
            this.lblDOE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDOE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOE.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDOE.Location = new System.Drawing.Point(32, 483);
            this.lblDOE.Name = "lblDOE";
            this.lblDOE.Size = new System.Drawing.Size(157, 18);
            this.lblDOE.TabIndex = 27;
            this.lblDOE.Text = "Date of Employment";
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalary.AutoSize = true;
            this.lblSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSalary.Location = new System.Drawing.Point(34, 390);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(97, 18);
            this.lblSalary.TabIndex = 25;
            this.lblSalary.Text = "Basic Salary";
            // 
            // picBoxBarcode
            // 
            this.picBoxBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBoxBarcode.BackColor = System.Drawing.Color.White;
            this.picBoxBarcode.ErrorImage = null;
            this.picBoxBarcode.ImageLocation = "middle";
            this.picBoxBarcode.InitialImage = null;
            this.picBoxBarcode.Location = new System.Drawing.Point(121, 163);
            this.picBoxBarcode.Name = "picBoxBarcode";
            this.picBoxBarcode.Size = new System.Drawing.Size(240, 25);
            this.picBoxBarcode.TabIndex = 6;
            this.picBoxBarcode.TabStop = false;
            this.picBoxBarcode.Click += new System.EventHandler(this.PicBoxBarcode_Click);
            // 
            // employeePicBox
            // 
            this.employeePicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeePicBox.BackColor = System.Drawing.Color.Gainsboro;
            this.employeePicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeePicBox.Image = ((System.Drawing.Image)(resources.GetObject("employeePicBox.Image")));
            this.employeePicBox.ImageActive = null;
            this.employeePicBox.Location = new System.Drawing.Point(165, 14);
            this.employeePicBox.Name = "employeePicBox";
            this.employeePicBox.Size = new System.Drawing.Size(162, 143);
            this.employeePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeePicBox.TabIndex = 4;
            this.employeePicBox.TabStop = false;
            this.employeePicBox.Zoom = 10;
            this.employeePicBox.Click += new System.EventHandler(this.EmployeePicBox_Click);
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bottomButtonPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomButtonPanel.Controls.Add(this.btnDelete);
            this.bottomButtonPanel.Controls.Add(this.btnPrint);
            this.bottomButtonPanel.Controls.Add(this.btnClear);
            this.bottomButtonPanel.Controls.Add(this.btnSave);
            this.bottomButtonPanel.Location = new System.Drawing.Point(447, 447);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.Size = new System.Drawing.Size(446, 34);
            this.bottomButtonPanel.TabIndex = 43;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(332, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(229, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 34);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(120, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(11, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ucManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.bottomButtonPanel);
            this.Controls.Add(this.viewEmpPanel);
            this.Controls.Add(this.dgvEmpSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Name = "ucManageEmployee";
            this.Size = new System.Drawing.Size(910, 481);
            this.Load += new System.EventHandler(this.UcManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpSearch)).EndInit();
            this.viewEmpPanel.ResumeLayout(false);
            this.viewEmpPanel.PerformLayout();
            this.sexGroupBox.ResumeLayout(false);
            this.sexGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicBox)).EndInit();
            this.bottomButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.DataGridView dgvEmpSearch;
        private System.Windows.Forms.Panel viewEmpPanel;
        private Bunifu.Framework.UI.BunifuImageButton employeePicBox;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblEmployeeType;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblDOE;
        private System.Windows.Forms.Label lblSalary;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFirstName;
        private System.Windows.Forms.Label lblEmergency;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.GroupBox sexGroupBox;
        private System.Windows.Forms.RadioButton radbtnFemale;
        private System.Windows.Forms.RadioButton radbtnMale;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmergency;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTel;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSalary;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLastName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Panel bottomButtonPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboEmployeeType;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.DateTimePicker dateTimeDOE;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblSexInfo;
        private System.Windows.Forms.Label lblLNinfo;
        private System.Windows.Forms.Label lblFNinfo;
        private System.Windows.Forms.Label lblSalaryInfo;
        protected System.Windows.Forms.PictureBox picBoxBarcode;
    }
}
