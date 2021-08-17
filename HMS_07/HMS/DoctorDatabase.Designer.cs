namespace HMS
{
    partial class DoctorDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDatabase));
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblspeciality = new System.Windows.Forms.Label();
            this.lblvisitinghours = new System.Windows.Forms.Label();
            this.lblVisitingFee = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.txtuniqueid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtspecility = new System.Windows.Forms.TextBox();
            this.txtvisitinghours = new System.Windows.Forms.TextBox();
            this.txtvisitingfee = new System.Windows.Forms.TextBox();
            this.txtdegree = new System.Windows.Forms.TextBox();
            this.dgvdoctordatabase = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.bttnsearch = new System.Windows.Forms.Button();
            this.bttnshow = new System.Windows.Forms.Button();
            this.bttndelete = new System.Windows.Forms.Button();
            this.bttninsert = new System.Windows.Forms.Button();
            this.bttnedit = new System.Windows.Forms.Button();
            this.bttnlogout = new System.Windows.Forms.Button();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adminPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctordatabase)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.White;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(76, 43);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(86, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "UniqueID";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.White;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(78, 83);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 20);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.White;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(78, 122);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(70, 20);
            this.lblgender.TabIndex = 2;
            this.lblgender.Text = "Gender";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.White;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(78, 161);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(56, 20);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "Email";
            // 
            // lblspeciality
            // 
            this.lblspeciality.AutoSize = true;
            this.lblspeciality.BackColor = System.Drawing.Color.White;
            this.lblspeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspeciality.Location = new System.Drawing.Point(77, 207);
            this.lblspeciality.Name = "lblspeciality";
            this.lblspeciality.Size = new System.Drawing.Size(91, 20);
            this.lblspeciality.TabIndex = 4;
            this.lblspeciality.Text = "Speciality";
            // 
            // lblvisitinghours
            // 
            this.lblvisitinghours.AutoSize = true;
            this.lblvisitinghours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisitinghours.Location = new System.Drawing.Point(76, 250);
            this.lblvisitinghours.Name = "lblvisitinghours";
            this.lblvisitinghours.Size = new System.Drawing.Size(123, 20);
            this.lblvisitinghours.TabIndex = 5;
            this.lblvisitinghours.Text = "VisitingHours";
            // 
            // lblVisitingFee
            // 
            this.lblVisitingFee.AutoSize = true;
            this.lblVisitingFee.BackColor = System.Drawing.Color.White;
            this.lblVisitingFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitingFee.Location = new System.Drawing.Point(77, 293);
            this.lblVisitingFee.Name = "lblVisitingFee";
            this.lblVisitingFee.Size = new System.Drawing.Size(103, 20);
            this.lblVisitingFee.TabIndex = 6;
            this.lblVisitingFee.Text = "VisitingFee";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.BackColor = System.Drawing.Color.White;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(77, 336);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(70, 20);
            this.lblDegree.TabIndex = 7;
            this.lblDegree.Text = "Degree";
            // 
            // txtuniqueid
            // 
            this.txtuniqueid.Location = new System.Drawing.Point(235, 41);
            this.txtuniqueid.Name = "txtuniqueid";
            this.txtuniqueid.Size = new System.Drawing.Size(138, 22);
            this.txtuniqueid.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(235, 81);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(138, 22);
            this.txtname.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(235, 161);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(138, 22);
            this.txtemail.TabIndex = 11;
            // 
            // txtspecility
            // 
            this.txtspecility.Location = new System.Drawing.Point(235, 207);
            this.txtspecility.Name = "txtspecility";
            this.txtspecility.Size = new System.Drawing.Size(138, 22);
            this.txtspecility.TabIndex = 12;
            // 
            // txtvisitinghours
            // 
            this.txtvisitinghours.Location = new System.Drawing.Point(235, 250);
            this.txtvisitinghours.Name = "txtvisitinghours";
            this.txtvisitinghours.Size = new System.Drawing.Size(138, 22);
            this.txtvisitinghours.TabIndex = 13;
            // 
            // txtvisitingfee
            // 
            this.txtvisitingfee.Location = new System.Drawing.Point(235, 293);
            this.txtvisitingfee.Name = "txtvisitingfee";
            this.txtvisitingfee.Size = new System.Drawing.Size(138, 22);
            this.txtvisitingfee.TabIndex = 14;
            // 
            // txtdegree
            // 
            this.txtdegree.Location = new System.Drawing.Point(235, 334);
            this.txtdegree.Name = "txtdegree";
            this.txtdegree.Size = new System.Drawing.Size(138, 22);
            this.txtdegree.TabIndex = 15;
            // 
            // dgvdoctordatabase
            // 
            this.dgvdoctordatabase.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdoctordatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoctordatabase.Location = new System.Drawing.Point(593, 51);
            this.dgvdoctordatabase.Name = "dgvdoctordatabase";
            this.dgvdoctordatabase.RowTemplate.Height = 24;
            this.dgvdoctordatabase.Size = new System.Drawing.Size(502, 262);
            this.dgvdoctordatabase.TabIndex = 16;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(413, 205);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(159, 22);
            this.txtsearch.TabIndex = 17;
            // 
            // bttnsearch
            // 
            this.bttnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsearch.Location = new System.Drawing.Point(445, 241);
            this.bttnsearch.Name = "bttnsearch";
            this.bttnsearch.Size = new System.Drawing.Size(90, 39);
            this.bttnsearch.TabIndex = 18;
            this.bttnsearch.Text = "Search";
            this.bttnsearch.UseVisualStyleBackColor = false;
            this.bttnsearch.Click += new System.EventHandler(this.bttnsearch_Click);
            // 
            // bttnshow
            // 
            this.bttnshow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnshow.Location = new System.Drawing.Point(787, 334);
            this.bttnshow.Name = "bttnshow";
            this.bttnshow.Size = new System.Drawing.Size(118, 35);
            this.bttnshow.TabIndex = 19;
            this.bttnshow.Text = "Show";
            this.bttnshow.UseVisualStyleBackColor = false;
            this.bttnshow.Click += new System.EventHandler(this.bttnshow_Click);
            // 
            // bttndelete
            // 
            this.bttndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttndelete.Location = new System.Drawing.Point(43, 388);
            this.bttndelete.Name = "bttndelete";
            this.bttndelete.Size = new System.Drawing.Size(104, 36);
            this.bttndelete.TabIndex = 20;
            this.bttndelete.Text = "Delete";
            this.bttndelete.UseVisualStyleBackColor = false;
            this.bttndelete.Click += new System.EventHandler(this.bttndelete_Click);
            // 
            // bttninsert
            // 
            this.bttninsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttninsert.Location = new System.Drawing.Point(205, 388);
            this.bttninsert.Name = "bttninsert";
            this.bttninsert.Size = new System.Drawing.Size(100, 36);
            this.bttninsert.TabIndex = 21;
            this.bttninsert.Text = "Insert";
            this.bttninsert.UseVisualStyleBackColor = false;
            this.bttninsert.Click += new System.EventHandler(this.bttninsert_Click);
            // 
            // bttnedit
            // 
            this.bttnedit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnedit.Location = new System.Drawing.Point(371, 388);
            this.bttnedit.Name = "bttnedit";
            this.bttnedit.Size = new System.Drawing.Size(94, 36);
            this.bttnedit.TabIndex = 22;
            this.bttnedit.Text = "Edit";
            this.bttnedit.UseVisualStyleBackColor = false;
            this.bttnedit.Click += new System.EventHandler(this.bttnedit_Click);
            // 
            // bttnlogout
            // 
            this.bttnlogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnlogout.Location = new System.Drawing.Point(995, 355);
            this.bttnlogout.Name = "bttnlogout";
            this.bttnlogout.Size = new System.Drawing.Size(100, 43);
            this.bttnlogout.TabIndex = 23;
            this.bttnlogout.Text = "Logout";
            this.bttnlogout.UseVisualStyleBackColor = false;
            this.bttnlogout.Click += new System.EventHandler(this.bttnlogout_Click);
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmale.ForeColor = System.Drawing.Color.Black;
            this.radioButtonmale.Location = new System.Drawing.Point(235, 118);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(70, 24);
            this.radioButtonmale.TabIndex = 24;
            this.radioButtonmale.TabStop = true;
            this.radioButtonmale.Text = "Male";
            this.radioButtonmale.UseVisualStyleBackColor = true;
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonfemale.ForeColor = System.Drawing.Color.Black;
            this.radioButtonfemale.Location = new System.Drawing.Point(324, 120);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(91, 24);
            this.radioButtonfemale.TabIndex = 25;
            this.radioButtonfemale.TabStop = true;
            this.radioButtonfemale.Text = "Female";
            this.radioButtonfemale.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1129, 27);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminPageToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(56, 24);
            this.toolStripDropDownButton1.Text = "Back";
            // 
            // adminPageToolStripMenuItem
            // 
            this.adminPageToolStripMenuItem.Name = "adminPageToolStripMenuItem";
            this.adminPageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.adminPageToolStripMenuItem.Text = "AdminPage";
            this.adminPageToolStripMenuItem.Click += new System.EventHandler(this.adminPageToolStripMenuItem_Click);
            // 
            // DoctorDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1129, 436);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.radioButtonfemale);
            this.Controls.Add(this.radioButtonmale);
            this.Controls.Add(this.bttnlogout);
            this.Controls.Add(this.bttnedit);
            this.Controls.Add(this.bttninsert);
            this.Controls.Add(this.bttndelete);
            this.Controls.Add(this.bttnshow);
            this.Controls.Add(this.bttnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvdoctordatabase);
            this.Controls.Add(this.txtdegree);
            this.Controls.Add(this.txtvisitingfee);
            this.Controls.Add(this.txtvisitinghours);
            this.Controls.Add(this.txtspecility);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtuniqueid);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.lblVisitingFee);
            this.Controls.Add(this.lblvisitinghours);
            this.Controls.Add(this.lblspeciality);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Name = "DoctorDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctordatabase)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblspeciality;
        private System.Windows.Forms.Label lblvisitinghours;
        private System.Windows.Forms.Label lblVisitingFee;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtuniqueid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtspecility;
        private System.Windows.Forms.TextBox txtvisitinghours;
        private System.Windows.Forms.TextBox txtvisitingfee;
        private System.Windows.Forms.TextBox txtdegree;
        private System.Windows.Forms.DataGridView dgvdoctordatabase;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button bttnsearch;
        private System.Windows.Forms.Button bttnshow;
        private System.Windows.Forms.Button bttndelete;
        private System.Windows.Forms.Button bttninsert;
        private System.Windows.Forms.Button bttnedit;
        private System.Windows.Forms.Button bttnlogout;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adminPageToolStripMenuItem;
    }
}