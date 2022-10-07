using Bunifu.Framework.UI;

namespace Payroll_Management_System
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.userPicBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRole = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ucPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.btnMaximize);
            this.topPanel.Controls.Add(this.lblHeader);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1184, 34);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDoubleClick);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.Location = new System.Drawing.Point(1022, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(54, 34);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click_1);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMaximize.Location = new System.Drawing.Point(1076, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(54, 34);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1130, 34);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Payroll Management System";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Click += new System.EventHandler(this.LblHeader_Click);
            this.lblHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LblHeader_MouseDoubleClick);
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Location = new System.Drawing.Point(1130, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.leftPanel.Controls.Add(this.btnSchedule);
            this.leftPanel.Controls.Add(this.btnHelp);
            this.leftPanel.Controls.Add(this.btnReport);
            this.leftPanel.Controls.Add(this.btnView);
            this.leftPanel.Controls.Add(this.btnManage);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 120);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 561);
            this.leftPanel.TabIndex = 2;
            this.leftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(0, 229);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(200, 40);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.TabStop = false;
            this.btnSchedule.Text = "Schedule OT";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 275);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(200, 40);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 183);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 40);
            this.btnReport.TabIndex = 2;
            this.btnReport.TabStop = false;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(0, 137);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(200, 40);
            this.btnView.TabIndex = 1;
            this.btnView.TabStop = false;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // btnManage
            // 
            this.btnManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(0, 91);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(200, 40);
            this.btnManage.TabIndex = 0;
            this.btnManage.TabStop = false;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.BtnManage_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.logoPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPicBox.BackgroundImage")));
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPicBox.Location = new System.Drawing.Point(-3, -10);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(203, 96);
            this.logoPicBox.TabIndex = 0;
            this.logoPicBox.TabStop = false;
            this.logoPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPicBox_MouseDown);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.infoPanel.Controls.Add(this.btnConnection);
            this.infoPanel.Controls.Add(this.lblTime);
            this.infoPanel.Controls.Add(this.userPicBox);
            this.infoPanel.Controls.Add(this.lblRole);
            this.infoPanel.Controls.Add(this.lblUsername);
            this.infoPanel.Controls.Add(this.logoPicBox);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 34);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1184, 86);
            this.infoPanel.TabIndex = 3;
            this.infoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseDown);
            // 
            // btnConnection
            // 
            this.btnConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnection.AutoSize = true;
            this.btnConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.Color.Lime;
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnConnection.Location = new System.Drawing.Point(938, 48);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(138, 38);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.TabStop = false;
            this.btnConnection.Text = "Connected";
            this.btnConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Image = ((System.Drawing.Image)(resources.GetObject("lblTime.Image")));
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTime.Location = new System.Drawing.Point(206, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(96, 43);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.LblTiime_Click);
            // 
            // userPicBox
            // 
            this.userPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.userPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPicBox.Image = global::Payroll_Management_System.Properties.Resources.icons8_user_96px;
            this.userPicBox.ImageActive = null;
            this.userPicBox.Location = new System.Drawing.Point(1101, 3);
            this.userPicBox.Name = "userPicBox";
            this.userPicBox.Size = new System.Drawing.Size(71, 75);
            this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicBox.TabIndex = 3;
            this.userPicBox.TabStop = false;
            this.userPicBox.Zoom = 10;
            this.userPicBox.Click += new System.EventHandler(this.UserPicBox_Click);
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(785, 32);
            this.lblRole.Name = "lblRole";
            this.lblRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRole.Size = new System.Drawing.Size(291, 17);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Manager";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(723, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(353, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Elias Taye";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsername.Click += new System.EventHandler(this.BunifuCustomLabel1_Click);
            // 
            // ucPanel
            // 
            this.ucPanel.AutoSize = true;
            this.ucPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.ucPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ucPanel.Location = new System.Drawing.Point(200, 120);
            this.ucPanel.Name = "ucPanel";
            this.ucPanel.Size = new System.Drawing.Size(984, 561);
            this.ucPanel.TabIndex = 4;
            this.ucPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UcPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.ControlBox = false;
            this.Controls.Add(this.ucPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Form_MouseDown);
            this.topPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Panel infoPanel;
        private BunifuCustomLabel lblUsername;
        private BunifuImageButton userPicBox;
        private BunifuCustomLabel lblRole;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Panel ucPanel;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSchedule;
    }
}