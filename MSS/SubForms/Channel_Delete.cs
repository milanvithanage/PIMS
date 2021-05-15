using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Channel_Delete : Form
    {
        public Channel_Delete()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;

            s();
        }
        public void s()
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT* FROM Patient_Channel", con);
            DataTable DATA = new DataTable();
            sda.Fill(DATA);
            datatable.DataSource = DATA;
            con.Close();

        }

        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);

       


        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            con.Open();
           SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Patient_Channel WHERE Channel_ID='" + c_id.Text + "'", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted");

            int rowIndex = datatable.CurrentCell.RowIndex;
            datatable.Rows.RemoveAt(rowIndex);
            s();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Channel_ID,Channel_Date,Channel_Time,Channel_fee,Room_Number,Channel_Number,Doctor_ID,Patient_Contact FROM Patient_Channel WHERE Channel_ID LIKE '" + textBox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;


            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Channel_ID,Channel_Date,Channel_Time,Channel_fee,Room_Number,Channel_Number,Doctor_ID,Patient_Contact FROM Patient_Channel WHERE Channel_ID LIKE '" + textBox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;


            }

        }

        private void datatable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           c_id.Text = datatable.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
