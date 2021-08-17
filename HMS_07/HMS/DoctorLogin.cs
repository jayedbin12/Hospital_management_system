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
    public partial class DoctorLogin : Form
    {
        private string Username = "Rumman";
        private string Password = "1234";
        private string username = "Jemam";
        private string password = "4321";
        public DoctorLogin()
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

        private void DoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }

        private void bttnlogin_Click(object sender, EventArgs e)
        {
            if (Username == txtusername.Text && Password == txtpassword.Text)
            {
                MessageBox.Show("Login successfull");
                this.Hide();
                new DoctorView().Show();
            }
            else if(username == txtusername.Text && password == txtpassword.Text)
            {
                MessageBox.Show("Login successfull");
                this.Hide();
                new DoctorView().Show();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
