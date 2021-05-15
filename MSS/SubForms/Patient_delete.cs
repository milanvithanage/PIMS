using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Patient_delete : Form
    {
        public Patient_delete()
        {            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;

            s();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        public void s()
        {

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
            con.Open();
             SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Registered_Patient WHERE Patient_Contact='" + p_id.Text + "'", con);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void datatable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void datatable_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            p_id.Text = datatable.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Patient_Contact,Patient_Name,Patient_email,Patient_DOB,Patient_NIC FROM Registered_Patient WHERE Patient_Contact LIKE '" + textBox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;


            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
