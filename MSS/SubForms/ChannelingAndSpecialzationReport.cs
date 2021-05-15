using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MSS
{
    public partial class ChannelingAndSpecialzationReport : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        public ChannelingAndSpecialzationReport()
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
            try
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                int x = 0;
                con.Open();

                SqlCommand cmd1 = new SqlCommand("select Doctor.Specialization, count(Patient_Channel.Channel_Number) from Doctor INNER JOIN Patient_Channel ON Doctor.Doctor_ID = Patient_Channel.Doctor_ID where Patient_Channel.Channel_Date between '" + dateTimePicker1.Value + "' and '" + dateTimePicker2.Value + "' GROUP BY Doctor.Specialization", con);
                SqlDataReader dr = cmd1.ExecuteReader();
                chart1.ChartAreas[0].AxisX.Title = "Specialization";
                chart1.ChartAreas[0].AxisY.Title = "Number of Patient";


                while (dr.Read())
                {

                    this.chart1.Series["Channel"].Points.AddXY(dr.GetString(0), dr.GetInt32(1));



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
                con.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
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
