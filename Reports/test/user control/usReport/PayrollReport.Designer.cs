namespace test.user_control.usReport
{
    partial class PayrollReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollReport));
            this.insidePanel = new System.Windows.Forms.Panel();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.btnIncomeTax = new System.Windows.Forms.Button();
            this.btnDepSummary = new System.Windows.Forms.Button();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.insidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // insidePanel
            // 
            this.insidePanel.AutoSize = true;
            this.insidePanel.Controls.Add(this.crystalReportViewer);
            this.insidePanel.Location = new System.Drawing.Point(37, 59);
            this.insidePanel.Name = "insidePanel";
            this.insidePanel.Size = new System.Drawing.Size(984, 561);
            this.insidePanel.TabIndex = 3;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(910, 481);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer.Load += new System.EventHandler(this.CrystalReportViewer_Load);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.comboBox3);
            this.topPanel.Controls.Add(this.comboBox2);
            this.topPanel.Controls.Add(this.comboMonth);
            this.topPanel.Controls.Add(this.btnIncomeTax);
            this.topPanel.Controls.Add(this.btnDepSummary);
            this.topPanel.Controls.Add(this.btnPayroll);
            this.topPanel.Location = new System.Drawing.Point(37, 20);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(910, 32);
            this.topPanel.TabIndex = 2;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Month";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(632, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(96, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(802, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboMonth
            // 
            this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "January",
            "Feburary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboMonth.Location = new System.Drawing.Point(488, 3);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(91, 21);
            this.comboMonth.TabIndex = 4;
            // 
            // btnIncomeTax
            // 
            this.btnIncomeTax.AutoSize = true;
            this.btnIncomeTax.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnIncomeTax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncomeTax.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIncomeTax.FlatAppearance.BorderSize = 0;
            this.btnIncomeTax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnIncomeTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomeTax.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomeTax.ForeColor = System.Drawing.Color.White;
            this.btnIncomeTax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncomeTax.Location = new System.Drawing.Point(298, 0);
            this.btnIncomeTax.Name = "btnIncomeTax";
            this.btnIncomeTax.Size = new System.Drawing.Size(150, 32);
            this.btnIncomeTax.TabIndex = 3;
            this.btnIncomeTax.Text = "Income Tax Detail";
            this.btnIncomeTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncomeTax.UseVisualStyleBackColor = false;
            this.btnIncomeTax.Click += new System.EventHandler(this.BtnIncomeTax_Click);
            // 
            // btnDepSummary
            // 
            this.btnDepSummary.AutoSize = true;
            this.btnDepSummary.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDepSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepSummary.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepSummary.FlatAppearance.BorderSize = 0;
            this.btnDepSummary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDepSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepSummary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepSummary.ForeColor = System.Drawing.Color.White;
            this.btnDepSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepSummary.Location = new System.Drawing.Point(120, 0);
            this.btnDepSummary.Name = "btnDepSummary";
            this.btnDepSummary.Size = new System.Drawing.Size(178, 32);
            this.btnDepSummary.TabIndex = 2;
            this.btnDepSummary.Text = "Department Summary";
            this.btnDepSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepSummary.UseVisualStyleBackColor = false;
            this.btnDepSummary.Click += new System.EventHandler(this.BtnDepSummary_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.BackColor = System.Drawing.Color.Chocolate;
            this.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayroll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPayroll.FlatAppearance.BorderSize = 0;
            this.btnPayroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayroll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.Image = ((System.Drawing.Image)(resources.GetObject("btnPayroll.Image")));
            this.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.Location = new System.Drawing.Point(0, 0);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(120, 32);
            this.btnPayroll.TabIndex = 1;
            this.btnPayroll.Text = "Payroll";
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayroll.UseVisualStyleBackColor = false;
            this.btnPayroll.Click += new System.EventHandler(this.BtnPayroll_Click);
            // 
            // PayrollReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.insidePanel);
            this.Controls.Add(this.topPanel);
            this.Name = "PayrollReport";
            this.Size = new System.Drawing.Size(984, 561);
            this.insidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel insidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnIncomeTax;
        private System.Windows.Forms.Button btnDepSummary;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboMonth;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Label label3;
    }
}
