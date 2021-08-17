namespace HMS
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.bttnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsignup = new System.Windows.Forms.Label();
            this.bttnsignup = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffLogInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorLogInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(214, 77);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(108, 24);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "UserName";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(220, 132);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(100, 24);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Location = new System.Drawing.Point(366, 75);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(134, 22);
            this.txtusername.TabIndex = 2;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.Location = new System.Drawing.Point(366, 130);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(134, 22);
            this.txtpassword.TabIndex = 3;
            // 
            // bttnlogin
            // 
            this.bttnlogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnlogin.Location = new System.Drawing.Point(262, 180);
            this.bttnlogin.Name = "bttnlogin";
            this.bttnlogin.Size = new System.Drawing.Size(167, 38);
            this.bttnlogin.TabIndex = 4;
            this.bttnlogin.Text = "LogIn";
            this.bttnlogin.UseVisualStyleBackColor = false;
            this.bttnlogin.Click += new System.EventHandler(this.bttnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup.Location = new System.Drawing.Point(183, 251);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(174, 25);
            this.lblsignup.TabIndex = 6;
            this.lblsignup.Text = "Create Account?";
            // 
            // bttnsignup
            // 
            this.bttnsignup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsignup.Location = new System.Drawing.Point(388, 240);
            this.bttnsignup.Name = "bttnsignup";
            this.bttnsignup.Size = new System.Drawing.Size(130, 46);
            this.bttnsignup.TabIndex = 7;
            this.bttnsignup.Text = "SignUp";
            this.bttnsignup.UseVisualStyleBackColor = false;
            this.bttnsignup.Click += new System.EventHandler(this.bttnsignup_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 32);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.staffLogInToolStripMenuItem,
            this.doctorLogInToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(149, 29);
            this.toolStripDropDownButton1.Text = "OthersLogIn";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.logInToolStripMenuItem.Text = "Admin LogIn";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // staffLogInToolStripMenuItem
            // 
            this.staffLogInToolStripMenuItem.Name = "staffLogInToolStripMenuItem";
            this.staffLogInToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.staffLogInToolStripMenuItem.Text = "Staff logIn";
            this.staffLogInToolStripMenuItem.Click += new System.EventHandler(this.staffLogInToolStripMenuItem_Click);
            // 
            // doctorLogInToolStripMenuItem
            // 
            this.doctorLogInToolStripMenuItem.Name = "doctorLogInToolStripMenuItem";
            this.doctorLogInToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.doctorLogInToolStripMenuItem.Text = "Doctor LogIn";
            this.doctorLogInToolStripMenuItem.Click += new System.EventHandler(this.doctorLogInToolStripMenuItem_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(738, 337);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bttnsignup);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button bttnlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.Button bttnsignup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffLogInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorLogInToolStripMenuItem;
    }
}

