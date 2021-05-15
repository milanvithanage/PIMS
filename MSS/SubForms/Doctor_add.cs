using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Doctors_add : Form
    {
        public Doctors_add()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void s()
        {
            name.Clear();
            qua.Clear();
            fee.Clear();

            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(cast(Doctor_ID as int)),0)+1 from Doctor", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = id;


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
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Doctor(Doctor_ID,Doctor_Name,Specialization,Qualification,Channel_Fee) VALUES ('" + id.Text + "','" + name.Text + "','" + this.spe.Text + "','" + qua.Text + "','" + fee.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Doctor registered successfully");
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
