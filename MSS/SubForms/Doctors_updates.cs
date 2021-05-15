using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Doctors_updates : Form
    {
        public Doctors_updates()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            if ((name.Text == "") || (spe.Text == "") || (qua.Text == "") || (fee.Text == ""))
            {
                MessageBox.Show("Fill All the fields ");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Doctor SET Doctor_Name='" + name.Text + "',Specialization='" + this.spe.Text + "',Qualification='" + qua.Text + "', Channel_Fee='" + fee.Text + "'where Doctor_ID='" + id.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("updated");
                s();
            }
        }
        private void Doctors_add_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(cast(Doctor_ID as int)),0)+1 from Doctor", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = id;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datatable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            id.Text = datatable.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = datatable.SelectedRows[0].Cells[1].Value.ToString();
            spe.Text = datatable.SelectedRows[0].Cells[2].Value.ToString();
            qua.Text = datatable.SelectedRows[0].Cells[3].Value.ToString();
            fee.Text = datatable.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Doctor_ID,Doctor_Name,Specialization,Qualification,Channel_Fee FROM Doctor WHERE Doctor_ID LIKE '" + textBox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
