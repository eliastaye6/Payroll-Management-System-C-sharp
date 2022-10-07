namespace Payroll_Management_System.User_Controls.Manage
{
    partial class ucManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageUsers));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.viewEmpPanel = new System.Windows.Forms.Panel();
            this.lblRinfo = new System.Windows.Forms.Label();
            this.lblPWinfo = new System.Windows.Forms.Label();
            this.lblUNinfo = new System.Windows.Forms.Label();
            this.lblLNinfo = new System.Windows.Forms.Label();
            this.lblFNinfo = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.bottomButtonPanel = new System.Windows.Forms.Panel();
            this.dgvUserSearch = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.userPicBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.viewEmpPanel.SuspendLayout();
            this.bottomButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsername.Location = new System.Drawing.Point(34, 352);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 18);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.LblUsername_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLastName.Location = new System.Drawing.Point(34, 306);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 18);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.LblLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFirstName.Location = new System.Drawing.Point(34, 259);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 18);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.LblFirstName_Click);
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
            this.txtFirstName.Size = new System.Drawing.Size(210, 25);
            this.txtFirstName.TabIndex = 30;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.OnValueChanged += new System.EventHandler(this.TxtFirstName_OnValueChanged);
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
            this.txtLastName.Size = new System.Drawing.Size(210, 25);
            this.txtLastName.TabIndex = 35;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.OnValueChanged += new System.EventHandler(this.TxtLastName_OnValueChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUserName.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtUserName.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtUserName.BorderThickness = 1;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.isPassword = false;
            this.txtUserName.Location = new System.Drawing.Point(194, 345);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(210, 25);
            this.txtUserName.TabIndex = 36;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserName.OnValueChanged += new System.EventHandler(this.TxtUserName_OnValueChanged);
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserID.AutoSize = true;
            this.lblUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUserID.Location = new System.Drawing.Point(34, 217);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(58, 18);
            this.lblUserID.TabIndex = 40;
            this.lblUserID.Text = "User ID";
            this.lblUserID.Click += new System.EventHandler(this.LblUserID_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPassword.Location = new System.Drawing.Point(34, 399);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 18);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.LblPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPassword.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(195, 392);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 25);
            this.txtPassword.TabIndex = 48;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.TxtPassword_OnValueChanged);
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
            this.viewEmpPanel.Controls.Add(this.lblRinfo);
            this.viewEmpPanel.Controls.Add(this.lblPWinfo);
            this.viewEmpPanel.Controls.Add(this.lblUNinfo);
            this.viewEmpPanel.Controls.Add(this.lblLNinfo);
            this.viewEmpPanel.Controls.Add(this.lblFNinfo);
            this.viewEmpPanel.Controls.Add(this.txtUserID);
            this.viewEmpPanel.Controls.Add(this.comboRole);
            this.viewEmpPanel.Controls.Add(this.lblRole);
            this.viewEmpPanel.Controls.Add(this.txtPassword);
            this.viewEmpPanel.Controls.Add(this.lblPassword);
            this.viewEmpPanel.Controls.Add(this.lblUserID);
            this.viewEmpPanel.Controls.Add(this.txtUserName);
            this.viewEmpPanel.Controls.Add(this.txtLastName);
            this.viewEmpPanel.Controls.Add(this.txtFirstName);
            this.viewEmpPanel.Controls.Add(this.lblFirstName);
            this.viewEmpPanel.Controls.Add(this.lblLastName);
            this.viewEmpPanel.Controls.Add(this.lblUsername);
            this.viewEmpPanel.Controls.Add(this.userPicBox);
            this.viewEmpPanel.Location = new System.Drawing.Point(447, 0);
            this.viewEmpPanel.Name = "viewEmpPanel";
            this.viewEmpPanel.Size = new System.Drawing.Size(463, 441);
            this.viewEmpPanel.TabIndex = 47;
            this.viewEmpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewEmpPanel_Paint);
            // 
            // lblRinfo
            // 
            this.lblRinfo.AutoSize = true;
            this.lblRinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRinfo.ForeColor = System.Drawing.Color.Red;
            this.lblRinfo.Location = new System.Drawing.Point(192, 418);
            this.lblRinfo.Name = "lblRinfo";
            this.lblRinfo.Size = new System.Drawing.Size(124, 15);
            this.lblRinfo.TabIndex = 56;
            this.lblRinfo.Text = "Role cannot be empty";
            this.lblRinfo.Visible = false;
            this.lblRinfo.Click += new System.EventHandler(this.LblRinfo_Click);
            // 
            // lblPWinfo
            // 
            this.lblPWinfo.AutoSize = true;
            this.lblPWinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWinfo.ForeColor = System.Drawing.Color.Red;
            this.lblPWinfo.Location = new System.Drawing.Point(192, 372);
            this.lblPWinfo.Name = "lblPWinfo";
            this.lblPWinfo.Size = new System.Drawing.Size(151, 15);
            this.lblPWinfo.TabIndex = 55;
            this.lblPWinfo.Text = "Password cannot be empty";
            this.lblPWinfo.Visible = false;
            this.lblPWinfo.Click += new System.EventHandler(this.LblPWinfo_Click);
            // 
            // lblUNinfo
            // 
            this.lblUNinfo.AutoSize = true;
            this.lblUNinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUNinfo.ForeColor = System.Drawing.Color.Red;
            this.lblUNinfo.Location = new System.Drawing.Point(192, 325);
            this.lblUNinfo.Name = "lblUNinfo";
            this.lblUNinfo.Size = new System.Drawing.Size(156, 15);
            this.lblUNinfo.TabIndex = 54;
            this.lblUNinfo.Text = "User name cannot be empty";
            this.lblUNinfo.Visible = false;
            this.lblUNinfo.Click += new System.EventHandler(this.LblUNinfo_Click);
            // 
            // lblLNinfo
            // 
            this.lblLNinfo.AutoSize = true;
            this.lblLNinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNinfo.ForeColor = System.Drawing.Color.Red;
            this.lblLNinfo.Location = new System.Drawing.Point(192, 279);
            this.lblLNinfo.Name = "lblLNinfo";
            this.lblLNinfo.Size = new System.Drawing.Size(153, 15);
            this.lblLNinfo.TabIndex = 53;
            this.lblLNinfo.Text = "Last name cannot be empty";
            this.lblLNinfo.Visible = false;
            this.lblLNinfo.Click += new System.EventHandler(this.LblLNinfo_Click);
            // 
            // lblFNinfo
            // 
            this.lblFNinfo.AutoSize = true;
            this.lblFNinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNinfo.ForeColor = System.Drawing.Color.Red;
            this.lblFNinfo.Location = new System.Drawing.Point(192, 232);
            this.lblFNinfo.Name = "lblFNinfo";
            this.lblFNinfo.Size = new System.Drawing.Size(154, 15);
            this.lblFNinfo.TabIndex = 52;
            this.lblFNinfo.Text = "First name cannot be empty";
            this.lblFNinfo.Visible = false;
            this.lblFNinfo.Click += new System.EventHandler(this.LblFNinfo_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserID.AutoSize = true;
            this.txtUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUserID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUserID.Location = new System.Drawing.Point(192, 217);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(0, 18);
            this.txtUserID.TabIndex = 51;
            this.txtUserID.Click += new System.EventHandler(this.TxtUserID_Click);
            // 
            // comboRole
            // 
            this.comboRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRole.BackColor = System.Drawing.Color.Gainsboro;
            this.comboRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRole.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "DATA ENCODER",
            "MANAGER",
            "SUPERVISOR"});
            this.comboRole.Location = new System.Drawing.Point(195, 436);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(209, 26);
            this.comboRole.Sorted = true;
            this.comboRole.TabIndex = 50;
            this.comboRole.SelectedIndexChanged += new System.EventHandler(this.ComboRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRole.Location = new System.Drawing.Point(34, 439);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 18);
            this.lblRole.TabIndex = 49;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.LblRole_Click);
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bottomButtonPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomButtonPanel.Controls.Add(this.btnDelete);
            this.bottomButtonPanel.Controls.Add(this.btnClear);
            this.bottomButtonPanel.Controls.Add(this.btnSave);
            this.bottomButtonPanel.Location = new System.Drawing.Point(447, 444);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.Size = new System.Drawing.Size(446, 34);
            this.bottomButtonPanel.TabIndex = 54;
            this.bottomButtonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BottomButtonPanel_Paint);
            // 
            // dgvUserSearch
            // 
            this.dgvUserSearch.AllowUserToAddRows = false;
            this.dgvUserSearch.AllowUserToDeleteRows = false;
            this.dgvUserSearch.AllowUserToOrderColumns = true;
            this.dgvUserSearch.AllowUserToResizeColumns = false;
            this.dgvUserSearch.AllowUserToResizeRows = false;
            this.dgvUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUserSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserSearch.GridColor = System.Drawing.Color.White;
            this.dgvUserSearch.Location = new System.Drawing.Point(0, 36);
            this.dgvUserSearch.MultiSelect = false;
            this.dgvUserSearch.Name = "dgvUserSearch";
            this.dgvUserSearch.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserSearch.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUserSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserSearch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvUserSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvUserSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUserSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvUserSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvUserSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUserSearch.RowTemplate.ReadOnly = true;
            this.dgvUserSearch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserSearch.ShowEditingIcon = false;
            this.dgvUserSearch.Size = new System.Drawing.Size(424, 442);
            this.dgvUserSearch.TabIndex = 55;
            this.dgvUserSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUserSearch_CellContentClick);
            this.dgvUserSearch.DoubleClick += new System.EventHandler(this.dgvUserSearch_DoubleClick);
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
            this.btnDelete.Location = new System.Drawing.Point(343, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnClear.Location = new System.Drawing.Point(177, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // userPicBox
            // 
            this.userPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicBox.BackColor = System.Drawing.Color.Gainsboro;
            this.userPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPicBox.Image = global::Payroll_Management_System.Properties.Resources.icons8_user_96px;
            this.userPicBox.ImageActive = null;
            this.userPicBox.Location = new System.Drawing.Point(165, 14);
            this.userPicBox.Name = "userPicBox";
            this.userPicBox.Size = new System.Drawing.Size(128, 143);
            this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicBox.TabIndex = 4;
            this.userPicBox.TabStop = false;
            this.userPicBox.Zoom = 10;
            this.userPicBox.Click += new System.EventHandler(this.userPicBox_Click);
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
            this.txtSearch.TabIndex = 45;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.TxtSearch_OnTextChange);
            this.txtSearch.KeyUp += new System.EventHandler(this.txtSearch_KeyUp);
            // 
            // ucManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgvUserSearch);
            this.Controls.Add(this.bottomButtonPanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.viewEmpPanel);
            this.Controls.Add(this.txtSearch);
            this.Name = "ucManageUsers";
            this.Size = new System.Drawing.Size(910, 481);
            this.Load += new System.EventHandler(this.UcManageUsers_Load);
            this.viewEmpPanel.ResumeLayout(false);
            this.viewEmpPanel.PerformLayout();
            this.bottomButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuImageButton userPicBox;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFirstName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLastName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private System.Windows.Forms.Panel viewEmpPanel;
        private System.Windows.Forms.Panel bottomButtonPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DataGridView dgvUserSearch;
        private System.Windows.Forms.Label txtUserID;
        private System.Windows.Forms.Label lblRinfo;
        private System.Windows.Forms.Label lblPWinfo;
        private System.Windows.Forms.Label lblUNinfo;
        private System.Windows.Forms.Label lblLNinfo;
        private System.Windows.Forms.Label lblFNinfo;
    }
}
