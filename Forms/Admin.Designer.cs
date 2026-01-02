namespace Login
{
    partial class Admin
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.labelUID = new System.Windows.Forms.Label();
            this.labelUPW = new System.Windows.Forms.Label();
            this.txtUPW = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.btn_removeSelectedUser = new System.Windows.Forms.Button();
            this.btn_updateUserInfo = new System.Windows.Forms.Button();
            this.listBox_users = new System.Windows.Forms.ListBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(38, 392);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.Location = new System.Drawing.Point(159, 28);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(129, 23);
            this.btn_addUser.TabIndex = 3;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(35, 28);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(46, 13);
            this.labelUID.TabIndex = 8;
            this.labelUID.Text = "User ID:";
            // 
            // labelUPW
            // 
            this.labelUPW.AutoSize = true;
            this.labelUPW.Location = new System.Drawing.Point(35, 67);
            this.labelUPW.Name = "labelUPW";
            this.labelUPW.Size = new System.Drawing.Size(53, 13);
            this.labelUPW.TabIndex = 9;
            this.labelUPW.Text = "Password";
            // 
            // txtUPW
            // 
            this.txtUPW.Location = new System.Drawing.Point(38, 83);
            this.txtUPW.Name = "txtUPW";
            this.txtUPW.Size = new System.Drawing.Size(100, 20);
            this.txtUPW.TabIndex = 11;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(38, 44);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(100, 20);
            this.txtUID.TabIndex = 10;
            // 
            // btn_removeSelectedUser
            // 
            this.btn_removeSelectedUser.Location = new System.Drawing.Point(156, 86);
            this.btn_removeSelectedUser.Name = "btn_removeSelectedUser";
            this.btn_removeSelectedUser.Size = new System.Drawing.Size(129, 23);
            this.btn_removeSelectedUser.TabIndex = 13;
            this.btn_removeSelectedUser.Text = "Remove Selected User";
            this.btn_removeSelectedUser.UseVisualStyleBackColor = true;
            this.btn_removeSelectedUser.Click += new System.EventHandler(this.btn_removeSelectedUser_Click);
            // 
            // btn_updateUserInfo
            // 
            this.btn_updateUserInfo.Location = new System.Drawing.Point(159, 57);
            this.btn_updateUserInfo.Name = "btn_updateUserInfo";
            this.btn_updateUserInfo.Size = new System.Drawing.Size(129, 23);
            this.btn_updateUserInfo.TabIndex = 14;
            this.btn_updateUserInfo.Text = "Update User Info";
            this.btn_updateUserInfo.UseVisualStyleBackColor = true;
            this.btn_updateUserInfo.Click += new System.EventHandler(this.btn_updateUserInfo_Click);
            // 
            // listBox_users
            // 
            this.listBox_users.FormattingEnabled = true;
            this.listBox_users.Location = new System.Drawing.Point(35, 122);
            this.listBox_users.Name = "listBox_users";
            this.listBox_users.Size = new System.Drawing.Size(250, 264);
            this.listBox_users.TabIndex = 15;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(194, 392);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 21);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.listBox_users);
            this.Controls.Add(this.btn_updateUserInfo);
            this.Controls.Add(this.btn_removeSelectedUser);
            this.Controls.Add(this.txtUPW);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.labelUPW);
            this.Controls.Add(this.labelUID);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.btn_logout);
            this.Name = "Admin";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.Label labelUPW;
        private System.Windows.Forms.TextBox txtUPW;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Button btn_removeSelectedUser;
        private System.Windows.Forms.Button btn_updateUserInfo;
        private System.Windows.Forms.ListBox listBox_users;
        private System.Windows.Forms.Button btn_exit;
    }
}