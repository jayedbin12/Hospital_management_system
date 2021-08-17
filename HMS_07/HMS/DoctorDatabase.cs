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
    public partial class DoctorDatabase : Form
    {
        public DoctorDatabase()
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

        private static string connectionstring = @"Server=LAPTOP-35V804DV;Database=db_doctor;Integrated Security=true;";
        private static SqlConnection connection = new SqlConnection(connectionstring);

        private void bttnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }

        private void bttnshow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MemberDoctor";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dgvdoctordatabase.DataSource = dt;

            connection.Close();
        }

        private void bttnsearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MemberDoctor WHERE UniqueID='" + txtsearch.Text + "'";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dgvdoctordatabase.DataSource = dt;

            connection.Close();
        }

        private void bttndelete_Click(object sender, EventArgs e)
        {
            string uniqueid = txtuniqueid.Text.Trim();

            if (uniqueid.Length == 0)
                return;

            string query = String.Format("DELETE FROM membersignup WHERE UniqueID = '{0}';", uniqueid);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Delete successfully");
        }

        private void bttninsert_Click(object sender, EventArgs e)
        {
            string username = txtname.Text.Trim();
            string gender = Text.Trim();
            if (radioButtonmale.Checked)
            {
                gender = radioButtonmale.Text.Trim();
            }
            else if (radioButtonfemale.Checked)
            {
                gender = radioButtonfemale.Text.Trim();
            }
            string email = txtemail.Text.Trim();
            string specility = txtspecility.Text.Trim();
            string visitinghours = txtvisitinghours.Text.Trim();
            string visitingfee = txtvisitingfee.Text.Trim();
            string degree = txtdegree.Text.Trim();

            if (degree.Length == 0 || username.Length == 0 || email.Length == 0 || specility.Length == 0 || visitinghours.Length == 0)
                return;

            string query = String.Format("INSERT INTO MemberDoctor VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}');", username, gender, email, specility, visitinghours, visitingfee, degree);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Insert Successful");
        }

        private void bttnedit_Click(object sender, EventArgs e)
        {
            string id = txtuniqueid.Text;
            string username = txtname.Text.Trim();
            string gender = Text.Trim();
            if (radioButtonmale.Checked)
            {
                gender = radioButtonmale.Text.Trim();
            }
            else if (radioButtonfemale.Checked)
            {
                gender = radioButtonfemale.Text.Trim();
            }
            string email = txtemail.Text.Trim();
            string specility = txtspecility.Text.Trim();
            string visitinghours = txtvisitinghours.Text.Trim();
            string visitingfee = txtvisitingfee.Text.Trim();
            string degree = txtdegree.Text.Trim();

            if (degree.Length == 0 || username.Length == 0 || email.Length == 0 || specility.Length == 0 || visitinghours.Length == 0)
                return;

            string query = String.Format("UPDATE MemberDoctor SET Name='{0}', Gender='{1}', Email='{2}', Specility='{3}', VisitingHours='{4}', VisitingFee='{5}', Degree='{6}' WHERE UniqueID='{7}';", username, gender, email, specility, visitinghours, visitingfee, degree, id);

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();

            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Update Successful");
        }

        private void adminPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin().Show();
        }
    }
}
