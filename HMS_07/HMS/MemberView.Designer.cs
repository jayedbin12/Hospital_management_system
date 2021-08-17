namespace HMS
{
    partial class MemberView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberView));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.bttnsearch = new System.Windows.Forms.Button();
            this.dgvdoctorview = new System.Windows.Forms.DataGridView();
            this.lblid = new System.Windows.Forms.Label();
            this.lbldoctorname = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtpatientid = new System.Windows.Forms.TextBox();
            this.txtdoctorname = new System.Windows.Forms.TextBox();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.bttnlogout = new System.Windows.Forms.Button();
            this.bttnsubmit = new System.Windows.Forms.Button();
            this.bttnshow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctorview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(624, 315);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(122, 22);
            this.txtsearch.TabIndex = 0;
            // 
            // bttnsearch
            // 
            this.bttnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsearch.Location = new System.Drawing.Point(587, 362);
            this.bttnsearch.Name = "bttnsearch";
            this.bttnsearch.Size = new System.Drawing.Size(193, 34);
            this.bttnsearch.TabIndex = 1;
            this.bttnsearch.Text = "SEARCH";
            this.bttnsearch.UseVisualStyleBackColor = false;
            this.bttnsearch.Click += new System.EventHandler(this.bttnsearch_Click);
            // 
            // dgvdoctorview
            // 
            this.dgvdoctorview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdoctorview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoctorview.Location = new System.Drawing.Point(566, 25);
            this.dgvdoctorview.Name = "dgvdoctorview";
            this.dgvdoctorview.ReadOnly = true;
            this.dgvdoctorview.RowTemplate.Height = 24;
            this.dgvdoctorview.Size = new System.Drawing.Size(508, 245);
            this.dgvdoctorview.TabIndex = 2;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.White;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(46, 50);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(93, 20);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "Patient ID";
            // 
            // lbldoctorname
            // 
            this.lbldoctorname.AutoSize = true;
            this.lbldoctorname.BackColor = System.Drawing.Color.White;
            this.lbldoctorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoctorname.Location = new System.Drawing.Point(46, 99);
            this.lbldoctorname.Name = "lbldoctorname";
            this.lbldoctorname.Size = new System.Drawing.Size(120, 20);
            this.lbldoctorname.TabIndex = 4;
            this.lbldoctorname.Text = "Doctor Name";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.White;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(46, 151);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(159, 20);
            this.lbldate.TabIndex = 5;
            this.lbldate.Text = "Appiontment Date";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.White;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(46, 209);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(122, 20);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Patient Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtpatientid
            // 
            this.txtpatientid.Location = new System.Drawing.Point(230, 48);
            this.txtpatientid.Name = "txtpatientid";
            this.txtpatientid.Size = new System.Drawing.Size(260, 22);
            this.txtpatientid.TabIndex = 8;
            // 
            // txtdoctorname
            // 
            this.txtdoctorname.Location = new System.Drawing.Point(230, 97);
            this.txtdoctorname.Name = "txtdoctorname";
            this.txtdoctorname.Size = new System.Drawing.Size(260, 22);
            this.txtdoctorname.TabIndex = 9;
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(230, 207);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(260, 22);
            this.txtpatientname.TabIndex = 10;
            // 
            // bttnlogout
            // 
            this.bttnlogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnlogout.Location = new System.Drawing.Point(31, 362);
            this.bttnlogout.Name = "bttnlogout";
            this.bttnlogout.Size = new System.Drawing.Size(93, 33);
            this.bttnlogout.TabIndex = 11;
            this.bttnlogout.Text = "LogOut";
            this.bttnlogout.UseVisualStyleBackColor = false;
            this.bttnlogout.Click += new System.EventHandler(this.bttnlogout_Click);
            // 
            // bttnsubmit
            // 
            this.bttnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsubmit.Location = new System.Drawing.Point(291, 270);
            this.bttnsubmit.Name = "bttnsubmit";
            this.bttnsubmit.Size = new System.Drawing.Size(135, 33);
            this.bttnsubmit.TabIndex = 12;
            this.bttnsubmit.Text = "Submit";
            this.bttnsubmit.UseVisualStyleBackColor = false;
            this.bttnsubmit.Click += new System.EventHandler(this.bttnsubmit_Click);
            // 
            // bttnshow
            // 
            this.bttnshow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnshow.Location = new System.Drawing.Point(873, 357);
            this.bttnshow.Name = "bttnshow";
            this.bttnshow.Size = new System.Drawing.Size(121, 38);
            this.bttnshow.TabIndex = 13;
            this.bttnshow.Text = "Show";
            this.bttnshow.UseVisualStyleBackColor = false;
            this.bttnshow.Click += new System.EventHandler(this.bttnshow_Click);
            // 
            // MemberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1095, 448);
            this.Controls.Add(this.bttnshow);
            this.Controls.Add(this.bttnsubmit);
            this.Controls.Add(this.bttnlogout);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.txtdoctorname);
            this.Controls.Add(this.txtpatientid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbldoctorname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dgvdoctorview);
            this.Controls.Add(this.bttnsearch);
            this.Controls.Add(this.txtsearch);
            this.Name = "MemberView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctorview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button bttnsearch;
        private System.Windows.Forms.DataGridView dgvdoctorview;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldoctorname;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtpatientid;
        private System.Windows.Forms.TextBox txtdoctorname;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.Button bttnlogout;
        private System.Windows.Forms.Button bttnsubmit;
        private System.Windows.Forms.Button bttnshow;
    }
}