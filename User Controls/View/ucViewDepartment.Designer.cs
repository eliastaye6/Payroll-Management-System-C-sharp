namespace Payroll_Management_System.User_Controls.View
{
    partial class ucViewDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewDepartment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewEmpPanel = new System.Windows.Forms.Panel();
            this.txtDepartmentName = new System.Windows.Forms.Label();
            this.txtDepartmentId = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvDepSearch = new System.Windows.Forms.DataGridView();
            this.viewEmpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepSearch)).BeginInit();
            this.SuspendLayout();
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
            this.viewEmpPanel.Controls.Add(this.txtDepartmentName);
            this.viewEmpPanel.Controls.Add(this.txtDepartmentId);
            this.viewEmpPanel.Controls.Add(this.txtDescription);
            this.viewEmpPanel.Controls.Add(this.lblDepartmentID);
            this.viewEmpPanel.Controls.Add(this.lblDescription);
            this.viewEmpPanel.Controls.Add(this.lblName);
            this.viewEmpPanel.Location = new System.Drawing.Point(447, 0);
            this.viewEmpPanel.Name = "viewEmpPanel";
            this.viewEmpPanel.Size = new System.Drawing.Size(463, 481);
            this.viewEmpPanel.TabIndex = 57;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartmentName.AutoSize = true;
            this.txtDepartmentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDepartmentName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDepartmentName.Location = new System.Drawing.Point(188, 97);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(0, 18);
            this.txtDepartmentName.TabIndex = 50;
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartmentId.AutoSize = true;
            this.txtDepartmentId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDepartmentId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDepartmentId.Location = new System.Drawing.Point(188, 55);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(0, 18);
            this.txtDepartmentId.TabIndex = 49;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(191, 136);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(227, 96);
            this.txtDescription.TabIndex = 42;
            this.txtDescription.Text = "";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDepartmentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDepartmentID.Location = new System.Drawing.Point(34, 55);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(114, 18);
            this.lblDepartmentID.TabIndex = 40;
            this.lblDepartmentID.Text = "Department ID";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescription.Location = new System.Drawing.Point(34, 136);
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
            this.lblName.Location = new System.Drawing.Point(34, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 18);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Department Name";
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
            this.txtSearch.KeyUp += new System.EventHandler(this.TxtSearch_KeyUp);
            // 
            // dgvDepSearch
            // 
            this.dgvDepSearch.AllowUserToAddRows = false;
            this.dgvDepSearch.AllowUserToDeleteRows = false;
            this.dgvDepSearch.AllowUserToOrderColumns = true;
            this.dgvDepSearch.AllowUserToResizeColumns = false;
            this.dgvDepSearch.AllowUserToResizeRows = false;
            this.dgvDepSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDepSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDepSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepSearch.GridColor = System.Drawing.Color.White;
            this.dgvDepSearch.Location = new System.Drawing.Point(0, 36);
            this.dgvDepSearch.MultiSelect = false;
            this.dgvDepSearch.Name = "dgvDepSearch";
            this.dgvDepSearch.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepSearch.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDepSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepSearch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDepSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvDepSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDepSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDepSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDepSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDepSearch.RowTemplate.ReadOnly = true;
            this.dgvDepSearch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepSearch.ShowEditingIcon = false;
            this.dgvDepSearch.Size = new System.Drawing.Size(424, 442);
            this.dgvDepSearch.TabIndex = 55;
            this.dgvDepSearch.DoubleClick += new System.EventHandler(this.DgvDepSearch_DoubleClick);
            // 
            // ucViewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgvDepSearch);
            this.Controls.Add(this.viewEmpPanel);
            this.Controls.Add(this.txtSearch);
            this.Name = "ucViewDepartment";
            this.Size = new System.Drawing.Size(910, 481);
            this.Load += new System.EventHandler(this.UcViewDepartment_Load);
            this.viewEmpPanel.ResumeLayout(false);
            this.viewEmpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewEmpPanel;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.DataGridView dgvDepSearch;
        private System.Windows.Forms.Label txtDepartmentName;
        private System.Windows.Forms.Label txtDepartmentId;
    }
}
