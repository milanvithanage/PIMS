using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS
{
    public partial class IssueDrug : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        int referenceNo;

        public IssueDrug()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            bunifuCustomLabelDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            bunifuCustomLabelTime.Text = DateTime.Now.ToString("HH:mm:ss tt");

            try
            {

                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Issue_Drug ORDER BY Reference_No DESC", cn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    referenceNo = 1 + dr.GetInt32(1);
                    bunifuCustomLabelReferenceNo.Text = referenceNo.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                cn.Close();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from Drug_Inventory where ItemIt_ID = " + bunifuCustomTextboxItemID.Text, cn);

                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    int n = bunifuCustomDataGrid1.Rows.Add();
                    bunifuCustomDataGrid1.Rows[n].Cells[0].Value = bunifuCustomTextboxItemID.Text;
                    bunifuCustomDataGrid1.Rows[n].Cells[1].Value = dr.GetDouble(4).ToString();
                    bunifuCustomDataGrid1.Rows[n].Cells[2].Value = bunifuCustomTextboxQuantity.Text;

                    bunifuCustomDataGrid1.Rows[n].Cells[3].Value = (dr.GetDouble(4) * Convert.ToDouble(bunifuCustomTextboxQuantity.Text)).ToString(); 
                }

                if (!dr.HasRows)
                {
                    MessageBox.Show("Please use correct Drug ID");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {

                cn.Close();
            }

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            double Amount = 0;


            String Prescription_ID = bunifuCustomTextboxPrescriptionID.Text;

            if (bunifuCustomDataGrid1.RowCount >= 0)
            {

                try
                {
                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd1.Connection = DBConnection.cn;
                    int n = 0;

                    while ((bunifuCustomDataGrid1.Rows.Count - 1) > n)
                    {

                        DBConnection.cmd.CommandText = "INSERT INTO Issue_Drug (Reference_No,ItemIt_ID,Quantity,Price) VALUES (" + referenceNo + "," + bunifuCustomDataGrid1.Rows[n].Cells[0].Value + "," + bunifuCustomDataGrid1.Rows[n].Cells[2].Value + "," + bunifuCustomDataGrid1.Rows[n].Cells[3].Value + ")";

                        i = DBConnection.cmd.ExecuteNonQuery();

                        Amount += Convert.ToDouble(bunifuCustomDataGrid1.Rows[n].Cells[3].Value);
                        n++;
                    }
                    if (Prescription_ID == "")
                    {

                        DBConnection.cmd1.CommandText = "INSERT INTO Issue_Receipt (Reference_No,NoOfItems,Date,Time) VALUES (" + referenceNo + "," + (bunifuCustomDataGrid1.Rows.Count - 1) + ",'" + bunifuCustomLabelDate.Text + "','" + bunifuCustomLabelTime.Text + "')";

                        j = DBConnection.cmd1.ExecuteNonQuery();

                    }
                    else
                    {
                        DBConnection.cmd1.CommandText = "INSERT INTO Issue_Receipt (Reference_No,NoOfItems,Date,Time,Prescriptions_ID) VALUES (" + referenceNo + "," + (bunifuCustomDataGrid1.Rows.Count - 1) + ",'" + bunifuCustomLabelDate.Text + "','" + bunifuCustomLabelTime.Text + "'," + Convert.ToInt32(Prescription_ID) + ")";
                        j = DBConnection.cmd1.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    DBConnection.cn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill the order");
            }
            if (i == 1 && j == 1)
            {

                MessageBox.Show("Drug Issue successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new CrystalReports.DrugIssueReportForm(referenceNo.ToString(), bunifuCustomLabelDate.Text, bunifuCustomLabelTime.Text, Amount.ToString(), (bunifuCustomDataGrid1.Rows.Count - 1).ToString()).ShowDialog();
                
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
