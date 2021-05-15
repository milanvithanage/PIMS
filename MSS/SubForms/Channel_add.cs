using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Channel_add : Form
    {
        public Channel_add()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
        }
        public void reset()
        {
            c_time.Clear();
            c_fee.Clear();
            r_number.Clear();
            c_number.Clear();
            d_id.Clear();
            p_contact.Clear();

            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(cast(Channel_ID as int)),0)+1 from Patient_Channel", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            c_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = c_date;
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
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Patient_Channel(Channel_Date,Channel_Time,Channel_fee,Room_Number,Channel_Number,Doctor_ID,Patient_Contact) VALUES ('" + this.c_date.Text + "','" + c_time.Text + "','" + c_fee.Text + "','" + r_number.Text + "','" + c_number.Text + "','" + d_id.Text + "','" + p_contact.Text + "')", con);
                    sda.SelectCommand.ExecuteNonQuery();
                   
                    MessageBox.Show("Channel Saved successfully");

                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Matching data in Database") ;
                }
                finally {
                    con.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void channel_add_Load(Object sender,EventArgs e) {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(cast(Channel_ID as int)),0)+1 from Patient_Channel", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            c_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = c_date;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
