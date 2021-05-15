using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Channel_Update : Form
    {
        public Channel_Update()
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
            if ((c_date.Text == "") || (c_time.Text == "") || (c_fee.Text == "") || (r_number.Text == "") || (c_number.Text == "") || (d_id.Text == "") || (p_contact.Text == ""))
            {
                MessageBox.Show("Fill All the fields ");


            }
            else
            {


                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Patient_Channel SET Channel_Date='" + this.c_date.Text + "',Channel_Time='" + c_time.Text + "',Channel_fee='" + c_fee.Text + "', Room_Number='" + r_number.Text + "', Channel_Number = '" + c_number.Text + "', Doctor_ID = '" + d_id.Text + "', Patient_Contact = '" + p_contact.Text + "'where Channel_ID='" + c_id.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("updated");
                int rowIndex = datatable.CurrentCell.RowIndex;
                datatable.Rows.RemoveAt(rowIndex);
                s();

            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            c_id.Text = datatable.SelectedRows[0].Cells[0].Value.ToString();
            c_date.Text = datatable.SelectedRows[0].Cells[1].Value.ToString();
            c_time.Text = datatable.SelectedRows[0].Cells[2].Value.ToString();
            c_fee.Text = datatable.SelectedRows[0].Cells[3].Value.ToString();
            r_number.Text = datatable.SelectedRows[0].Cells[4].Value.ToString();
            c_number.Text = datatable.SelectedRows[0].Cells[5].Value.ToString();
            d_id.Text = datatable.SelectedRows[0].Cells[6].Value.ToString();
            p_contact.Text = datatable.SelectedRows[0].Cells[7].Value.ToString();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
