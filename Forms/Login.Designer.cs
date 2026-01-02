namespace Login
{
    partial class Login
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
            this.labelUID = new System.Windows.Forms.Label();
            this.labelUPW = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtUPW = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.chk_showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(64, 32);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(46, 13);
            this.labelUID.TabIndex = 0;
            this.labelUID.Text = "User ID:";
            // 
            // labelUPW
            // 
            this.labelUPW.AutoSize = true;
            this.labelUPW.Location = new System.Drawing.Point(185, 32);
            this.labelUPW.Name = "labelUPW";
            this.labelUPW.Size = new System.Drawing.Size(53, 13);
            this.labelUPW.TabIndex = 1;
            this.labelUPW.Text = "Password";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(67, 48);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(100, 20);
            this.txtUID.TabIndex = 4;
            // 
            // txtUPW
            // 
            this.txtUPW.Location = new System.Drawing.Point(188, 48);
            this.txtUPW.Name = "txtUPW";
            this.txtUPW.PasswordChar = '#';
            this.txtUPW.Size = new System.Drawing.Size(100, 20);
            this.txtUPW.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(131, 74);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(81, 26);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chk_showPassword
            // 
            this.chk_showPassword.AutoSize = true;
            this.chk_showPassword.Location = new System.Drawing.Point(294, 51);
            this.chk_showPassword.Name = "chk_showPassword";
            this.chk_showPassword.Size = new System.Drawing.Size(15, 14);
            this.chk_showPassword.TabIndex = 7;
            this.chk_showPassword.UseVisualStyleBackColor = true;
            this.chk_showPassword.CheckedChanged += new System.EventHandler(this.chk_showPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 147);
            this.Controls.Add(this.chk_showPassword);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtUPW);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.labelUPW);
            this.Controls.Add(this.labelUID);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.Label labelUPW;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtUPW;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chk_showPassword;
    }
}

