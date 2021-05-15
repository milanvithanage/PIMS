using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Doctor_delete : Form
    {
        public Doctor_delete()
        {
            InitializeComponent();
            s();
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

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Doctor WHERE Doctor_ID='" + d_id.Text + "'", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted");


            int rowIndex = datatable.CurrentCell.RowIndex;
            datatable.Rows.RemoveAt(rowIndex);
            s();
        }
        private void Doctors_add_Load(object sender, EventArgs e)
        {
         
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Doctor_ID,Doctor_Name,Specialization,Qualification,Channel_Fee FROM Doctor WHERE Doctor_ID LIKE '" + textBox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;
            }
        }

        private void datatable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            d_id.Text = datatable.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
