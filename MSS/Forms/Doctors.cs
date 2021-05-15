using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            this.ShowIcon = false;

            s();
        }
        public void s()
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT* FROM Doctor", con);
            DataTable DATA = new DataTable();
            sda.Fill(DATA);
            datatable.DataSource = DATA;
            con.Close();

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Doctors_add obj = new Doctors_add();
            obj.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Doctors_updates obj = new Doctors_updates();
            obj.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Doctor_delete obj = new Doctor_delete();
            obj.ShowDialog();
            this.Close();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Doctor_ID,Doctor_Name,Specialization,Qualification,Channel_Fee FROM Doctor WHERE Doctor_ID LIKE '" + bunifuMetroTextbox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;


            }
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
