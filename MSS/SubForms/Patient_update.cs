using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Patient_update : Form
    {
        public Patient_update()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;

            s();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        public void s()
        {
            p_id.Clear();
            name.Clear();
            email.Clear();
            nic.Clear();
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT* FROM Registered_Patient", con);
            DataTable DATA = new DataTable();
            sda.Fill(DATA);
            datatable.DataSource = DATA;
            con.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if ((name.Text == "") || (email.Text == "") || (dob.Text == "") || (nic.Text == ""))
            {
                MessageBox.Show("Fill All the fields ");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Registered_Patient SET Patient_Name='" + name.Text + "',Patient_email='" + email.Text + "', Patient_DOB='" + this.dob.Text + "', Patient_NIC = '" + nic.Text + "'where Patient_Contact='" + p_id.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("updated");
                s();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Patient_Contact,Patient_Name,Patient_email,Patient_DOB,Patient_NIC FROM Registered_Patient WHERE Patient_Contact LIKE '" + textBox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;


            }
        }

        private void datatable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            p_id.Text = datatable.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = datatable.SelectedRows[0].Cells[1].Value.ToString();
            email.Text = datatable.SelectedRows[0].Cells[2].Value.ToString();
            dob.Text = datatable.SelectedRows[0].Cells[3].Value.ToString();
            nic.Text = datatable.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
