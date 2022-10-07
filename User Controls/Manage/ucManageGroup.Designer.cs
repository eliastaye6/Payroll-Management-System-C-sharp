namespace Payroll_Management_System.User_Controls
{
    partial class ucManageGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageGroup));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bottomButtonPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.viewEmpPanel = new System.Windows.Forms.Panel();
            this.txtGroupId = new System.Windows.Forms.Label();
            this.lblGNinfo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.txtGroupName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvGroupSearch = new System.Windows.Forms.DataGridView();
            this.bottomButtonPanel.SuspendLayout();
            this.viewEmpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupSearch)).BeginInit();
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
            this.bottomButtonPanel.TabIndex = 48;
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
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            // viewEmpPanel
            // 
            this.viewEmpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewEmpPanel.AutoScroll = true;
            this.viewEmpPanel.AutoScrollMargin = new System.Drawing.Size(5, 40);
            this.viewEmpPanel.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.viewEmpPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.viewEmpPanel.Controls.Add(this.txtGroupId);
            this.viewEmpPanel.Controls.Add(this.lblGNinfo);
            this.viewEmpPanel.Controls.Add(this.txtDescription);
            this.viewEmpPanel.Controls.Add(this.lblGroupID);
            this.viewEmpPanel.Controls.Add(this.txtGroupName);
            this.viewEmpPanel.Controls.Add(this.lblDescription);
            this.viewEmpPanel.Controls.Add(this.lblName);
            this.viewEmpPanel.Location = new System.Drawing.Point(447, 0);
            this.viewEmpPanel.Name = "viewEmpPanel";
            this.viewEmpPanel.Size = new System.Drawing.Size(463, 441);
            this.viewEmpPanel.TabIndex = 47;
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
            this.txtGroupId.TabIndex = 50;
            // 
            // lblGNinfo
            // 
            this.lblGNinfo.AutoSize = true;
            this.lblGNinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGNinfo.ForeColor = System.Drawing.Color.Red;
            this.lblGNinfo.Location = new System.Drawing.Point(191, 78);
            this.lblGNinfo.Name = "lblGNinfo";
            this.lblGNinfo.Size = new System.Drawing.Size(167, 15);
            this.lblGNinfo.TabIndex = 49;
            this.lblGNinfo.Text = "Group name cannot be empty";
            this.lblGNinfo.Visible = false;
            this.lblGNinfo.Click += new System.EventHandler(this.LblGNinfo_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(194, 140);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 96);
            this.txtDescription.TabIndex = 42;
            this.txtDescription.Text = "";
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
            // txtGroupName
            // 
            this.txtGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtGroupName.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtGroupName.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtGroupName.BorderThickness = 1;
            this.txtGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGroupName.isPassword = false;
            this.txtGroupName.Location = new System.Drawing.Point(194, 93);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(5);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(227, 25);
            this.txtGroupName.TabIndex = 30;
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtSearch.TabIndex = 45;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.TxtSearch_OnTextChange);
            this.txtSearch.KeyUp += new System.EventHandler(this.TxtSearch_KeyUp);
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
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.dgvGroupSearch.TabIndex = 49;
            this.dgvGroupSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroupSearch_CellContentClick);
            this.dgvGroupSearch.DoubleClick += new System.EventHandler(this.DgvGroupSearch_DoubleClick);
            // 
            // ucManageGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgvGroupSearch);
            this.Controls.Add(this.bottomButtonPanel);
            this.Controls.Add(this.viewEmpPanel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Name = "ucManageGroup";
            this.Size = new System.Drawing.Size(910, 481);
            this.Load += new System.EventHandler(this.UcManageGroup_Load);
            this.bottomButtonPanel.ResumeLayout(false);
            this.viewEmpPanel.ResumeLayout(false);
            this.viewEmpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomButtonPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel viewEmpPanel;
        private System.Windows.Forms.Label lblGroupID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGroupName;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dgvGroupSearch;
        private System.Windows.Forms.Label lblGNinfo;
        private System.Windows.Forms.Label txtGroupId;
    }
}
