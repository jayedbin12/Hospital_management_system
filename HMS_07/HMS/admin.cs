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
    public partial class admin : Form
    {
        public admin()
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

        private void bttnmview_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberDatabase().Show();
        }

        private void bttnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }

        private void bttndview_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorDatabase().Show();
        }

        private void bttnsview_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StaffDatabase().Show();
        }
    }
}
