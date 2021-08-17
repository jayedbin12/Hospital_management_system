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
    public partial class MemberView : Form
    {
        public MemberView()
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

            dgvdoctorview.DataSource = dt;

            connection.Close();
        }

        private void bttnsubmit_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Server=LAPTOP-35V804DV;Database=db_appoinment;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionstring);
            string patientId = txtpatientid.Text.Trim();
            string doctorname = txtdoctorname.Text.Trim();
            string appointmentdate = dateTimePicker1.Text.Trim();
            string patientname = txtpatientname.Text.Trim();

            if (patientId.Length == 0 || doctorname.Length == 0 || appointmentdate.Length == 0 || patientname.Length == 0)
                return;

            connection.Open();
            string query = "Insert into Appoinment(PatientId,Doctorname,Appointmentdate,Patientname) VALUES('" + patientId + "','" + doctorname + "','" + appointmentdate + "','" + patientname + "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            int numberOfRowsEffect = cmd.ExecuteNonQuery();
            connection.Close();

            if (numberOfRowsEffect > 0)
                MessageBox.Show("Appoinment successful");
        }

        private void bttnsearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MemberDoctor WHERE Name='" + txtsearch.Text + "'";
            DataTable dt = new DataTable();

            connection.Open();

            SqlDataAdapter dtaAdapter = new SqlDataAdapter(query, connection);
            dtaAdapter.Fill(dt);

            dgvdoctorview.DataSource = dt;

            connection.Close();
        }
    }
}
