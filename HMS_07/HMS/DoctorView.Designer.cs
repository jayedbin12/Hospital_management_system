namespace HMS
{
    partial class DoctorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorView));
            this.bttnlogout = new System.Windows.Forms.Button();
            this.dgvdoctorview = new System.Windows.Forms.DataGridView();
            this.bttnshow = new System.Windows.Forms.Button();
            this.bttnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctorview)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnlogout
            // 
            this.bttnlogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnlogout.Location = new System.Drawing.Point(976, 337);
            this.bttnlogout.Name = "bttnlogout";
            this.bttnlogout.Size = new System.Drawing.Size(95, 47);
            this.bttnlogout.TabIndex = 1;
            this.bttnlogout.Text = "Logout";
            this.bttnlogout.UseVisualStyleBackColor = false;
            this.bttnlogout.Click += new System.EventHandler(this.bttnlogout_Click);
            // 
            // dgvdoctorview
            // 
            this.dgvdoctorview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdoctorview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoctorview.Location = new System.Drawing.Point(249, 12);
            this.dgvdoctorview.Name = "dgvdoctorview";
            this.dgvdoctorview.ReadOnly = true;
            this.dgvdoctorview.RowTemplate.Height = 24;
            this.dgvdoctorview.Size = new System.Drawing.Size(612, 237);
            this.dgvdoctorview.TabIndex = 2;
            // 
            // bttnshow
            // 
            this.bttnshow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnshow.Location = new System.Drawing.Point(453, 274);
            this.bttnshow.Name = "bttnshow";
            this.bttnshow.Size = new System.Drawing.Size(228, 62);
            this.bttnshow.TabIndex = 3;
            this.bttnshow.Text = "Show-Appoinments";
            this.bttnshow.UseVisualStyleBackColor = false;
            this.bttnshow.Click += new System.EventHandler(this.bttnshow_Click);
            // 
            // bttnsearch
            // 
            this.bttnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsearch.Location = new System.Drawing.Point(71, 120);
            this.bttnsearch.Name = "bttnsearch";
            this.bttnsearch.Size = new System.Drawing.Size(105, 42);
            this.bttnsearch.TabIndex = 4;
            this.bttnsearch.Text = "Search";
            this.bttnsearch.UseVisualStyleBackColor = false;
            this.bttnsearch.Click += new System.EventHandler(this.bttnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(34, 77);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(173, 22);
            this.txtsearch.TabIndex = 5;
            // 
            // DoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1099, 406);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.bttnsearch);
            this.Controls.Add(this.bttnshow);
            this.Controls.Add(this.dgvdoctorview);
            this.Controls.Add(this.bttnlogout);
            this.Name = "DoctorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctorview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnlogout;
        private System.Windows.Forms.DataGridView dgvdoctorview;
        private System.Windows.Forms.Button bttnshow;
        private System.Windows.Forms.Button bttnsearch;
        private System.Windows.Forms.TextBox txtsearch;
    }
}