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
    public partial class MemberDatabase : Form
    {
        public MemberDatabase()
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
        private void bttnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }

        private void bttnview_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM membersignup";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string username = txtusername.Text.Trim();
            string email = txtemail.Text.Trim();
            string password = txtpassword.Text.Trim();
            string phone = txtphone.Text.Trim();
            string gender = Text.Trim();
            if (radioButtonmale.Checked)
            {
                gender = radioButtonmale.Text.Trim();
            }
            else if (radioButtonfemale.Checked)
            {
                gender = radioButtonfemale.Text.Trim();
            }
            string dob = dateTimePicker1.Text.Trim();
            string address = txtaddress.Text.Trim();

            if (name.Length == 0 || username.Length == 0 || email.Length == 0 || password.Length == 0 || phone.Length == 0)
                return;

            string query = String.Format("INSERT INTO membersignup VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}','{7}');", name, username, email, password, phone, gender, dob, address);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Insert Successful");
        }

        private void bttndelete_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();

            if (name.Length == 0)
                return;

            string query = String.Format("DELETE FROM membersignup WHERE name = '{0}';", name);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Delete successfully");
        }

        private void bttnedit_Click(object sender, EventArgs e)
        {
            string id = txtid.Text.Trim();
            string name = txtname.Text.Trim();
            string username = txtusername.Text.Trim();
            string email = txtemail.Text.Trim();
            string password = txtpassword.Text.Trim();
            string phone = txtphone.Text.Trim();
            string gender = Text.Trim();
            if (radioButtonmale.Checked)
            {
                gender = radioButtonmale.Text.Trim();
            }
            else if (radioButtonfemale.Checked)
            {
                gender = radioButtonfemale.Text.Trim();
            }
            string dob = dateTimePicker1.Text.Trim();
            string address = txtaddress.Text.Trim();

            if (name.Length == 0 || username.Length == 0 || email.Length == 0)
                return;

            string query = String.Format("UPDATE membersignup SET name = '{0}', username = '{1}', email = '{2}', password = '{3}', phone = '{4}', gender = '{5}', dob = '{6}', address = '{7}' WHERE id = {8};", name, username, email, password, phone, gender, dob, address, id);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Edited successfully");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM membersignup WHERE name='" + txtsearch.Text + "'";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }
    }
}
