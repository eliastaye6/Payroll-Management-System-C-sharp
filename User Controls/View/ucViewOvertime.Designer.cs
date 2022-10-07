namespace Payroll_Management_System.User_Controls.View
{
    partial class ucViewOvertime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewOvertime));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvOverTimeSearch = new System.Windows.Forms.DataGridView();
            this.viewEmpPanel = new System.Windows.Forms.Panel();
            this.txtHourlyRate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtOtID = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblOvertimeID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.searchDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverTimeSearch)).BeginInit();
            this.viewEmpPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.txtSearch.TabIndex = 60;
            this.txtSearch.text = "";
            this.txtSearch.KeyUp += new System.EventHandler(this.txtSearch_KeyUp);
            // 
            // dgvOverTimeSearch
            // 
            this.dgvOverTimeSearch.AllowUserToAddRows = false;
            this.dgvOverTimeSearch.AllowUserToDeleteRows = false;
            this.dgvOverTimeSearch.AllowUserToOrderColumns = true;
            this.dgvOverTimeSearch.AllowUserToResizeColumns = false;
            this.dgvOverTimeSearch.AllowUserToResizeRows = false;
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
            this.dgvOverTimeSearch.Location = new System.Drawing.Point(0, 37);
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
            this.dgvOverTimeSearch.TabIndex = 62;
            this.dgvOverTimeSearch.DoubleClick += new System.EventHandler(this.dgvOverTimeSearch_DoubleClick);
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
            this.viewEmpPanel.Controls.Add(this.txtHourlyRate);
            this.viewEmpPanel.Controls.Add(this.txtName);
            this.viewEmpPanel.Controls.Add(this.txtOtID);
            this.viewEmpPanel.Controls.Add(this.EndTime);
            this.viewEmpPanel.Controls.Add(this.StartTime);
            this.viewEmpPanel.Controls.Add(this.label2);
            this.viewEmpPanel.Controls.Add(this.label1);
            this.viewEmpPanel.Controls.Add(this.lblHourlyRate);
            this.viewEmpPanel.Controls.Add(this.txtDescription);
            this.viewEmpPanel.Controls.Add(this.lblOvertimeID);
            this.viewEmpPanel.Controls.Add(this.lblDescription);
            this.viewEmpPanel.Controls.Add(this.lblName);
            this.viewEmpPanel.Location = new System.Drawing.Point(447, 1);
            this.viewEmpPanel.Name = "viewEmpPanel";
            this.viewEmpPanel.Size = new System.Drawing.Size(463, 441);
            this.viewEmpPanel.TabIndex = 61;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHourlyRate.AutoSize = true;
            this.txtHourlyRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtHourlyRate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtHourlyRate.Location = new System.Drawing.Point(191, 148);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(0, 18);
            this.txtHourlyRate.TabIndex = 52;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoSize = true;
            this.txtName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtName.Location = new System.Drawing.Point(191, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 18);
            this.txtName.TabIndex = 51;
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
            this.EndTime.Size = new System.Drawing.Size(196, 23);
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
            this.StartTime.Size = new System.Drawing.Size(196, 23);
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
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(195, 96);
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
            // searchDate
            // 
            this.searchDate.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.searchDate.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.searchDate.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.searchDate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchDate.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.searchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchDate.Location = new System.Drawing.Point(0, 13);
            this.searchDate.Name = "searchDate";
            this.searchDate.ShowUpDown = true;
            this.searchDate.Size = new System.Drawing.Size(204, 23);
            this.searchDate.TabIndex = 63;
            // 
            // ucViewOvertime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.searchDate);
            this.Controls.Add(this.dgvOverTimeSearch);
            this.Controls.Add(this.viewEmpPanel);
            this.Controls.Add(this.txtSearch);
            this.Name = "ucViewOvertime";
            this.Size = new System.Drawing.Size(910, 481);
            this.Load += new System.EventHandler(this.UcViewOvertime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverTimeSearch)).EndInit();
            this.viewEmpPanel.ResumeLayout(false);
            this.viewEmpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.DataGridView dgvOverTimeSearch;
        private System.Windows.Forms.Panel viewEmpPanel;
        private System.Windows.Forms.Label txtHourlyRate;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtOtID;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblOvertimeID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker searchDate;
    }
}
