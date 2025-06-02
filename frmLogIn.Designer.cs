namespace MyStore
{
    partial class frmLogIn
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tmLoginn = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkFgtpass = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lnkReg = new System.Windows.Forms.LinkLabel();
            this.lblReg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmLoginn
            // 
            this.tmLoginn.Interval = 1000;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkFgtpass);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.btnLogIn);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lnkFgtpass
            // 
            this.lnkFgtpass.AutoSize = true;
            this.lnkFgtpass.Location = new System.Drawing.Point(241, 189);
            this.lnkFgtpass.Name = "lnkFgtpass";
            this.lnkFgtpass.Size = new System.Drawing.Size(122, 17);
            this.lnkFgtpass.TabIndex = 4;
            this.lnkFgtpass.TabStop = true;
            this.lnkFgtpass.Text = "Forgot Password?";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(152, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(211, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.UseMnemonic = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(211, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(23, 67);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseMnemonic = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(152, 159);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(79, 27);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lnkReg
            // 
            this.lnkReg.AutoSize = true;
            this.lnkReg.Location = new System.Drawing.Point(156, 262);
            this.lnkReg.Name = "lnkReg";
            this.lnkReg.Size = new System.Drawing.Size(61, 17);
            this.lnkReg.TabIndex = 5;
            this.lnkReg.TabStop = true;
            this.lnkReg.Text = "Register";
            this.lnkReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReg_LinkClicked);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(12, 262);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(138, 17);
            this.lblReg.TabIndex = 5;
            this.lblReg.Text = "Don\'t have account?";
            this.lblReg.UseMnemonic = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 288);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lnkReg);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogIn";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer tmLoginn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.LinkLabel lnkFgtpass;
        private System.Windows.Forms.LinkLabel lnkReg;
        private System.Windows.Forms.Label lblReg;
    }
}