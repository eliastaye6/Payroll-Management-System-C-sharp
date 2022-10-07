namespace Payroll_Management_System.User_Controls.Manage
{
    partial class ucManageOverTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageOverTime));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bottomButtonPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.viewEmpPanel = new System.Windows.Forms.Panel();
            this.lblOTHRinfo = new System.Windows.Forms.Label();
            this.lblOTNinfo = new System.Windows.Forms.Label();
            this.txtOtID = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHourlyRate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblOvertimeID = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvOverTimeSearch = new System.Windows.Forms.DataGridView();
            this.bottomButtonPanel.SuspendLayout();
            this.viewEmpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverTimeSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bottomButtonPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomButtonPanel.Controls.Add(this.btnDelete);
            this.bottomButtonPanel.Controls.Add(this.btnClear);
            this.bottomButtonPanel.Controls.Add(this.btnSave);
            this.bottomButtonPanel.Location = new System.Drawing.Point(447, 447);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.Size = new System.Drawing.Size(446, 34);
            this.bottomButtonPanel.TabIndex = 58;
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
            // viewEmpPanel
            // 
            this.viewEmpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewEmpPanel.AutoScroll = true;
            this.viewEmpPanel.AutoScrollMargin = new System.Drawing.Size(5, 40);
            this.viewEmpPanel.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.viewEmpPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.viewEmpPanel.Controls.Add(this.lblOTHRinfo);
            this.viewEmpPanel.Controls.Add(this.lblOTNinfo);
            this.viewEmpPanel.Controls.Add(this.txtOtID);
            this.viewEmpPanel.Controls.Add(this.EndTime);
            this.viewEmpPanel.Controls.Add(this.StartTime);
            this.viewEmpPanel.Controls.Add(this.label2);
            this.viewEmpPanel.Controls.Add(this.label1);
            this.viewEmpPanel.Controls.Add(this.txtHourlyRate);
            this.viewEmpPanel.Controls.Add(this.lblHourlyRate);
            this.viewEmpPanel.Controls.Add(this.txtDescription);
            this.viewEmpPanel.Controls.Add(this.lblOvertimeID);
            this.viewEmpPanel.Controls.Add(this.txtName);
            this.viewEmpPanel.Controls.Add(this.lblDescription);
            this.viewEmpPanel.Controls.Add(this.lblName);
            this.viewEmpPanel.Location = new System.Drawing.Point(447, 0);
            this.viewEmpPanel.Name = "viewEmpPanel";
            this.viewEmpPanel.Size = new System.Drawing.Size(463, 441);
            this.viewEmpPanel.TabIndex = 57;
            // 
            // lblOTHRinfo
            // 
            this.lblOTHRinfo.AutoSize = true;
            this.lblOTHRinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTHRinfo.ForeColor = System.Drawing.Color.Red;
            this.lblOTHRinfo.Location = new System.Drawing.Point(191, 123);
            this.lblOTHRinfo.Name = "lblOTHRinfo";
            this.lblOTHRinfo.Size = new System.Drawing.Size(251, 15);
            this.lblOTHRinfo.TabIndex = 52;
            this.lblOTHRinfo.Text = "Hourly Rate is a number and cannot be empty";
            this.lblOTHRinfo.Visible = false;
            // 
            // lblOTNinfo
            // 
            this.lblOTNinfo.AutoSize = true;
            this.lblOTNinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTNinfo.ForeColor = System.Drawing.Color.Red;
            this.lblOTNinfo.Location = new System.Drawing.Point(191, 73);
            this.lblOTNinfo.Name = "lblOTNinfo";
            this.lblOTNinfo.Size = new System.Drawing.Size(181, 15);
            this.lblOTNinfo.TabIndex = 51;
            this.lblOTNinfo.Text = "Overtime name cannot be empty";
            this.lblOTNinfo.Visible = false;
            // 
            // txtOtID
            // 
            this.txtOtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtID.AutoSize = true;
            this.txtOtID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOtID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtOtID.Location = new System.Drawing.Point(191, 55);
            this.txtOtID.Name = "txtOtID";
            this.txtOtID.Size = new System.Drawing.Size(0, 18);
            this.txtOtID.TabIndex = 50;
            // 
            // EndTime
            // 
            this.EndTime.AllowDrop = true;
            this.EndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTime.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.EndTime.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.EndTime.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.EndTime.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EndTime.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.EndTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndTime.CustomFormat = "HH:mm";
            this.EndTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Location = new System.Drawing.Point(194, 251);
            this.EndTime.Name = "EndTime";
            this.EndTime.ShowUpDown = true;
            this.EndTime.Size = new System.Drawing.Size(197, 23);
            this.EndTime.TabIndex = 49;
            // 
            // StartTime
            // 
            this.StartTime.AllowDrop = true;
            this.StartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTime.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.StartTime.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.StartTime.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.StartTime.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartTime.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.StartTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartTime.CustomFormat = "HH:mm";
            this.StartTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTime.Location = new System.Drawing.Point(194, 206);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(197, 23);
            this.StartTime.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(38, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "End Time";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Start Time";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHourlyRate.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtHourlyRate.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtHourlyRate.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtHourlyRate.BorderThickness = 1;
            this.txtHourlyRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHourlyRate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHourlyRate.isPassword = false;
            this.txtHourlyRate.Location = new System.Drawing.Point(194, 141);
            this.txtHourlyRate.Margin = new System.Windows.Forms.Padding(5);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(197, 25);
            this.txtHourlyRate.TabIndex = 45;
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHourlyRate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHourlyRate.Location = new System.Drawing.Point(34, 148);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(92, 18);
            this.lblHourlyRate.TabIndex = 44;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(194, 325);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 96);
            this.txtDescription.TabIndex = 42;
            this.txtDescription.Text = "";
            // 
            // lblOvertimeID
            // 
            this.lblOvertimeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOvertimeID.AutoSize = true;
            this.lblOvertimeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOvertimeID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertimeID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOvertimeID.Location = new System.Drawing.Point(34, 55);
            this.lblOvertimeID.Name = "lblOvertimeID";
            this.lblOvertimeID.Size = new System.Drawing.Size(95, 18);
            this.lblOvertimeID.TabIndex = 40;
            this.lblOvertimeID.Text = "Overtime ID";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtName.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtName.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtName.BorderThickness = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(194, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 25);
            this.txtName.TabIndex = 30;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescription.Location = new System.Drawing.Point(34, 325);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 18);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(34, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 18);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Overtime Name";
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
            this.txtSearch.TabIndex = 55;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.TxtSearch_OnTextChange);
            this.txtSearch.KeyUp += new System.EventHandler(this.txtSearch_KeyUp);
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
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvOverTimeSearch
            // 
            this.dgvOverTimeSearch.AllowUserToAddRows = false;
            this.dgvOverTimeSearch.AllowUserToDeleteRows = false;
            this.dgvOverTimeSearch.AllowUserToOrderColumns = true;
            this.dgvOverTimeSearch.AllowUserToResizeColumns = false;
            this.dgvOverTimeSearch.AllowUserToResizeRows = false;
            this.dgvOverTimeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvOverTimeSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOverTimeSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvOverTimeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverTimeSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOverTimeSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverTimeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverTimeSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOverTimeSearch.GridColor = System.Drawing.Color.White;
            this.dgvOverTimeSearch.Location = new System.Drawing.Point(0, 36);
            this.dgvOverTimeSearch.MultiSelect = false;
            this.dgvOverTimeSearch.Name = "dgvOverTimeSearch";
            this.dgvOverTimeSearch.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverTimeSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOverTimeSearch.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOverTimeSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOverTimeSearch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOverTimeSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvOverTimeSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOverTimeSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvOverTimeSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvOverTimeSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOverTimeSearch.RowTemplate.ReadOnly = true;
            this.dgvOverTimeSearch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverTimeSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverTimeSearch.ShowEditingIcon = false;
            this.dgvOverTimeSearch.Size = new System.Drawing.Size(424, 442);
            this.dgvOverTimeSearch.TabIndex = 59;
            this.dgvOverTimeSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOverTimeSearch_CellContentClick);
            this.dgvOverTimeSearch.DoubleClick += new System.EventHandler(this.dgvOverTimeSearch_DoubleClick);
            // 
            // ucManageOverTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgvOverTimeSearch);
            this.Controls.Add(this.bottomButtonPanel);
            this.Controls.Add(this.viewEmpPanel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Name = "ucManageOverTime";
            this.Size = new System.Drawing.Size(910, 481);
            this.Load += new System.EventHandler(this.UcManageOverTime_Load);
            this.bottomButtonPanel.ResumeLayout(false);
            this.viewEmpPanel.ResumeLayout(false);
            this.viewEmpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverTimeSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomButtonPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel viewEmpPanel;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblOvertimeID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.DataGridView dgvOverTimeSearch;
        private System.Windows.Forms.Label txtOtID;
        private System.Windows.Forms.Label lblOTHRinfo;
        private System.Windows.Forms.Label lblOTNinfo;
    }
}
