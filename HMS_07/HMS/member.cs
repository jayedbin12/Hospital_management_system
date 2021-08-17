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
    public partial class frmmembersignup : Form
    {
        public frmmembersignup()
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

        private static string connectionstring = @"Server=LAPTOP-35V804DV;Database=db_member;Integrated Security=true;";
        private static SqlConnection connection = new SqlConnection(connectionstring);

        private void frmmembersignup_Load(object sender, EventArgs e)
        {

        }

        private void bttnsignUp_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string username = txtusername.Text.Trim();
            string email = txtemail.Text.Trim();
            string password = txtpassword.Text.Trim();
            string phone = txtphone.Text.Trim();
            string gender = Text.Trim();
            if (rabttnmale.Checked)
            {
                gender = rabttnmale.Text.Trim();
            }
            else if (rabttnfemale.Checked)
            {
                gender = rabttnfemale.Text.Trim();
            }
            string dob = dateTimePicker1.Text.Trim();
            string address = txtaddress.Text.Trim();

            if (name.Length == 0 || username.Length == 0 || email.Length==0 || password.Length==0 || phone.Length==0)
                return;

            string query = String.Format("INSERT INTO membersignup VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}');", name, username, email, password, phone, gender, dob, address);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("SignUp successful");
        }

        private void bttnshow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM membersignup";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dgvmember.DataSource = dt;

            connection.Close();
        }

        private void logInPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }

        private void dgvmember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
