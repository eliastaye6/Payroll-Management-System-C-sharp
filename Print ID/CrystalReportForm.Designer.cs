namespace NewCrystalReportsForm
{
    partial class CrystalReportForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrystalReportForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.crvEmployeeIdCard = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.topPanel.Controls.Add(this.logoPicBox);
            this.topPanel.Controls.Add(this.btnMin);
            this.topPanel.Controls.Add(this.btnMax);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(933, 45);
            this.topPanel.TabIndex = 1;
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.logoPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPicBox.BackgroundImage")));
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPicBox.Location = new System.Drawing.Point(0, 0);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(100, 45);
            this.logoPicBox.TabIndex = 10;
            this.logoPicBox.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMin.Location = new System.Drawing.Point(771, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(54, 45);
            this.btnMin.TabIndex = 9;
            this.btnMin.TabStop = false;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMax.BackgroundImage")));
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMax.Location = new System.Drawing.Point(825, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(54, 45);
            this.btnMax.TabIndex = 8;
            this.btnMax.TabStop = false;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Location = new System.Drawing.Point(879, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 45);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID Card";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(0, 45);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(100, 543);
            this.leftPanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.crvEmployeeIdCard);
            this.panel3.Location = new System.Drawing.Point(97, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 543);
            this.panel3.TabIndex = 5;
            // 
            // crvEmployeeIdCard
            // 
            this.crvEmployeeIdCard.ActiveViewIndex = -1;
            this.crvEmployeeIdCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEmployeeIdCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEmployeeIdCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEmployeeIdCard.Location = new System.Drawing.Point(0, 0);
            this.crvEmployeeIdCard.Name = "crvEmployeeIdCard";
            this.crvEmployeeIdCard.Size = new System.Drawing.Size(836, 543);
            this.crvEmployeeIdCard.TabIndex = 0;
            this.crvEmployeeIdCard.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // CrystalReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrystalReportForm";
            this.Text = "CrystalReportForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEmployeeIdCard;
    }
}