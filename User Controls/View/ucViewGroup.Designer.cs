namespace Payroll_Management_System.User_Controls.View
{
    partial class ucViewGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewGroup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewEmpPanel = new System.Windows.Forms.Panel();
            this.txtGroupDescription = new System.Windows.Forms.RichTextBox();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvGroupSearch = new System.Windows.Forms.DataGridView();
            this.txtGroupId = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.Label();
            this.viewEmpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupSearch)).BeginInit();
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
            this.viewEmpPanel.Controls.Add(this.txtGroupName);
            this.viewEmpPanel.Controls.Add(this.txtGroupId);
            this.viewEmpPanel.Controls.Add(this.txtGroupDescription);
            this.viewEmpPanel.Controls.Add(this.lblGroupID);
            this.viewEmpPanel.Controls.Add(this.lblDescription);
            this.viewEmpPanel.Controls.Add(this.lblName);
            this.viewEmpPanel.Location = new System.Drawing.Point(447, 0);
            this.viewEmpPanel.Name = "viewEmpPanel";
            this.viewEmpPanel.Size = new System.Drawing.Size(463, 481);
            this.viewEmpPanel.TabIndex = 52;
            // 
            // txtGroupDescription
            // 
            this.txtGroupDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGroupDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGroupDescription.Location = new System.Drawing.Point(194, 140);
            this.txtGroupDescription.Name = "txtGroupDescription";
            this.txtGroupDescription.ReadOnly = true;
            this.txtGroupDescription.Size = new System.Drawing.Size(227, 96);
            this.txtGroupDescription.TabIndex = 42;
            this.txtGroupDescription.Text = "";
            // 
            // lblGroupID
            // 
            this.lblGroupID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGroupID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGroupID.Location = new System.Drawing.Point(34, 55);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(74, 18);
            this.lblGroupID.TabIndex = 40;
            this.lblGroupID.Text = "Group ID";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescription.Location = new System.Drawing.Point(34, 140);
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
            this.lblName.Size = new System.Drawing.Size(104, 18);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Group Name";
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
            this.txtSearch.TabIndex = 50;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.TxtSearch_OnTextChange);
            this.txtSearch.KeyUp += new System.EventHandler(this.TxtSearch_KeyUp);
            // 
            // dgvGroupSearch
            // 
            this.dgvGroupSearch.AllowUserToAddRows = false;
            this.dgvGroupSearch.AllowUserToDeleteRows = false;
            this.dgvGroupSearch.AllowUserToOrderColumns = true;
            this.dgvGroupSearch.AllowUserToResizeColumns = false;
            this.dgvGroupSearch.AllowUserToResizeRows = false;
            this.dgvGroupSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGroupSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroupSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvGroupSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroupSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroupSearch.GridColor = System.Drawing.Color.White;
            this.dgvGroupSearch.Location = new System.Drawing.Point(0, 36);
            this.dgvGroupSearch.MultiSelect = false;
            this.dgvGroupSearch.Name = "dgvGroupSearch";
            this.dgvGroupSearch.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroupSearch.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGroupSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroupSearch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvGroupSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvGroupSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvGroupSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvGroupSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGroupSearch.RowTemplate.ReadOnly = true;
            this.dgvGroupSearch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroupSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupSearch.ShowEditingIcon = false;
            this.dgvGroupSearch.Size = new System.Drawing.Size(424, 442);
            this.dgvGroupSearch.TabIndex = 53;
            this.dgvGroupSearch.DoubleClick += new System.EventHandler(this.DgvGroupSearch_DoubleClick);
            // 
            // txtGroupId
            // 
            this.txtGroupId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupId.AutoSize = true;
            this.txtGroupId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGroupId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtGroupId.Location = new System.Drawing.Point(191, 55);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(0, 18);
            this.txtGroupId.TabIndex = 51;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupName.AutoSize = true;
            this.txtGroupName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGroupName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtGroupName.Location = new System.Drawing.Point(191, 100);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(0, 18);
            this.txtGroupName.TabIndex = 52;
            // 
            // ucViewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgvGroupSearch);
            this.Controls.Add(this.viewEmpPanel);
            this.Controls.Add(this.txtSearch);
            this.Name = "ucViewGroup";
            this.Size = new System.Drawing.Size(910, 481);
            this.Load += new System.EventHandler(this.UcViewGroup_Load);
            this.viewEmpPanel.ResumeLayout(false);
            this.viewEmpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel viewEmpPanel;
        private System.Windows.Forms.RichTextBox txtGroupDescription;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.DataGridView dgvGroupSearch;
        private System.Windows.Forms.Label txtGroupName;
        private System.Windows.Forms.Label txtGroupId;
    }
}
