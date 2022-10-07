namespace test
{
    partial class Form1
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
            this.payrollReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDepartmentSummary = new System.Windows.Forms.Button();
            this.btnEmployeesTaxCollected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // payrollReportViewer1
            // 
            this.payrollReportViewer1.ActiveViewIndex = -1;
            this.payrollReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payrollReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.payrollReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payrollReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.payrollReportViewer1.Name = "payrollReportViewer1";
            this.payrollReportViewer1.Size = new System.Drawing.Size(802, 450);
            this.payrollReportViewer1.TabIndex = 0;
            this.payrollReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.payrollReportViewer1.Load += new System.EventHandler(this.PayrollReportViewer1_Load);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Location = new System.Drawing.Point(706, 375);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Payroll";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnDepartmentSummary
            // 
            this.btnDepartmentSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepartmentSummary.Location = new System.Drawing.Point(552, 375);
            this.btnDepartmentSummary.Name = "btnDepartmentSummary";
            this.btnDepartmentSummary.Size = new System.Drawing.Size(136, 23);
            this.btnDepartmentSummary.TabIndex = 2;
            this.btnDepartmentSummary.Text = "Departmen summary";
            this.btnDepartmentSummary.UseVisualStyleBackColor = true;
            this.btnDepartmentSummary.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnEmployeesTaxCollected
            // 
            this.btnEmployeesTaxCollected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeesTaxCollected.Location = new System.Drawing.Point(399, 375);
            this.btnEmployeesTaxCollected.Name = "btnEmployeesTaxCollected";
            this.btnEmployeesTaxCollected.Size = new System.Drawing.Size(136, 23);
            this.btnEmployeesTaxCollected.TabIndex = 3;
            this.btnEmployeesTaxCollected.Text = "Employees Tax Collected";
            this.btnEmployeesTaxCollected.UseVisualStyleBackColor = true;
            this.btnEmployeesTaxCollected.Click += new System.EventHandler(this.BtnEmployeesTaxCollected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.btnEmployeesTaxCollected);
            this.Controls.Add(this.btnDepartmentSummary);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.payrollReportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer payrollReportViewer1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDepartmentSummary;
        private System.Windows.Forms.Button btnEmployeesTaxCollected;
    }
}

