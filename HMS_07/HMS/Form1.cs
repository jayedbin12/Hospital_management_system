using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class frmlogin : Form
    {
        private string username = "Arman";
        private string password = "1234";
        public frmlogin()
        {
            InitializeComponent();
        }

        override protected void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private void bttnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmmembersignup().Show();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminLogIn().Show();
        }

        private void staffLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffLogin().Show();
        }

        private void doctorLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorLogin().Show();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnlogin_Click(object sender, EventArgs e)
        {
            if (username == txtusername.Text && password == txtpassword.Text)
            {
                MessageBox.Show("Successful Login");
                this.Hide();
                new MemberView().Show();
            }
            else
                MessageBox.Show("Invalid login");
        }
    }
}
