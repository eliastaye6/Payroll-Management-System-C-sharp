using System.Windows.Forms;

namespace Payroll_Management_System.User_Controls
{
    partial class ucManageMonthlyData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageMonthlyData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewEmpPanel = new System.Windows.Forms.Panel();
            this.lblfullName = new System.Windows.Forms.Label();
            this.txtUnpaidTax = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblUnpaidTax = new System.Windows.Forms.Label();
            this.txtUnpaidPension = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtOther = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtSaving = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMobile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblSaving = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtFine = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtCourtCase = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblCourtCase = new System.Windows.Forms.Label();
            this.txtMedical = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblMedical = new System.Windows.Forms.Label();
            this.txtIncentive = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblIncentive = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtActingAllowance = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtOverPayment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUnpaidSalary = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblActingAllowance = new System.Windows.Forms.Label();
            this.lblOverPayment = new System.Windows.Forms.Label();
            this.lblUnpaidSalary = new System.Windows.Forms.Label();
            this.lblUnpaidPension = new System.Windows.Forms.Label();
            this.PicBoxBarcode = new System.Windows.Forms.PictureBox();
            this.empPicBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bottomButtonPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvMonthlyDataSearch = new System.Windows.Forms.DataGridView();
            this.lblEIDinfo = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.viewEmpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empPicBox)).BeginInit();
            this.bottomButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyDataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // viewEmpPanel
            // 
            this.viewEmpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewEmpPanel.AutoScroll = true;
            this.viewEmpPanel.AutoScrollMargin = new System.Drawing.Size(5, 30);
            this.viewEmpPanel.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.viewEmpPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.viewEmpPanel.Controls.Add(this.txtEmployeeID);
            this.viewEmpPanel.Controls.Add(this.lblEIDinfo);
            this.viewEmpPanel.Controls.Add(this.lblfullName);
            this.viewEmpPanel.Controls.Add(this.txtUnpaidTax);
            this.viewEmpPanel.Controls.Add(this.lblUnpaidTax);
            this.viewEmpPanel.Controls.Add(this.txtUnpaidPension);
            this.viewEmpPanel.Controls.Add(this.txtOther);
            this.viewEmpPanel.Controls.Add(this.lblOther);
            this.viewEmpPanel.Controls.Add(this.txtSaving);
            this.viewEmpPanel.Controls.Add(this.txtMobile);
            this.viewEmpPanel.Controls.Add(this.lblSaving);
            this.viewEmpPanel.Controls.Add(this.lblMobile);
            this.viewEmpPanel.Controls.Add(this.txtFine);
            this.viewEmpPanel.Controls.Add(this.lblFine);
            this.viewEmpPanel.Controls.Add(this.txtCourtCase);
            this.viewEmpPanel.Controls.Add(this.lblCourtCase);
            this.viewEmpPanel.Controls.Add(this.txtMedical);
            this.viewEmpPanel.Controls.Add(this.lblMedical);
            this.viewEmpPanel.Controls.Add(this.txtIncentive);
            this.viewEmpPanel.Controls.Add(this.lblIncentive);
            this.viewEmpPanel.Controls.Add(this.lblEmployeeID);
            this.viewEmpPanel.Controls.Add(this.txtActingAllowance);
            this.viewEmpPanel.Controls.Add(this.txtOverPayment);
            this.viewEmpPanel.Controls.Add(this.txtUnpaidSalary);
            this.viewEmpPanel.Controls.Add(this.lblActingAllowance);
            this.viewEmpPanel.Controls.Add(this.lblOverPayment);
            this.viewEmpPanel.Controls.Add(this.lblUnpaidSalary);
            this.viewEmpPanel.Controls.Add(this.lblUnpaidPension);
            this.viewEmpPanel.Controls.Add(this.PicBoxBarcode);
            this.viewEmpPanel.Controls.Add(this.empPicBox);
            this.viewEmpPanel.Location = new System.Drawing.Point(447, 0);
            this.viewEmpPanel.Name = "viewEmpPanel";
            this.viewEmpPanel.Size = new System.Drawing.Size(463, 441);
            this.viewEmpPanel.TabIndex = 47;
            this.viewEmpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewEmpPanel_Paint);
            // 
            // lblfullName
            // 
            this.lblfullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfullName.AutoSize = true;
            this.lblfullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfullName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblfullName.Location = new System.Drawing.Point(200, 192);
            this.lblfullName.Name = "lblfullName";
            this.lblfullName.Size = new System.Drawing.Size(77, 18);
            this.lblfullName.TabIndex = 57;
            this.lblfullName.Text = "FullName";
            // 
            // txtUnpaidTax
            // 
            this.txtUnpaidTax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnpaidTax.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUnpaidTax.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtUnpaidTax.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtUnpaidTax.BorderThickness = 1;
            this.txtUnpaidTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnpaidTax.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnpaidTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnpaidTax.isPassword = false;
            this.txtUnpaidTax.Location = new System.Drawing.Point(194, 354);
            this.txtUnpaidTax.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUnpaidTax.Name = "txtUnpaidTax";
            this.txtUnpaidTax.Size = new System.Drawing.Size(227, 25);
            this.txtUnpaidTax.TabIndex = 58;
            this.txtUnpaidTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblUnpaidTax
            // 
            this.lblUnpaidTax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnpaidTax.AutoSize = true;
            this.lblUnpaidTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnpaidTax.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaidTax.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnpaidTax.Location = new System.Drawing.Point(34, 362);
            this.lblUnpaidTax.Name = "lblUnpaidTax";
            this.lblUnpaidTax.Size = new System.Drawing.Size(150, 18);
            this.lblUnpaidTax.TabIndex = 57;
            this.lblUnpaidTax.Text = "Unpaid Income Tax";
            // 
            // txtUnpaidPension
            // 
            this.txtUnpaidPension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnpaidPension.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUnpaidPension.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtUnpaidPension.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtUnpaidPension.BorderThickness = 1;
            this.txtUnpaidPension.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnpaidPension.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnpaidPension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnpaidPension.isPassword = false;
            this.txtUnpaidPension.Location = new System.Drawing.Point(194, 313);
            this.txtUnpaidPension.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUnpaidPension.Name = "txtUnpaidPension";
            this.txtUnpaidPension.Size = new System.Drawing.Size(227, 25);
            this.txtUnpaidPension.TabIndex = 61;
            this.txtUnpaidPension.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOther
            // 
            this.txtOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOther.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOther.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtOther.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtOther.BorderThickness = 1;
            this.txtOther.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOther.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOther.isPassword = false;
            this.txtOther.Location = new System.Drawing.Point(194, 764);
            this.txtOther.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(212, 25);
            this.txtOther.TabIndex = 60;
            this.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblOther
            // 
            this.lblOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOther.AutoSize = true;
            this.lblOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOther.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOther.Location = new System.Drawing.Point(34, 773);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(143, 18);
            this.lblOther.TabIndex = 59;
            this.lblOther.Text = "Other Contribution";
            // 
            // txtSaving
            // 
            this.txtSaving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaving.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSaving.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtSaving.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtSaving.BorderThickness = 1;
            this.txtSaving.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaving.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSaving.isPassword = false;
            this.txtSaving.Location = new System.Drawing.Point(194, 717);
            this.txtSaving.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaving.Name = "txtSaving";
            this.txtSaving.Size = new System.Drawing.Size(227, 25);
            this.txtSaving.TabIndex = 58;
            this.txtSaving.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMobile.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtMobile.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtMobile.BorderThickness = 1;
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMobile.isPassword = false;
            this.txtMobile.Location = new System.Drawing.Point(194, 669);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(227, 25);
            this.txtMobile.TabIndex = 57;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblSaving
            // 
            this.lblSaving.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaving.AutoSize = true;
            this.lblSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaving.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaving.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSaving.Location = new System.Drawing.Point(34, 726);
            this.lblSaving.Name = "lblSaving";
            this.lblSaving.Size = new System.Drawing.Size(57, 18);
            this.lblSaving.TabIndex = 56;
            this.lblSaving.Text = "Saving";
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobile.AutoSize = true;
            this.lblMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMobile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMobile.Location = new System.Drawing.Point(34, 675);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(132, 18);
            this.lblMobile.TabIndex = 55;
            this.lblMobile.Text = "Mobile/Transport";
            // 
            // txtFine
            // 
            this.txtFine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFine.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFine.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtFine.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtFine.BorderThickness = 1;
            this.txtFine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFine.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFine.isPassword = false;
            this.txtFine.Location = new System.Drawing.Point(194, 528);
            this.txtFine.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(227, 25);
            this.txtFine.TabIndex = 54;
            this.txtFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblFine
            // 
            this.lblFine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFine.AutoSize = true;
            this.lblFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFine.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFine.Location = new System.Drawing.Point(34, 535);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(38, 18);
            this.lblFine.TabIndex = 53;
            this.lblFine.Text = "Fine";
            // 
            // txtCourtCase
            // 
            this.txtCourtCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCourtCase.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCourtCase.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtCourtCase.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtCourtCase.BorderThickness = 1;
            this.txtCourtCase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourtCase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourtCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourtCase.isPassword = false;
            this.txtCourtCase.Location = new System.Drawing.Point(194, 482);
            this.txtCourtCase.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCourtCase.Name = "txtCourtCase";
            this.txtCourtCase.Size = new System.Drawing.Size(227, 25);
            this.txtCourtCase.TabIndex = 52;
            this.txtCourtCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblCourtCase
            // 
            this.lblCourtCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCourtCase.AutoSize = true;
            this.lblCourtCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCourtCase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtCase.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourtCase.Location = new System.Drawing.Point(34, 488);
            this.lblCourtCase.Name = "lblCourtCase";
            this.lblCourtCase.Size = new System.Drawing.Size(90, 18);
            this.lblCourtCase.TabIndex = 51;
            this.lblCourtCase.Text = "Court Case";
            // 
            // txtMedical
            // 
            this.txtMedical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedical.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMedical.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtMedical.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtMedical.BorderThickness = 1;
            this.txtMedical.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedical.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedical.isPassword = false;
            this.txtMedical.Location = new System.Drawing.Point(194, 436);
            this.txtMedical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMedical.Name = "txtMedical";
            this.txtMedical.Size = new System.Drawing.Size(227, 25);
            this.txtMedical.TabIndex = 50;
            this.txtMedical.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblMedical
            // 
            this.lblMedical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMedical.AutoSize = true;
            this.lblMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMedical.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedical.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMedical.Location = new System.Drawing.Point(34, 443);
            this.lblMedical.Name = "lblMedical";
            this.lblMedical.Size = new System.Drawing.Size(70, 18);
            this.lblMedical.TabIndex = 49;
            this.lblMedical.Text = "Medical";
            // 
            // txtIncentive
            // 
            this.txtIncentive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIncentive.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtIncentive.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtIncentive.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtIncentive.BorderThickness = 1;
            this.txtIncentive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIncentive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncentive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIncentive.isPassword = false;
            this.txtIncentive.Location = new System.Drawing.Point(194, 396);
            this.txtIncentive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIncentive.Name = "txtIncentive";
            this.txtIncentive.Size = new System.Drawing.Size(227, 25);
            this.txtIncentive.TabIndex = 48;
            this.txtIncentive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblIncentive
            // 
            this.lblIncentive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncentive.AutoSize = true;
            this.lblIncentive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIncentive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncentive.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIncentive.Location = new System.Drawing.Point(34, 403);
            this.lblIncentive.Name = "lblIncentive";
            this.lblIncentive.Size = new System.Drawing.Size(76, 18);
            this.lblIncentive.TabIndex = 47;
            this.lblIncentive.Text = "Incentive";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployeeID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployeeID.Location = new System.Drawing.Point(32, 232);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(102, 18);
            this.lblEmployeeID.TabIndex = 40;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtActingAllowance
            // 
            this.txtActingAllowance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActingAllowance.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtActingAllowance.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtActingAllowance.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtActingAllowance.BorderThickness = 1;
            this.txtActingAllowance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActingAllowance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActingAllowance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtActingAllowance.isPassword = false;
            this.txtActingAllowance.Location = new System.Drawing.Point(194, 619);
            this.txtActingAllowance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActingAllowance.Name = "txtActingAllowance";
            this.txtActingAllowance.Size = new System.Drawing.Size(227, 25);
            this.txtActingAllowance.TabIndex = 38;
            this.txtActingAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOverPayment
            // 
            this.txtOverPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOverPayment.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtOverPayment.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtOverPayment.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtOverPayment.BorderThickness = 1;
            this.txtOverPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOverPayment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOverPayment.isPassword = false;
            this.txtOverPayment.Location = new System.Drawing.Point(194, 575);
            this.txtOverPayment.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtOverPayment.Name = "txtOverPayment";
            this.txtOverPayment.Size = new System.Drawing.Size(227, 25);
            this.txtOverPayment.TabIndex = 37;
            this.txtOverPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUnpaidSalary
            // 
            this.txtUnpaidSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnpaidSalary.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUnpaidSalary.BorderColorIdle = System.Drawing.SystemColors.HotTrack;
            this.txtUnpaidSalary.BorderColorMouseHover = System.Drawing.Color.MidnightBlue;
            this.txtUnpaidSalary.BorderThickness = 1;
            this.txtUnpaidSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnpaidSalary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnpaidSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnpaidSalary.isPassword = false;
            this.txtUnpaidSalary.Location = new System.Drawing.Point(194, 268);
            this.txtUnpaidSalary.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUnpaidSalary.Name = "txtUnpaidSalary";
            this.txtUnpaidSalary.Size = new System.Drawing.Size(227, 25);
            this.txtUnpaidSalary.TabIndex = 35;
            this.txtUnpaidSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblActingAllowance
            // 
            this.lblActingAllowance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActingAllowance.AutoSize = true;
            this.lblActingAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblActingAllowance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActingAllowance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblActingAllowance.Location = new System.Drawing.Point(34, 629);
            this.lblActingAllowance.Name = "lblActingAllowance";
            this.lblActingAllowance.Size = new System.Drawing.Size(140, 18);
            this.lblActingAllowance.TabIndex = 33;
            this.lblActingAllowance.Text = "Acting Allowance";
            // 
            // lblOverPayment
            // 
            this.lblOverPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverPayment.AutoSize = true;
            this.lblOverPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOverPayment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverPayment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOverPayment.Location = new System.Drawing.Point(34, 583);
            this.lblOverPayment.Name = "lblOverPayment";
            this.lblOverPayment.Size = new System.Drawing.Size(112, 18);
            this.lblOverPayment.TabIndex = 32;
            this.lblOverPayment.Text = "Over Payment";
            // 
            // lblUnpaidSalary
            // 
            this.lblUnpaidSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnpaidSalary.AutoSize = true;
            this.lblUnpaidSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnpaidSalary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaidSalary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnpaidSalary.Location = new System.Drawing.Point(32, 275);
            this.lblUnpaidSalary.Name = "lblUnpaidSalary";
            this.lblUnpaidSalary.Size = new System.Drawing.Size(111, 18);
            this.lblUnpaidSalary.TabIndex = 23;
            this.lblUnpaidSalary.Text = "Unpaid Salary";
            // 
            // lblUnpaidPension
            // 
            this.lblUnpaidPension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnpaidPension.AutoSize = true;
            this.lblUnpaidPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnpaidPension.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnpaidPension.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnpaidPension.Location = new System.Drawing.Point(32, 320);
            this.lblUnpaidPension.Name = "lblUnpaidPension";
            this.lblUnpaidPension.Size = new System.Drawing.Size(121, 18);
            this.lblUnpaidPension.TabIndex = 25;
            this.lblUnpaidPension.Text = "Unpaid Pension";
            // 
            // PicBoxBarcode
            // 
            this.PicBoxBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicBoxBarcode.BackColor = System.Drawing.Color.White;
            this.PicBoxBarcode.Location = new System.Drawing.Point(125, 163);
            this.PicBoxBarcode.Name = "PicBoxBarcode";
            this.PicBoxBarcode.Size = new System.Drawing.Size(240, 25);
            this.PicBoxBarcode.TabIndex = 6;
            this.PicBoxBarcode.TabStop = false;
            // 
            // empPicBox
            // 
            this.empPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empPicBox.BackColor = System.Drawing.Color.Gainsboro;
            this.empPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empPicBox.Image = ((System.Drawing.Image)(resources.GetObject("empPicBox.Image")));
            this.empPicBox.ImageActive = null;
            this.empPicBox.Location = new System.Drawing.Point(165, 14);
            this.empPicBox.Name = "empPicBox";
            this.empPicBox.Size = new System.Drawing.Size(162, 143);
            this.empPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empPicBox.TabIndex = 4;
            this.empPicBox.TabStop = false;
            this.empPicBox.Zoom = 10;
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
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 32);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.text = "";
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
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bottomButtonPanel
            // 
            this.bottomButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bottomButtonPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottomButtonPanel.Controls.Add(this.btnDelete);
            this.bottomButtonPanel.Controls.Add(this.btnClear);
            this.bottomButtonPanel.Controls.Add(this.btnSave);
            this.bottomButtonPanel.Location = new System.Drawing.Point(447, 449);
            this.bottomButtonPanel.Name = "bottomButtonPanel";
            this.bottomButtonPanel.Size = new System.Drawing.Size(446, 34);
            this.bottomButtonPanel.TabIndex = 49;
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
            // dgvMonthlyDataSearch
            // 
            this.dgvMonthlyDataSearch.AllowUserToAddRows = false;
            this.dgvMonthlyDataSearch.AllowUserToDeleteRows = false;
            this.dgvMonthlyDataSearch.AllowUserToOrderColumns = true;
            this.dgvMonthlyDataSearch.AllowUserToResizeColumns = false;
            this.dgvMonthlyDataSearch.AllowUserToResizeRows = false;
            this.dgvMonthlyDataSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMonthlyDataSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlyDataSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMonthlyDataSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlyDataSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlyDataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyDataSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyDataSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonthlyDataSearch.GridColor = System.Drawing.Color.White;
            this.dgvMonthlyDataSearch.Location = new System.Drawing.Point(0, 41);
            this.dgvMonthlyDataSearch.MultiSelect = false;
            this.dgvMonthlyDataSearch.Name = "dgvMonthlyDataSearch";
            this.dgvMonthlyDataSearch.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlyDataSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonthlyDataSearch.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMonthlyDataSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMonthlyDataSearch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMonthlyDataSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvMonthlyDataSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonthlyDataSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvMonthlyDataSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvMonthlyDataSearch.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMonthlyDataSearch.RowTemplate.ReadOnly = true;
            this.dgvMonthlyDataSearch.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyDataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthlyDataSearch.ShowEditingIcon = false;
            this.dgvMonthlyDataSearch.Size = new System.Drawing.Size(424, 442);
            this.dgvMonthlyDataSearch.TabIndex = 56;
            this.dgvMonthlyDataSearch.DoubleClick += new System.EventHandler(this.dgvMonthlyDataSearch_DoubleClick);
            // 
            // lblEIDinfo
            // 
            this.lblEIDinfo.AutoSize = true;
            this.lblEIDinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEIDinfo.ForeColor = System.Drawing.Color.Red;
            this.lblEIDinfo.Location = new System.Drawing.Point(191, 210);
            this.lblEIDinfo.Name = "lblEIDinfo";
            this.lblEIDinfo.Size = new System.Drawing.Size(165, 15);
            this.lblEIDinfo.TabIndex = 62;
            this.lblEIDinfo.Text = "Employee ID cannot be empty";
            this.lblEIDinfo.Visible = false;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmployeeID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmployeeID.Location = new System.Drawing.Point(194, 230);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(227, 26);
            this.txtEmployeeID.TabIndex = 63;
            // 
            // ucManageMonthlyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgvMonthlyDataSearch);
            this.Controls.Add(this.bottomButtonPanel);
            this.Controls.Add(this.viewEmpPanel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Name = "ucManageMonthlyData";
            this.Size = new System.Drawing.Size(910, 481);
            this.Load += new System.EventHandler(this.UcManageMonthlyData_Load);
            this.viewEmpPanel.ResumeLayout(false);
            this.viewEmpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empPicBox)).EndInit();
            this.bottomButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyDataSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel viewEmpPanel;

        public Label lblFullName { get; private set; }

        private System.Windows.Forms.Label lblEmployeeID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtActingAllowance;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOverPayment;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUnpaidSalary;
        private System.Windows.Forms.Label lblActingAllowance;
        private System.Windows.Forms.Label lblOverPayment;
        private System.Windows.Forms.Label lblUnpaidSalary;
        private System.Windows.Forms.Label lblUnpaidPension;
        private System.Windows.Forms.PictureBox PicBoxBarcode;
        private Bunifu.Framework.UI.BunifuImageButton empPicBox;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIncentive;
        private System.Windows.Forms.Label lblIncentive;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFine;
        private System.Windows.Forms.Label lblFine;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourtCase;
        private System.Windows.Forms.Label lblCourtCase;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMedical;
        private System.Windows.Forms.Label lblMedical;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOther;
        private System.Windows.Forms.Label lblOther;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSaving;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMobile;
        private System.Windows.Forms.Label lblSaving;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Panel bottomButtonPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUnpaidPension;
        private System.Windows.Forms.Label txtsEmployeeID;
        private System.Windows.Forms.DataGridView dgvMonthlyDataSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUnpaidTax;
        private System.Windows.Forms.Label lblUnpaidTax;
        private Label lblfullName;
        private Label lblEIDinfo;
        private TextBox txtEmployeeID;
    }
}
