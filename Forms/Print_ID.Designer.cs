namespace Payroll_Management_System.Forms
{
    partial class Print_ID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_ID));
            this.insidePrintPanel = new System.Windows.Forms.Panel();
            this.picBoxBarcode = new System.Windows.Forms.PictureBox();
            this.txtDOB = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeePicBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.print = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.PrintPanel = new System.Windows.Forms.Panel();
            this.insidePrintPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicBox)).BeginInit();
            this.PrintPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // insidePrintPanel
            // 
            this.insidePrintPanel.BackColor = System.Drawing.Color.White;
            this.insidePrintPanel.Controls.Add(this.picBoxBarcode);
            this.insidePrintPanel.Controls.Add(this.txtDOB);
            this.insidePrintPanel.Controls.Add(this.lblDOB);
            this.insidePrintPanel.Controls.Add(this.txtDepartment);
            this.insidePrintPanel.Controls.Add(this.txtTel);
            this.insidePrintPanel.Controls.Add(this.txtFullname);
            this.insidePrintPanel.Controls.Add(this.txtEmpId);
            this.insidePrintPanel.Controls.Add(this.lblDepartment);
            this.insidePrintPanel.Controls.Add(this.lblTel);
            this.insidePrintPanel.Controls.Add(this.label2);
            this.insidePrintPanel.Controls.Add(this.label1);
            this.insidePrintPanel.Controls.Add(this.employeePicBox);
            this.insidePrintPanel.Controls.Add(this.lblEmployeeID);
            this.insidePrintPanel.Controls.Add(this.lblFirstName);
            this.insidePrintPanel.Location = new System.Drawing.Point(7, 5);
            this.insidePrintPanel.Name = "insidePrintPanel";
            this.insidePrintPanel.Size = new System.Drawing.Size(220, 330);
            this.insidePrintPanel.TabIndex = 0;
            this.insidePrintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // picBoxBarcode
            // 
            this.picBoxBarcode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picBoxBarcode.BackColor = System.Drawing.Color.White;
            this.picBoxBarcode.ErrorImage = null;
            this.picBoxBarcode.ImageLocation = "";
            this.picBoxBarcode.InitialImage = null;
            this.picBoxBarcode.Location = new System.Drawing.Point(17, 284);
            this.picBoxBarcode.Name = "picBoxBarcode";
            this.picBoxBarcode.Size = new System.Drawing.Size(201, 43);
            this.picBoxBarcode.TabIndex = 56;
            this.picBoxBarcode.TabStop = false;
            this.picBoxBarcode.Click += new System.EventHandler(this.PicBoxBarcode_Click);
            // 
            // txtDOB
            // 
            this.txtDOB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDOB.AutoSize = true;
            this.txtDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDOB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDOB.Location = new System.Drawing.Point(109, 238);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(0, 20);
            this.txtDOB.TabIndex = 55;
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDOB.AutoSize = true;
            this.lblDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDOB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDOB.Location = new System.Drawing.Point(3, 238);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(96, 20);
            this.lblDOB.TabIndex = 54;
            this.lblDOB.Text = "Expire Date:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDepartment.AutoSize = true;
            this.txtDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDepartment.Location = new System.Drawing.Point(109, 216);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(0, 20);
            this.txtDepartment.TabIndex = 53;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTel.AutoSize = true;
            this.txtTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTel.Location = new System.Drawing.Point(109, 195);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(0, 20);
            this.txtTel.TabIndex = 52;
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFullname.AutoSize = true;
            this.txtFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtFullname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtFullname.Location = new System.Drawing.Point(111, 172);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(0, 20);
            this.txtFullname.TabIndex = 51;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEmpId.AutoSize = true;
            this.txtEmpId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEmpId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmpId.Location = new System.Drawing.Point(111, 149);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(0, 20);
            this.txtEmpId.TabIndex = 50;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDepartment.Location = new System.Drawing.Point(3, 216);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(101, 20);
            this.lblDepartment.TabIndex = 49;
            this.lblDepartment.Text = "Department:";
            // 
            // lblTel
            // 
            this.lblTel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTel.AutoSize = true;
            this.lblTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTel.Location = new System.Drawing.Point(3, 195);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(56, 20);
            this.lblTel.TabIndex = 48;
            this.lblTel.Text = "Tel No:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(96, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 10);
            this.label2.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(49, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Company Name";
            // 
            // employeePicBox
            // 
            this.employeePicBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.employeePicBox.BackColor = System.Drawing.Color.White;
            this.employeePicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeePicBox.Image = ((System.Drawing.Image)(resources.GetObject("employeePicBox.Image")));
            this.employeePicBox.ImageActive = null;
            this.employeePicBox.Location = new System.Drawing.Point(49, 14);
            this.employeePicBox.Name = "employeePicBox";
            this.employeePicBox.Size = new System.Drawing.Size(127, 132);
            this.employeePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeePicBox.TabIndex = 44;
            this.employeePicBox.TabStop = false;
            this.employeePicBox.Zoom = 10;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployeeID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployeeID.Location = new System.Drawing.Point(3, 149);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(105, 20);
            this.lblEmployeeID.TabIndex = 43;
            this.lblEmployeeID.Text = "Employee ID:";
            this.lblEmployeeID.Click += new System.EventHandler(this.LblEmployeeID_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFirstName.Location = new System.Drawing.Point(3, 172);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblFirstName.TabIndex = 41;
            this.lblFirstName.Text = "Full Name:";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(15, 354);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 34);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(150, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Cancel";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // print
            // 
            this.print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Print_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PrintPanel
            // 
            this.PrintPanel.Controls.Add(this.insidePrintPanel);
            this.PrintPanel.Location = new System.Drawing.Point(12, 8);
            this.PrintPanel.Name = "PrintPanel";
            this.PrintPanel.Size = new System.Drawing.Size(234, 340);
            this.PrintPanel.TabIndex = 57;
            this.PrintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint_1);
            // 
            // Print_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(258, 393);
            this.ControlBox = false;
            this.Controls.Add(this.PrintPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Print_ID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print_ID";
            this.insidePrintPanel.ResumeLayout(false);
            this.insidePrintPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicBox)).EndInit();
            this.PrintPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel insidePrintPanel;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblFirstName;
        private Bunifu.Framework.UI.BunifuImageButton employeePicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label txtDepartment;
        private System.Windows.Forms.Label txtTel;
        private System.Windows.Forms.Label txtFullname;
        private System.Windows.Forms.Label txtEmpId;
        private System.Windows.Forms.Label txtDOB;
        private System.Windows.Forms.Label lblDOB;
        protected System.Windows.Forms.PictureBox picBoxBarcode;
        private System.Drawing.Printing.PrintDocument print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel PrintPanel;
    }
}