using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Patient_add : Form
    {
        public Patient_add()
        {            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
        }
        public void s()
        {
            p_id.Clear();
            name.Clear();
            email.Clear();
            nic.Clear();

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if ((p_id.Text == "") || (name.Text == "") || (email.Text == "") || (dob.Text == "") || (nic.Text == ""))
            {
                MessageBox.Show("Fill All the fields ");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Registered_Patient(Patient_Contact,Patient_Name,Patient_email,Patient_DOB,Patient_NIC) VALUES ('" + p_id.Text + "','" + name.Text + "','" + email.Text + "','" + this.dob.Text + "','" + nic.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Patient registered successfully");
                s();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
