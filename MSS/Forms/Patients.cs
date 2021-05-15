using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            this.ShowIcon = false;

            s();
        }
        public void s()
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT* FROM Registered_Patient", con);
            DataTable DATA = new DataTable();
            sda.Fill(DATA);
            datatable.DataSource = DATA;
            con.Close();

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Patient_add obj = new Patient_add();
            obj.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            Patient_update obj = new Patient_update();
            obj.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Patient_delete obj = new Patient_delete();
            obj.ShowDialog();
            this.Close();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Patient_Contact,Patient_Name,Patient_email,Patient_DOB,Patient_NIC FROM Registered_Patient WHERE Patient_Contact LIKE '" + bunifuMetroTextbox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;


            }
        }
    }
}
