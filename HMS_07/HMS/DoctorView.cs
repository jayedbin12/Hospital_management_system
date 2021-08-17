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
    public partial class DoctorView : Form
    {
        public DoctorView()
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

        private static string connectionstring = @"Server=LAPTOP-35V804DV;Database=db_appoinment;Integrated Security=true;";
        private static SqlConnection connection = new SqlConnection(connectionstring);

        private void bttnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().Show();
        }

        private void bttnshow_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Appoinment";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dgvdoctorview.DataSource = dt;

            connection.Close();
        }

        private void bttnsearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Appoinment WHERE Doctorname='" + txtsearch.Text + "'";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dgvdoctorview.DataSource = dt;

            connection.Close();
        }
    }
}
