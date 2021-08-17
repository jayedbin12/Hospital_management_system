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
    public partial class AdminLogIn : Form
    {
        private string username = "jayed";
        private string password = "1234";
        private string Username = "arman";
        private string Password = "4321";
        public AdminLogIn()
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

        private void AdminLogIn_Load(object sender, EventArgs e)
        {

        }

        private void bttnlogin_Click(object sender, EventArgs e)
        {
            if (username == txtusernmae.Text && password == txtpassword.Text)
            {
                MessageBox.Show("Successful Login");
                this.Hide();
                new admin().Show();
            }
            else if(Username == txtusernmae.Text && Password == txtpassword.Text)
            {
                MessageBox.Show("Successful Login");
                this.Hide();
                new admin().Show();
            }
            else
                MessageBox.Show("Invalid login");
        }

        private void honeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }
    }
}
