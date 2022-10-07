namespace Payroll_Management_System.Forms
{
    partial class userSelfManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSelfManage));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblDisplayUserName = new System.Windows.Forms.Label();
            this.lblDisplayLastName = new System.Windows.Forms.Label();
            this.lblDisplayfirstName = new System.Windows.Forms.Label();
            this.lblDisplayUserId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.userPicBox = new Bunifu.Framework.UI.BunifuImageButton();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnPicChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(346, 383);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 29);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(418, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 29);
            this.btnClose.TabIndex = 30;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.btnChangePassword.Location = new System.Drawing.Point(145, 386);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(156, 23);
            this.btnChangePassword.TabIndex = 29;
            this.btnChangePassword.Text = "Change Pasword";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // lblDisplayUserName
            // 
            this.lblDisplayUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayUserName.ForeColor = System.Drawing.Color.White;
            this.lblDisplayUserName.Location = new System.Drawing.Point(142, 346);
            this.lblDisplayUserName.Name = "lblDisplayUserName";
            this.lblDisplayUserName.Size = new System.Drawing.Size(228, 16);
            this.lblDisplayUserName.TabIndex = 28;
            this.lblDisplayUserName.Text = "name";
            // 
            // lblDisplayLastName
            // 
            this.lblDisplayLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayLastName.ForeColor = System.Drawing.Color.White;
            this.lblDisplayLastName.Location = new System.Drawing.Point(142, 306);
            this.lblDisplayLastName.Name = "lblDisplayLastName";
            this.lblDisplayLastName.Size = new System.Drawing.Size(228, 16);
            this.lblDisplayLastName.TabIndex = 27;
            this.lblDisplayLastName.Text = "name";
            // 
            // lblDisplayfirstName
            // 
            this.lblDisplayfirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayfirstName.ForeColor = System.Drawing.Color.White;
            this.lblDisplayfirstName.Location = new System.Drawing.Point(142, 264);
            this.lblDisplayfirstName.Name = "lblDisplayfirstName";
            this.lblDisplayfirstName.Size = new System.Drawing.Size(228, 16);
            this.lblDisplayfirstName.TabIndex = 26;
            this.lblDisplayfirstName.Text = "name";
            this.lblDisplayfirstName.Click += new System.EventHandler(this.LblDisplayfirstName_Click);
            // 
            // lblDisplayUserId
            // 
            this.lblDisplayUserId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayUserId.ForeColor = System.Drawing.Color.White;
            this.lblDisplayUserId.Location = new System.Drawing.Point(142, 219);
            this.lblDisplayUserId.Name = "lblDisplayUserId";
            this.lblDisplayUserId.Size = new System.Drawing.Size(228, 16);
            this.lblDisplayUserId.TabIndex = 25;
            this.lblDisplayUserId.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(19, 389);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(199, 174);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(68, 16);
            this.lblRole.TabIndex = 20;
            this.lblRole.Text = "Manager";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(19, 346);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(78, 16);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "User Name";
            // 
            // userPicBox
            // 
            this.userPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.userPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPicBox.Image = ((System.Drawing.Image)(resources.GetObject("userPicBox.Image")));
            this.userPicBox.ImageActive = null;
            this.userPicBox.Location = new System.Drawing.Point(132, 4);
            this.userPicBox.Name = "userPicBox";
            this.userPicBox.Size = new System.Drawing.Size(230, 167);
            this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicBox.TabIndex = 18;
            this.userPicBox.TabStop = false;
            this.userPicBox.Zoom = 10;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Location = new System.Drawing.Point(-1, 418);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(468, 150);
            this.bottomPanel.TabIndex = 32;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnPicChange
            // 
            this.btnPicChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPicChange.BackColor = System.Drawing.Color.Transparent;
            this.btnPicChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicChange.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicChange.ForeColor = System.Drawing.Color.White;
            this.btnPicChange.Location = new System.Drawing.Point(363, 143);
            this.btnPicChange.Name = "btnPicChange";
            this.btnPicChange.Size = new System.Drawing.Size(78, 28);
            this.btnPicChange.TabIndex = 33;
            this.btnPicChange.Text = "Change";
            this.btnPicChange.UseVisualStyleBackColor = false;
            this.btnPicChange.Click += new System.EventHandler(this.BtnPicChange_Click);
            // 
            // userSelfManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(468, 418);
            this.ControlBox = false;
            this.Controls.Add(this.btnPicChange);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblDisplayUserName);
            this.Controls.Add(this.lblDisplayLastName);
            this.Controls.Add(this.lblDisplayfirstName);
            this.Controls.Add(this.lblDisplayUserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.userPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userSelfManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.UserSelfManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblDisplayUserName;
        private System.Windows.Forms.Label lblDisplayLastName;
        private System.Windows.Forms.Label lblDisplayfirstName;
        private System.Windows.Forms.Label lblDisplayUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUser;
        private Bunifu.Framework.UI.BunifuImageButton userPicBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button btnPicChange;
    }
}