namespace HMS
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.lblmember = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblstaff = new System.Windows.Forms.Label();
            this.bttnmview = new System.Windows.Forms.Button();
            this.bttndview = new System.Windows.Forms.Button();
            this.bttnsview = new System.Windows.Forms.Button();
            this.bttnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmember
            // 
            this.lblmember.AutoSize = true;
            this.lblmember.BackColor = System.Drawing.Color.White;
            this.lblmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmember.Location = new System.Drawing.Point(35, 99);
            this.lblmember.Name = "lblmember";
            this.lblmember.Size = new System.Drawing.Size(156, 20);
            this.lblmember.TabIndex = 0;
            this.lblmember.Text = "MemberDatabase";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.BackColor = System.Drawing.Color.White;
            this.lbldoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctor.Location = new System.Drawing.Point(328, 99);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(146, 20);
            this.lbldoctor.TabIndex = 1;
            this.lbldoctor.Text = "DoctorDatabase";
            // 
            // lblstaff
            // 
            this.lblstaff.AutoSize = true;
            this.lblstaff.BackColor = System.Drawing.Color.White;
            this.lblstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaff.Location = new System.Drawing.Point(619, 99);
            this.lblstaff.Name = "lblstaff";
            this.lblstaff.Size = new System.Drawing.Size(129, 20);
            this.lblstaff.TabIndex = 2;
            this.lblstaff.Text = "StaffDatabase";
            // 
            // bttnmview
            // 
            this.bttnmview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnmview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnmview.Location = new System.Drawing.Point(74, 152);
            this.bttnmview.Name = "bttnmview";
            this.bttnmview.Size = new System.Drawing.Size(75, 34);
            this.bttnmview.TabIndex = 3;
            this.bttnmview.Text = "View";
            this.bttnmview.UseVisualStyleBackColor = false;
            this.bttnmview.Click += new System.EventHandler(this.bttnmview_Click);
            // 
            // bttndview
            // 
            this.bttndview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttndview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttndview.Location = new System.Drawing.Point(363, 152);
            this.bttndview.Name = "bttndview";
            this.bttndview.Size = new System.Drawing.Size(75, 34);
            this.bttndview.TabIndex = 4;
            this.bttndview.Text = "View";
            this.bttndview.UseVisualStyleBackColor = false;
            this.bttndview.Click += new System.EventHandler(this.bttndview_Click);
            // 
            // bttnsview
            // 
            this.bttnsview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsview.Location = new System.Drawing.Point(645, 151);
            this.bttnsview.Name = "bttnsview";
            this.bttnsview.Size = new System.Drawing.Size(75, 35);
            this.bttnsview.TabIndex = 5;
            this.bttnsview.Text = "View";
            this.bttnsview.UseVisualStyleBackColor = false;
            this.bttnsview.Click += new System.EventHandler(this.bttnsview_Click);
            // 
            // bttnlogout
            // 
            this.bttnlogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnlogout.Location = new System.Drawing.Point(294, 225);
            this.bttnlogout.Name = "bttnlogout";
            this.bttnlogout.Size = new System.Drawing.Size(215, 38);
            this.bttnlogout.TabIndex = 6;
            this.bttnlogout.Text = "LogOut";
            this.bttnlogout.UseVisualStyleBackColor = false;
            this.bttnlogout.Click += new System.EventHandler(this.bttnlogout_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 344);
            this.Controls.Add(this.bttnlogout);
            this.Controls.Add(this.bttnsview);
            this.Controls.Add(this.bttndview);
            this.Controls.Add(this.bttnmview);
            this.Controls.Add(this.lblstaff);
            this.Controls.Add(this.lbldoctor);
            this.Controls.Add(this.lblmember);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmember;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblstaff;
        private System.Windows.Forms.Button bttnmview;
        private System.Windows.Forms.Button bttndview;
        private System.Windows.Forms.Button bttnsview;
        private System.Windows.Forms.Button bttnlogout;
    }
}