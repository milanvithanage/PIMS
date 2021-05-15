using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MSS
{
    public partial class DrugInventoryReports : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        public DrugInventoryReports()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.ShowIcon = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {



            if (radioButton1.Checked)
            {
                try
                {
                    foreach (var series in chart1.Series)
                    {
                        series.Points.Clear();
                    }

                    int x = 0;
                    cn.Open();

                    SqlCommand cmd1 = new SqlCommand("Select * from Drug_Inventory ;", cn);
                   
                    SqlDataReader dr = cmd1.ExecuteReader();
                    chart1.ChartAreas[0].AxisX.Title = "Drug ID";
                    chart1.ChartAreas[0].AxisY.Title = "Quantity";


                    while (dr.Read())
                    {

                        this.chart1.Series["All_Drug"].Points.AddXY(dr.GetInt32(0), dr.GetInt32(11));
                        x = 1;
                    }
                    this.chart1.GetToolTipText += this.chart1_GetToolTipText;


                    if (x == 0)
                    {
                        MessageBox.Show("No Results found");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }

                try {

                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand("SELECT top 1 * FROM Drug_Inventory ORDER BY current_Quantity DESC", cn);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while(dr2.Read()){
                        bunifuCustomTextboxDessision.Text= "Currently PIMS Databse, Maximum Drug is Drug ID "+dr2.GetInt32(0) +" And Quantity is " + dr2.GetInt32(11)+" ."; 
                    }

                   
                }
                catch (Exception ex) {
                    MessageBox.Show("" + ex);
                }
                finally {

                    cn.Close();
                }
            }

            if (radioButton2.Checked)
            {

                try
                {
                    foreach (var series in chart1.Series)
                    {
                        series.Points.Clear();
                    }
                    int x = 0;
                    cn.Open();



                    SqlCommand cmd2 = new SqlCommand("select Issue_Drug.ItemIt_ID, sum(Issue_Drug.Quantity) from Issue_Drug INNER JOIN Issue_Receipt ON Issue_Drug.Reference_No = Issue_Receipt.Reference_No where Issue_Receipt.Date between '" + bunifuDatepickerFrom.Value + "' and '" + bunifuDatepickerTo.Value + "' GROUP BY Issue_Drug.ItemIt_ID", cn);

                    SqlDataReader dr = cmd2.ExecuteReader();
                    chart1.ChartAreas[0].AxisX.Title = "Drug ID";
                    chart1.ChartAreas[0].AxisY.Title = "Quantity";


                    while (dr.Read())
                    {

                        this.chart1.Series["All_Drug"].Points.AddXY(dr.GetInt32(0), dr.GetDouble(1));



                        x = 1;
                    }
                    this.chart1.GetToolTipText += this.chart1_GetToolTipText;
                    if (x == 0)
                    {
                        MessageBox.Show("No Results found");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }

                try
                {

                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand("select top 1 Issue_Drug.ItemIt_ID, sum(Issue_Drug.Quantity) as TotalQuantity from Issue_Drug INNER JOIN Issue_Receipt ON Issue_Drug.Reference_No = Issue_Receipt.Reference_No where Issue_Receipt.Date between '" + bunifuDatepickerFrom.Value + "' and '" + bunifuDatepickerTo.Value + "' GROUP BY Issue_Drug.ItemIt_ID Order by TotalQuantity DESC", cn);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        bunifuCustomTextboxDessision.Text = "Selected Duration is "+bunifuDatepickerFrom.Value.ToString("yyyy-MM-dd")+ " from "+bunifuDatepickerTo.Value.ToString("yyyy-MM-dd")+" to,  In this Duration Maximum issued drug ID is " + dr2.GetInt32(0) + " And That Quantity is " + dr2.GetDouble(1) + ".";
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

            if (radioButton3.Checked)
            {

                try
                {
                    foreach (var series in chart1.Series)
                    {
                        series.Points.Clear();
                    }
                    int x = 0;
                    cn.Open();

                    SqlCommand cmd1 = new SqlCommand("Select * from Drug_Inventory ;", cn);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    chart1.ChartAreas[0].AxisX.Title = "Drug ID";
                    chart1.ChartAreas[0].AxisY.Title = "Reorder Level";


                    while (dr.Read())
                    {

                        this.chart1.Series["All_Drug"].Points.AddXY(dr.GetInt32(0), dr.GetInt32(5));



                        x = 1;
                    }
                    this.chart1.GetToolTipText += this.chart1_GetToolTipText;
                    if (x == 0)
                    {
                        MessageBox.Show("No Results found");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }

                try
                {

                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand("SELECT top 1 * FROM Drug_Inventory  ORDER BY Reorder_level DESC", cn);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        bunifuCustomTextboxDessision.Text = "Currently PIMS Databse, Maximum Reorder Level of drug is Drug ID " + dr2.GetInt32(0) + " And Quantity is " + dr2.GetInt32(5) + " .";
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


            if (radioButton4.Checked)
            {

                try
                {
                    foreach (var series in chart1.Series)
                    {
                        series.Points.Clear();
                    }
                    int x = 0;
                    cn.Open();



                    SqlCommand cmd2 = new SqlCommand("select Issue_Drug.ItemIt_ID, sum(Issue_Drug.Price) from Issue_Drug INNER JOIN Issue_Receipt ON Issue_Drug.Reference_No = Issue_Receipt.Reference_No where Issue_Receipt.Date between '"+bunifuDatepickerFrom.Value+"' and '"+bunifuDatepickerTo.Value+"' GROUP BY Issue_Drug.ItemIt_ID", cn);

                    SqlDataReader dr = cmd2.ExecuteReader();
                    chart1.ChartAreas[0].AxisX.Title = "Drug ID";
                    chart1.ChartAreas[0].AxisY.Title = "Amount(LKR)";


                    while (dr.Read())
                    {

                        this.chart1.Series["All_Drug"].Points.AddXY(dr.GetInt32(0), dr.GetDouble(1));



                        x = 1;
                    }
                    this.chart1.GetToolTipText += this.chart1_GetToolTipText;
                    if (x == 0)
                    {
                        MessageBox.Show("No Results found");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }

                try
                {

                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand("select top 1 Issue_Drug.ItemIt_ID, sum(Issue_Drug.Price) as Amount from Issue_Drug INNER JOIN Issue_Receipt ON Issue_Drug.Reference_No = Issue_Receipt.Reference_No where Issue_Receipt.Date between '"+bunifuDatepickerFrom.Value+"' and '"+bunifuDatepickerTo.Value+"' GROUP BY Issue_Drug.ItemIt_ID Order by Amount DESC", cn);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        bunifuCustomTextboxDessision.Text = "Selected Duration is " + bunifuDatepickerFrom.Value.ToString("yyyy-MM-dd") + " from " + bunifuDatepickerTo.Value.ToString("yyyy-MM-dd") + " to,  In this Duration Highest profit drug ID is " + dr2.GetInt32(0) + " And That Amount is " + dr2.GetDouble(1) + "/= LKR.";
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            // Check selected chart element and set tooltip text for it
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = string.Format("X:\t{0}\nY:\t{1}", dataPoint.XValue, dataPoint.YValues[0]);
                    break;
            }
        }
    }
}
