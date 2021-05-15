using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Channel : Form
    {
        public Channel()
        {
            InitializeComponent();
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

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Channel_ID,Channel_Date,Channel_Time,Channel_fee,Room_Number,Channel_Number,Doctor_ID,Patient_Contact FROM Patient_Channel WHERE Channel_ID LIKE '" + bunifuMetroTextbox1.Text + "%'", con);
                DataTable DATA = new DataTable();
                sda.Fill(DATA);
                datatable.DataSource = DATA;


            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Channel_add obj = new Channel_add();
            obj.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Channel_Update obj = new Channel_Update();
            obj.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Channel_Delete obj = new Channel_Delete();
            obj.ShowDialog();
            this.Close();
        }
    }
}
