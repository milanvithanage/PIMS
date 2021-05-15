using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MSS
{
    class ReportPatientRegDAO
    {
        // This class is used to get data from the database related to the Customer Insights form
        // Updated 17 Dec 2017
        // Version 01
        // Version 02
        // Changes - Add try catch block to all method except dataGridMostValuableCus method.

        CommonDAO commonDAO = new CommonDAO();

        public void chartPatientRegAMethod(Chart chrt)
        {
            try
            {
                chrt.Titles.Add("Customer Growth - Number Of Customers Arrivals (Monthly)");
                chrt.Titles.Add("Number Of Monthly Customer Visits");

                chrt.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

                chrt.ChartAreas[0].AxisX.Title = "Months";
                chrt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;

                chrt.ChartAreas[0].AxisY.Title = "No of Visits";
                chrt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;

                chrt.Palette = ChartColorPalette.SeaGreen;
                chrt.Series.Clear();


                string queryB = @"
                    SELECT x.*, LEFT(DateName( month , DateAdd( month , x.month , -1 ) ), 3) AS 'MonthName', 
                    coalesce( y.count,0) AS 'TotalAmount' FROM 
                    (SELECT DISTINCT year([Channel_date]) year,a.*
                    FROM Patient_Channel,
                    ( SELECT 1 'month'
                    UNION
                    SELECT 2 'month'
                    UNION
                    SELECT 3 'month'
                    UNION
                    SELECT 4 'month'
                    UNION
                    SELECT 5 'month'
                    UNION
                    SELECT 6 'month'
                    UNION
                    SELECT 7 'month'
                    UNION
                    SELECT 8 'month'
                    UNION
                    SELECT 9 'month'
                    UNION
                    SELECT 10 'month'
                    UNION
                    SELECT 11 'month'
                    UNION
                    SELECT 12 'month'
                    ) a) x 
                    left outer join 
                    (
                    SELECT year([Channel_date]) year , month ([Channel_date]) month ,count(*) count FROM Patient_Channel
                    GROUP BY year([Channel_date]) ,month ([Channel_date])) y
                    ON x.year=y.year and x.month=y.month
                    ORDER BY x.year, x.month";

                string queryA = @"
                    SELECT YEAR(Channel_Date) AS 'Year' 
                    FROM Patient_Channel 
                    GROUP BY YEAR(Channel_Date) 
                    ORDER BY YEAR(Channel_Date)";


                // DataSet A will help to Add different series to the chart
                // Without this, chart will not be able to display data up to present
                // it will only display certain data for certain year

                using (DataSet dsA = commonDAO.GetDataFromDb(queryA))
                {
                    foreach (DataRow RowDS in dsA.Tables["tmpTable"].Rows)
                    {
                        // This is the actual query that will help to get the data 
                        // for certain year

                        using (DataSet dsB = commonDAO.GetDataFromDb(queryB))
                        {
                            string chrtSeriesNamedsB = RowDS["Year"].ToString();

                            using (DataTable dt = (dsB.Tables["tmpTable"].Select("year = " + chrtSeriesNamedsB)).CopyToDataTable())
                            {
                                chrt.Series.Add(chrtSeriesNamedsB);

                                foreach (DataRow RowDT in dt.Rows)
                                {
                                    string monthName = RowDT["MonthName"].ToString();
                                    string totalCount = RowDT["TotalAmount"].ToString();

                                    chrt.Series[chrtSeriesNamedsB].Points.AddXY(monthName, totalCount);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegBMethod(Chart chrt)
        {
            try
            {
                string query = @" 
                            SELECT Year(Channel_Date) 
                            AS 'Year', COUNT(*) AS 'Total' 
                            FROM Patient_Channel 
                            GROUP BY Year(Channel_Date) 
							ORDER BY Year(Channel_Date)";

                chrt.Titles.Add("Number Of Customers Arrivals (Annually)");
                chrt.Titles.Add("Number Of Monthly Customer Visits");

                chrt.Series.Clear();
                chrt.Legends.Clear();

                //Add a new Legend(if needed) and do some formating
                chrt.Legends.Add("MyLegend");
                chrt.Legends[0].LegendStyle = LegendStyle.Table;
                chrt.Legends[0].Docking = Docking.Bottom;
                chrt.Legends[0].Alignment = StringAlignment.Center;
                chrt.Legends[0].Title = "Year";
                chrt.Legends[0].BorderColor = Color.Black;

                //chrt.ChartAreas[0].AxisX.Title = "Months";
                //chrt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;

                //chrt.ChartAreas[0].AxisY.Title = "No of Patients";
                //chrt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;

                chrt.Palette = ChartColorPalette.SeaGreen;
                chrt.Series.Clear();

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    chrt.Series.Add("Patient Registration");
                    chrt.Series["Patient Registration"].XValueMember = "Year";
                    chrt.Series["Patient Registration"].YValueMembers = "Total";
                    chrt.Series["Patient Registration"].ChartType = SeriesChartType.Pie;

                    chrt.Series["Patient Registration"].IsValueShownAsLabel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegCMethod(Chart chrt)
        {
            try
            {
                chrt.Titles.Add("Customer Growth - Customer Registration (Monthly)");
                chrt.Titles.Add("Number Of Registered Customers");

                chrt.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

                chrt.ChartAreas[0].AxisX.Title = "Months";
                chrt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;

                chrt.ChartAreas[0].AxisY.Title = "No of Customers";
                chrt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;

                chrt.Palette = ChartColorPalette.Pastel;
                chrt.Series.Clear();


                string queryB = @"
                    SELECT x.*, LEFT(DateName( month , DateAdd( month , x.month , -1 ) ), 3) AS 'MonthName', 
                    coalesce( y.count,0) AS 'TotalAmount' FROM 
                    (SELECT DISTINCT year(Patient_Register_Date) year,a.*
                    FROM Registered_Patient,
                    ( SELECT 1 'month'
                    UNION
                    SELECT 2 'month'
                    UNION
                    SELECT 3 'month'
                    UNION
                    SELECT 4 'month'
                    UNION
                    SELECT 5 'month'
                    UNION
                    SELECT 6 'month'
                    UNION
                    SELECT 7 'month'
                    UNION
                    SELECT 8 'month'
                    UNION
                    SELECT 9 'month'
                    UNION
                    SELECT 10 'month'
                    UNION
                    SELECT 11 'month'
                    UNION
                    SELECT 12 'month'
                    ) a) x 
                    left outer join 
                    (
                    SELECT year(Patient_Register_Date) year , month (Patient_Register_Date) month ,count(*) count FROM Registered_Patient
                    GROUP BY year(Patient_Register_Date) ,month (Patient_Register_Date)) y
                    ON x.year=y.year and x.month=y.month
                    ORDER BY x.year, x.month";

                string queryA = @"
                    SELECT YEAR(Patient_Register_Date) AS 'Year' 
                    FROM Registered_Patient 
                    GROUP BY YEAR(Patient_Register_Date) 
                    ORDER BY YEAR(Patient_Register_Date)";


                // DataSet A will help to Add different series to the chart
                // Without this, chart will not be able to display data up to present
                // it will only display certain data for certain year

                using (DataSet dsA = commonDAO.GetDataFromDb(queryA))
                {
                    foreach (DataRow RowDS in dsA.Tables["tmpTable"].Rows)
                    {
                        // This is the actual query that will help to get the data 
                        // for certain year

                        using (DataSet dsB = commonDAO.GetDataFromDb(queryB))
                        {
                            string chrtSeriesNamedsB = RowDS["Year"].ToString();

                            using (DataTable dt = (dsB.Tables["tmpTable"].Select("year = " + chrtSeriesNamedsB)).CopyToDataTable())
                            {
                                chrt.Series.Add(chrtSeriesNamedsB);

                                foreach (DataRow RowDT in dt.Rows)
                                {
                                    string monthName = RowDT["MonthName"].ToString();
                                    string totalCount = RowDT["TotalAmount"].ToString();

                                    chrt.Series[chrtSeriesNamedsB].Points.AddXY(monthName, totalCount);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\n" + err.StackTrace, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegDMethod(Chart chrt)
        {
            try
            {
                string query = @" 
                            SELECT Year(Patient_Register_Date) 
                            AS 'Year', COUNT(*) AS 'Total' 
                            FROM Registered_Patient 
                            GROUP BY Year(Patient_Register_Date) 
							ORDER BY Year(Patient_Register_Date)";


                chrt.Titles.Add("Customer Growth - Customer Registration (Annually)");
                chrt.Titles.Add("Number Of Registered Customers");

                chrt.Series.Clear();
                chrt.Legends.Clear();

                //Add a new Legend(if needed) and do some formating
                chrt.Legends.Add("MyLegend");
                chrt.Legends[0].LegendStyle = LegendStyle.Table;
                chrt.Legends[0].Docking = Docking.Bottom;
                chrt.Legends[0].Alignment = StringAlignment.Center;
                chrt.Legends[0].Title = "Year";
                chrt.Legends[0].BorderColor = Color.Black;

                //chrt.ChartAreas[0].AxisX.Title = "Months";
                //chrt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;

                //chrt.ChartAreas[0].AxisY.Title = "No of Patients";
                //chrt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;

                chrt.Palette = ChartColorPalette.Pastel;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    chrt.Series.Add("Patient Registration");
                    chrt.Series["Patient Registration"].XValueMember = "Year";
                    chrt.Series["Patient Registration"].YValueMembers = "Total";
                    chrt.Series["Patient Registration"].ChartType = SeriesChartType.Pie;

                    chrt.Series["Patient Registration"].IsValueShownAsLabel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegEMethod(Chart chrt)
        {
            try
            {
                chrt.Titles.Add("Number Of Customer Visits & Number Of Registered Customers");
                chrt.Titles.Add("Number Of Monthly Customer Visits (Vis) And Number Of Customers Registered Monthly (Reg)");

                chrt.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

                chrt.ChartAreas[0].AxisX.Title = "Months";
                chrt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;

                chrt.ChartAreas[0].AxisY.Title = "Customers & Appointments";
                chrt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;

                chrt.Palette = ChartColorPalette.BrightPastel;
                chrt.Series.Clear();


                string queryB = @"
                    SELECT x.*, LEFT(DateName( month , DateAdd( month , x.month , -1 ) ), 3) AS 'MonthName', 
                    coalesce( y.count,0) AS 'TotalAmount' FROM 
                    (SELECT DISTINCT year([Channel_date]) year,a.*
                    FROM Patient_Channel,
                    ( SELECT 1 'month'
                    UNION
                    SELECT 2 'month'
                    UNION
                    SELECT 3 'month'
                    UNION
                    SELECT 4 'month'
                    UNION
                    SELECT 5 'month'
                    UNION
                    SELECT 6 'month'
                    UNION
                    SELECT 7 'month'
                    UNION
                    SELECT 8 'month'
                    UNION
                    SELECT 9 'month'
                    UNION
                    SELECT 10 'month'
                    UNION
                    SELECT 11 'month'
                    UNION
                    SELECT 12 'month'
                    ) a) x 
                    left outer join 
                    (
                    SELECT year([Channel_date]) year , month ([Channel_date]) month ,count(*) count FROM Patient_Channel
                    GROUP BY year([Channel_date]) ,month ([Channel_date])) y
                    ON x.year=y.year and x.month=y.month
                    ORDER BY x.year, x.month";

                string queryA = @"
                    SELECT YEAR(Channel_Date) AS 'Year' 
                    FROM Patient_Channel 
                    GROUP BY YEAR(Channel_Date) 
                    ORDER BY YEAR(Channel_Date)";

                string queryC = @"
                    SELECT x.*, LEFT(DateName( month , DateAdd( month , x.month , -1 ) ), 3) AS 'MonthName', 
                    coalesce( y.count,0) AS 'TotalAmount' FROM 
                    (SELECT DISTINCT year(Patient_Register_Date) year,a.*
                    FROM Registered_Patient,
                    ( SELECT 1 'month'
                    UNION
                    SELECT 2 'month'
                    UNION
                    SELECT 3 'month'
                    UNION
                    SELECT 4 'month'
                    UNION
                    SELECT 5 'month'
                    UNION
                    SELECT 6 'month'
                    UNION
                    SELECT 7 'month'
                    UNION
                    SELECT 8 'month'
                    UNION
                    SELECT 9 'month'
                    UNION
                    SELECT 10 'month'
                    UNION
                    SELECT 11 'month'
                    UNION
                    SELECT 12 'month'
                    ) a) x 
                    left outer join 
                    (
                    SELECT year(Patient_Register_Date) year , month (Patient_Register_Date) month ,count(*) count FROM Registered_Patient
                    GROUP BY year(Patient_Register_Date) ,month (Patient_Register_Date)) y
                    ON x.year=y.year and x.month=y.month
                    ORDER BY x.year, x.month";


                // DataSet A will help to Add different series to the chart
                // Without this, chart will not be able to display data up to present
                // it will only display certain data for certain year

                using (DataSet dsA = commonDAO.GetDataFromDb(queryA))
                {
                    foreach (DataRow RowDS in dsA.Tables["tmpTable"].Rows)
                    {
                        // This is the actual query that will help to get the data 
                        // for certain year

                        using (DataSet dsB = commonDAO.GetDataFromDb(queryB))
                        {
                            string chrtSeriesNamedsB = "Vis " + RowDS["Year"].ToString();
                            string chrtSeriesYr = RowDS["Year"].ToString();

                            using (DataTable dt = (dsB.Tables["tmpTable"].Select("year = " + chrtSeriesYr)).CopyToDataTable())
                            {
                                chrt.Series.Add(chrtSeriesNamedsB);
                                chrt.Series[chrtSeriesNamedsB].ChartType = SeriesChartType.Spline;
                                chrt.Series[chrtSeriesNamedsB].BorderWidth = 3;

                                foreach (DataRow RowDT in dt.Rows)
                                {
                                    string monthName = RowDT["MonthName"].ToString();
                                    string totalCount = RowDT["TotalAmount"].ToString();

                                    chrt.Series[chrtSeriesNamedsB].Points.AddXY(monthName, totalCount);
                                }
                            }
                        }

                        using (DataSet dsB = commonDAO.GetDataFromDb(queryC))
                        {
                            string chrtSeriesNamedsB = "Reg " + RowDS["Year"].ToString();
                            string chrtSeriesYr = RowDS["Year"].ToString();

                            using (DataTable dt = (dsB.Tables["tmpTable"].Select("year = " + chrtSeriesYr)).CopyToDataTable())
                            {
                                chrt.Series.Add(chrtSeriesNamedsB);
                                chrt.Series[chrtSeriesNamedsB].ChartType = SeriesChartType.Spline;
                                chrt.Series[chrtSeriesNamedsB].BorderWidth = 3;

                                foreach (DataRow RowDT in dt.Rows)
                                {
                                    string monthName = RowDT["MonthName"].ToString();
                                    string totalCount = RowDT["TotalAmount"].ToString();

                                    chrt.Series[chrtSeriesNamedsB].Points.AddXY(monthName, totalCount);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegFMethod(Chart chrt)
        {
            try
            {
                chrt.Titles.Add("No Of Appointments & No of Customers");
                chrt.Titles.Add("No Of Appointments Made by Customers (App) and No Of Customers Registered (Cus)\n");

                chrt.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

                chrt.ChartAreas[0].AxisX.Title = "\nMonths \n\n(2015 - Present)";
                chrt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;

                chrt.ChartAreas[0].AxisY.Title = "Customers & Appointments";
                chrt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;

                chrt.Palette = ChartColorPalette.SeaGreen;
                chrt.Series.Clear();

                string queryA = @"
                    SELECT YEAR(Channel_Date) AS 'Year' 
                    FROM Patient_Channel 
                    GROUP BY YEAR(Channel_Date) 
                    ORDER BY YEAR(Channel_Date)";

                string queryB = @"
                    SELECT x.*, LEFT(DateName( month , DateAdd( month , x.month , -1 ) ), 3) AS 'MonthName', 
                    coalesce( y.count,0) AS 'TotalAmount' FROM 
                    (SELECT DISTINCT year([Channel_date]) year,a.*
                    FROM Patient_Channel,
                    ( SELECT 1 'month'
                    UNION
                    SELECT 2 'month'
                    UNION
                    SELECT 3 'month'
                    UNION
                    SELECT 4 'month'
                    UNION
                    SELECT 5 'month'
                    UNION
                    SELECT 6 'month'
                    UNION
                    SELECT 7 'month'
                    UNION
                    SELECT 8 'month'
                    UNION
                    SELECT 9 'month'
                    UNION
                    SELECT 10 'month'
                    UNION
                    SELECT 11 'month'
                    UNION
                    SELECT 12 'month'
                    ) a) x 
                    left outer join 
                    (
                    SELECT year([Channel_date]) year , month ([Channel_date]) month ,count(*) count FROM Patient_Channel
                    GROUP BY year([Channel_date]) ,month ([Channel_date])) y
                    ON x.year=y.year and x.month=y.month
                    ORDER BY x.year, x.month";

                string queryC = @"
                    SELECT x.*, LEFT(DateName( month , DateAdd( month , x.month , -1 ) ), 3) AS 'MonthName', 
                    coalesce( y.count,0) AS 'TotalAmount' FROM 
                    (SELECT DISTINCT year(Patient_Register_Date) year,a.*
                    FROM Registered_Patient,
                    ( SELECT 1 'month'
                    UNION
                    SELECT 2 'month'
                    UNION
                    SELECT 3 'month'
                    UNION
                    SELECT 4 'month'
                    UNION
                    SELECT 5 'month'
                    UNION
                    SELECT 6 'month'
                    UNION
                    SELECT 7 'month'
                    UNION
                    SELECT 8 'month'
                    UNION
                    SELECT 9 'month'
                    UNION
                    SELECT 10 'month'
                    UNION
                    SELECT 11 'month'
                    UNION
                    SELECT 12 'month'
                    ) a) x 
                    left outer join 
                    (
                    SELECT year(Patient_Register_Date) year , month (Patient_Register_Date) month ,count(*) count FROM Registered_Patient
                    GROUP BY year(Patient_Register_Date) ,month (Patient_Register_Date)) y
                    ON x.year=y.year and x.month=y.month
                    ORDER BY x.year, x.month";

                // DataSet A will help to Add different series to the chart
                // Without this, chart will not be able to display data up to present
                // it will only display certain data for certain year

                string chrtSeriesNamedsBQueB = "App";
                string chrtSeriesNamedsBQueC = "Cus";

                chrt.Series.Add(chrtSeriesNamedsBQueC);
                chrt.Series[chrtSeriesNamedsBQueC].ChartType = SeriesChartType.Spline;
                chrt.Series[chrtSeriesNamedsBQueC].BorderWidth = 3;
                chrt.Series[chrtSeriesNamedsBQueC].IsValueShownAsLabel = true;

                chrt.Series.Add(chrtSeriesNamedsBQueB);
                chrt.Series[chrtSeriesNamedsBQueB].ChartType = SeriesChartType.Spline;
                chrt.Series[chrtSeriesNamedsBQueB].BorderWidth = 3;
                chrt.Series[chrtSeriesNamedsBQueB].IsValueShownAsLabel = true;

                using (DataSet dsA = commonDAO.GetDataFromDb(queryA))
                {
                    int totQueryB = 0;
                    int mQuryB = 0;
                    int totQueryC = 0;
                    int mQuryC = 0;

                    foreach (DataRow RowDS in dsA.Tables["tmpTable"].Rows)
                    {
                        // This is the actual query that will help to get the data 
                        // for certain year

                        using (DataSet dsB = commonDAO.GetDataFromDb(queryB))
                        {
                            string chrtSeriesYr = RowDS["Year"].ToString();

                            using (DataTable dt = (dsB.Tables["tmpTable"].Select("year = " + chrtSeriesYr)).CopyToDataTable())
                            {
                                foreach (DataRow RowDT in dt.Rows)
                                {
                                    mQuryB++;
                                    Int32.TryParse(RowDT["TotalAmount"].ToString(), out totQueryB);

                                    chrt.Series[chrtSeriesNamedsBQueB].Points.AddXY(mQuryB, totQueryB);
                                }
                            }
                        }

                        using (DataSet dsB = commonDAO.GetDataFromDb(queryC))
                        {
                            string chrtSeriesYr = RowDS["Year"].ToString();

                            using (DataTable dt = (dsB.Tables["tmpTable"].Select("year = " + chrtSeriesYr)).CopyToDataTable())
                            {
                                foreach (DataRow RowDT in dt.Rows)
                                {
                                    mQuryC++;
                                    Int32.TryParse(RowDT["TotalAmount"].ToString(), out totQueryC);

                                    chrt.Series[chrtSeriesNamedsBQueC].Points.AddXY(mQuryC, totQueryC);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegGMethod(Chart chrt, DateTimePicker dtFrom, DateTimePicker dtTo)
        {
            try
            {
                string queryA = "";

                string dateFrom = dtFrom.Value.Date.ToString("MM-dd-yyyy");
                string dateTo = dtTo.Value.Date.ToString("MM-dd-yyyy");

                /**
                string query2 = @"DECLARE @dateFrom date, @dateTo date
                                SET @dateFrom = '2014'
                                SET @dateTo = '2017'

                                SELECT sum(tot) AS 'RepeatCus' 
                                FROM( 
                                SELECT count(t1.Patient_Contact) tot 
                                FROM Patient_Channel t1 
                                WHERE YEAR(t1.Channel_Date) 
                                between YEAR (@dateFrom) and YEAR(@dateTo)
                                GROUP BY t1.Patient_Contact 
                                HAVING COUNT(*) > 1 ) src;";

                queryA += "SET @dateFrom = '" + dateFrom + "'";
                queryA += "SET @dateTo   = '" + dateTo   + "'";

                **/

                queryA += "select sum(tot) as 'RepeatCus' ";
                queryA += "from( ";
                queryA += "SELECT count(t1.Patient_Contact) tot ";
                queryA += "FROM Patient_Channel t1 ";
                queryA += "WHERE t1.Channel_Date ";
                queryA += "between '";
                queryA += dateFrom + "' and ' ";
                queryA += dateTo + "'";
                queryA += "GROUP BY t1.Patient_Contact ";
                queryA += "HAVING COUNT(*) > 1 ";
                queryA += ") src; ";

                string queryB = @" SELECT COUNT(*) AS 'TotalCus' FROM Patient_Channel;";


                using (DataTable dt = new DataTable())
                {
                    using (DataSet dsA = commonDAO.GetDataFromDb(queryA))
                    {
                        dt.Clear();
                        dt.Columns.Add("RepeatCus");
                        dt.Columns.Add("TotalCus");

                        DataRow cus = dt.NewRow();

                        foreach (DataRow Row in dsA.Tables["tmpTable"].Rows)
                        {
                            cus["RepeatCus"] = Row["RepeatCus"].ToString();
                        }

                        using (DataSet dsB = commonDAO.GetDataFromDb(queryB))
                        {
                            foreach (DataRow Row in dsB.Tables["tmpTable"].Rows)
                            {
                                cus["TotalCus"] = Row["TotalCus"].ToString();
                            }
                        }
                        dt.Rows.Add(cus);
                    }

                    chrt.Titles.Clear();
                    chrt.Series.Clear();
                    chrt.Legends.Clear();

                    chrt.Titles.Add("Repeat Customers");

                    //Add a new Legend(if needed) and do some formating
                    chrt.Legends.Add("MyLegend");
                    chrt.Legends[0].LegendStyle = LegendStyle.Table;
                    chrt.Legends[0].Docking = Docking.Bottom;
                    chrt.Legends[0].Alignment = StringAlignment.Center;
                    chrt.Legends[0].Title = "Repeat Customers (Total)";
                    chrt.Legends[0].BorderColor = Color.Black;

                    chrt.Palette = ChartColorPalette.BrightPastel;

                    //Add a new chart-series
                    string seriesname = "MySeriesName";
                    chrt.Series.Add(seriesname);
                    chrt.Series[seriesname].IsValueShownAsLabel = true;

                    //set the chart-type to "Pie"
                    chrt.Series[seriesname].ChartType = SeriesChartType.Pie;

                    //Add some datapoints so the series. in this case you can pass the values to this method
                    chrt.Series[seriesname].Points.AddXY("Repeat Customers", Int32.Parse((dt.Rows[0]["RepeatCus"]).ToString()));
                    chrt.Series[seriesname].Points.AddXY("Total Customers", Int32.Parse(dt.Rows[0]["TotalCus"].ToString()));
                    //chrt.Series[seriesname].Points.AddXY("MyPointName3", value4);
                    //chrt.Series[seriesname].Points.AddXY("MyPointName4", value5);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + err.StackTrace, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegHMethod(Chart chrt)
        {
            try
            {
                string query = @" 
                            select count(Patient_Gender) as 'Count', Patient_Gender as 'Gender'
                            from Registered_Patient
                            group by Patient_Gender; ";


                chrt.Titles.Clear();
                chrt.Series.Clear();
                chrt.Legends.Clear();
                //chrt.ChartAreas.Clear();

                chrt.Titles.Add("All Customers According To Gender");

                //Add a new Legend(if needed) and do some formating
                chrt.Legends.Add("MyLegend");
                chrt.Legends[0].LegendStyle = LegendStyle.Table;
                chrt.Legends[0].Docking = Docking.Bottom;
                chrt.Legends[0].Alignment = StringAlignment.Center;
                chrt.Legends[0].Title = "Gender";
                chrt.Legends[0].BorderColor = Color.Black;


                chrt.Palette = ChartColorPalette.Excel;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    string seriesName = "Gender";

                    chrt.Series.Add(seriesName);
                    chrt.Series[seriesName].XValueMember = "Gender";
                    chrt.Series[seriesName].YValueMembers = "Count";
                    chrt.Series[seriesName].ChartType = SeriesChartType.Pie;

                    chrt.Series[seriesName].IsValueShownAsLabel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegIMethod(Chart chrt)
        {
            try
            {
                string query = @" 
                            select count(year(Patient_DoB)) as 'Count', year(Patient_DoB) as 'Year'
                            from Registered_Patient
                            group by year(Patient_DoB) ";


                chrt.Titles.Clear();
                chrt.Series.Clear();
                chrt.Legends.Clear();
                chrt.ChartAreas.Clear();

                chrt.Titles.Add("Customers According To Birth Year.");


                chrt.ChartAreas.Add("MyChartArea");
                chrt.ChartAreas[0].AxisX.Title = "\nBirth Year";
                chrt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;

                chrt.ChartAreas[0].AxisY.Title = "No Customers";
                chrt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;

                chrt.Palette = ChartColorPalette.Pastel;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    string seriesName = "Age";

                    chrt.Series.Add(seriesName);
                    chrt.Series[seriesName].XValueMember = "Year";
                    chrt.Series[seriesName].YValueMembers = "Count";
                    chrt.Series[seriesName].ChartType = SeriesChartType.Column;

                    chrt.Series[seriesName].IsValueShownAsLabel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegJMethod(Chart chrt)
        {
            try
            {
                string query = @" 
                            SELECT COUNT(*) as 'Count', Payment_Type 
                            FROM Payment GROUP 
                            BY Payment_Type";


                chrt.Titles.Clear();
                chrt.Series.Clear();
                chrt.Legends.Clear();
                //chrt.ChartAreas.Clear();

                chrt.Titles.Add("Payment Methods Used By The Customers");

                //Add a new Legend(if needed) and do some formating
                chrt.Legends.Add("MyLegend");
                chrt.Legends[0].LegendStyle = LegendStyle.Table;
                chrt.Legends[0].Docking = Docking.Bottom;
                chrt.Legends[0].Alignment = StringAlignment.Center;
                chrt.Legends[0].Title = "Payment Methods";
                chrt.Legends[0].BorderColor = Color.Black;


                chrt.Palette = ChartColorPalette.SeaGreen;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    string seriesName = "Gender";

                    chrt.Series.Add(seriesName);
                    chrt.Series[seriesName].XValueMember = "Payment_Type";
                    chrt.Series[seriesName].YValueMembers = "Count";
                    chrt.Series[seriesName].ChartType = SeriesChartType.Pie;

                    chrt.Series[seriesName].IsValueShownAsLabel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void chartPatientRegKMethod(Chart chrt)
        {
            try
            {
                string query = @" 
                            Select top 5 sum(Issue_Drug.Quantity) as 'Total', Drug_Inventory.Item_Name as 'Name'
                            from Issue_Drug 
                            inner join Drug_Inventory on Drug_Inventory.ItemIt_ID = Issue_Drug.ItemIt_ID
                            group by Issue_Drug.ItemIt_ID, Drug_Inventory.Item_Name 
                            order by Total DESC";


                chrt.Titles.Clear();
                chrt.Series.Clear();
                chrt.Legends.Clear();
                //chrt.ChartAreas.Clear();

                chrt.Titles.Add("Top 5 Drugs Bought By The Customer");

                //Add a new Legend(if needed) and do some formating
                chrt.Legends.Add("MyLegend");
                chrt.Legends[0].LegendStyle = LegendStyle.Table;
                chrt.Legends[0].Docking = Docking.Right;
                chrt.Legends[0].Alignment = StringAlignment.Center;
                chrt.Legends[0].Title = "Top 5 Drugs";
                chrt.Legends[0].BorderColor = Color.Black;


                chrt.Palette = ChartColorPalette.SeaGreen;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    string seriesName = "Gender";

                    chrt.Series.Add(seriesName);
                    chrt.Series[seriesName].XValueMember = "Name";
                    chrt.Series[seriesName].YValueMembers = "Total";
                    chrt.Series[seriesName].ChartType = SeriesChartType.Pie;

                    chrt.Series[seriesName].IsValueShownAsLabel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void chartPatientRegLMethod(Chart chrt)
        {
            try
            {
                string query = @" 
                            Select Top 10 Year(Registered_Patient.Patient_DoB) as 'Year' , count(*) as 'Count'
                            from Patient_Channel 
                            inner join Registered_Patient on Registered_Patient.Patient_Contact = Patient_Channel.Patient_Contact
                            group by Year(Registered_Patient.Patient_DoB)
                            order by Count DESC";


                chrt.Titles.Clear();
                chrt.Series.Clear();
                chrt.Legends.Clear();
                //chrt.ChartAreas.Clear();

                chrt.Titles.Add("Customer - Classified By Year Of Birth");

                //Add a new Legend(if needed) and do some formating
                chrt.Legends.Add("MyLegend");
                chrt.Legends[0].LegendStyle = LegendStyle.Table;
                chrt.Legends[0].Docking = Docking.Right;
                chrt.Legends[0].Alignment = StringAlignment.Center;
                chrt.Legends[0].Title = "Year of Birth  ";
                chrt.Legends[0].BorderColor = Color.Black;


                chrt.Palette = ChartColorPalette.BrightPastel;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    string seriesName = "birthyear";

                    chrt.Series.Add(seriesName);
                    chrt.Series[seriesName].XValueMember = "Year";
                    chrt.Series[seriesName].YValueMembers = "Count";
                    chrt.Series[seriesName].ChartType = SeriesChartType.Doughnut;

                    chrt.Series[seriesName].IsValueShownAsLabel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void chartPatientRegMMethod(Chart chrt)
        {
            try
            {
                string query = @" 
                            SELECT Year(Channel_Date) 
                            AS 'Year', COUNT(*) AS 'Total' 
                            FROM Patient_Channel 
                            GROUP BY Year(Channel_Date) 
							ORDER BY Year(Channel_Date)";


                chrt.Titles.Add("Customer Growth");
                chrt.Titles.Add("Number of Customers Attendance Over Time.");

                chrt.Series.Clear();
                chrt.Legends.Clear();

                /**
                //Add a new Legend(if needed) and do some formating
                chrt.Legends.Add("MyLegend");
                chrt.Legends[0].LegendStyle = LegendStyle.Table;
                chrt.Legends[0].Docking = Docking.Bottom;
                chrt.Legends[0].Alignment = StringAlignment.Center;
                chrt.Legends[0].Title = "Customer Growth (Yearly)";
                chrt.Legends[0].BorderColor = Color.Black;
                **/

                chrt.ChartAreas[0].AxisX.Title = "Year";
                chrt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;

                chrt.ChartAreas[0].AxisY.Title = "No of Customers";
                chrt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;

                chrt.Palette = ChartColorPalette.SeaGreen;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    string seriesName = "Customer Growth";

                    chrt.Series.Add(seriesName);
                    chrt.Series[seriesName].BorderWidth = 5;
                    chrt.Series[seriesName].XValueMember = "Year";
                    chrt.Series[seriesName].YValueMembers = "Total";
                    chrt.Series[seriesName].ChartType = SeriesChartType.Spline;

                    chrt.Series[seriesName].IsValueShownAsLabel = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        public DataGridView dataGridMostValuableCus(DataGridView dgv)
        {
            string query = "";

            try
            {
                query = @"select Top 10 
                        Registered_Patient.Patient_Name as 'Name',
                        count(*) as 'No of Visits', 
                        Patient_Channel.Patient_Contact as 'Contact No',
                        Registered_Patient.Patient_Email as 'Email', 
                        Registered_Patient.Patient_DoB as 'Date of Birth', 
                        Registered_Patient.Patient_Gender as 'Gender',
                        Registered_Patient.Patient_Register_Date as 'Custormer Since'
                        from Patient_Channel 
                        inner join Registered_Patient 
                        on Registered_Patient.Patient_Contact = Patient_Channel.Patient_Contact
                        group by Patient_Channel.Patient_Contact, Registered_Patient.Patient_Name, Registered_Patient.Patient_Email, Registered_Patient.Patient_DoB, Registered_Patient.Patient_Register_Date, Registered_Patient.Patient_Gender 
                        order by [No of Visits] desc";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    dgv.DataSource = ds.Tables["tmpTable"];
                }

                // DataGridView Style

                // Adjust the DataGridView
                //dataGridView1.AutoResizeColumns();
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.BorderStyle = BorderStyle.None;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dgv.ColumnHeadersHeight = 40;
                dgv.Columns[0].Width = 100;

                dgv.ReadOnly = true;

                // Remove Row headings  
                dgv.RowHeadersVisible = false;

                // Usage of Color
                dgv.RowsDefaultCellStyle.BackColor = Color.Lavender;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

                dgv.GridColor = Color.DimGray;
                dgv.BackgroundColor = Color.Lavender;

                // To change header style, EnableHeadersVisualStyles should be false.
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
                dgv.EnableHeadersVisualStyles = false;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dgv;
        }
    }
}
