using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MSS
{
    class DashboardDAO
    {
        // This class is used to display data in dashboard
        // Updated 17 Dec 2017
        // Version 01        

        CommonDAO commonDAO = new CommonDAO();

        public string CustomersMoreDetails()
        {
            string output = "";
            string query = "";

            try
            {
                query = @"Select count(*) as 'Count'
                        from Registered_Patient
                        where year(Patient_Register_Date) = year(CAST(GETDATE() AS DATE))
                        and month(Patient_Register_Date) =  month(CAST(GETDATE() AS DATE))";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        output += (Row["Count"].ToString()).PadLeft(3, '0');
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;
        }

        public string FeedbacksMoreDetails()
        {
            string output = "";
            string query = "";

            try
            {
                query = @"select count(*) as 'Count' 
                        from Customer_Feedback 
                        where Rating = 'Very Dissatisfied' OR Rating = 'Dissatisfied'";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        output += (Row["Count"].ToString()).PadLeft(3, '0');
                    }
                }

                output += " | ";

                query = @"select count(*) as 'Count' 
                        from Customer_Feedback 
                        where Rating = 'Neutral' 
                        OR Rating = 'Stisfied'
                        OR Rating = 'Very Stisfied'";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        output += (Row["Count"].ToString()).PadLeft(3, '0');
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;
        }

        public string DrugsMoreDetails()
        {
            string output = "";
            string query = "";

            try
            {
                query = @"select count(*) as 'Count' from Drug_Inventory
                        where Reorder_level > current_Quantity";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        output += (Row["Count"].ToString()).PadLeft(3, '0');
                    }
                }

                output += " | ";

                query = @"select count(*) as 'Count' from Drug_Inventory
                        where Reorder_level < current_Quantity";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        output += (Row["Count"].ToString()).PadLeft(3, '0');
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;
        }

        public string AppointmentsMoreDetails()
        {
            string output = "";
            string query = "";

            try
            {
                query = @"Select count(*) as 'count' 
                        from Patient_Channel
                        where CAST(GETDATE() AS DATE) < Channel_Date";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        output += (Row["Count"].ToString()).PadLeft(3, '0');
                    }
                }

                output += " | ";

                query = @"select count(*) as 'count' 
                        from Patient_Channel
                        where CAST(GETDATE() AS DATE) >= Channel_Date";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        output += (Row["Count"].ToString()).PadLeft(3, '0');
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;
        }

        public string NoOfWhat(string query)
        {
            string output = "";

            try
            {
                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        output = Row["Count"].ToString();
                        output = output.PadLeft(3, '0');
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return output;
        }

        public void ChartDashA(Chart chrt)
        {
            string query = @"Select Top 5 count(*) as 'yValue', 
                            (Registered_Patient.Patient_Name + ' (' + CONVERT(varchar, Patient_Channel.Patient_Contact) + ')') as 'xValue'
                            from Patient_Channel 
                            inner join Registered_Patient 
                            on Registered_Patient.Patient_Contact = Patient_Channel.Patient_Contact
                            group by Patient_Channel.Patient_Contact, Registered_Patient.Patient_Name 
                            order by yValue desc";

            string title = "Top 5 Customers";
            string legendsTitle = "Customers";
            string seriesName = "Customers";

            Font fnt =  new Font("Microsoft Sans Serif", 15);
            Color foreClr = Color.DimGray;

            ChartColorPalette chrtColPlt = ChartColorPalette.BrightPastel;
            SeriesChartType chrtType = SeriesChartType.Doughnut;

            ChartWhat(chrt, query, title, legendsTitle, seriesName, chrtColPlt, chrtType, fnt, foreClr);
        }

        public void ChartDashB(Chart chrt)
        {
            string query = @"Select Top 5 count(*) as 'yValue', 
                            (Registered_Patient.Patient_Name + ' (' + CONVERT(varchar, Patient_Channel.Patient_Contact) + ')') as 'xValue'                            
                            from Patient_Channel 
                            inner join Registered_Patient 
                            on Registered_Patient.Patient_Contact = Patient_Channel.Patient_Contact
                            group by Patient_Channel.Patient_Contact, Registered_Patient.Patient_Name 
                            order by yValue desc";

            string title = "Top 5 Requested Doctors";
            string legendsTitle = "Doctors";
            string seriesName = "Doctors";

            Font fnt = new Font("Microsoft Sans Serif", 15);
            Color foreClr = Color.DimGray;

            ChartColorPalette chrtColPlt = ChartColorPalette.BrightPastel;
            SeriesChartType chrtType = SeriesChartType.Doughnut;

            ChartWhat(chrt, query, title, legendsTitle, seriesName, chrtColPlt, chrtType, fnt, foreClr);
        }

        public void ChartDashC(Chart chrt)
        {
            string query = @"Select top 5
                            (x.Quantity * (Drug_Inventory.Unit_Selling_Price - Drug_Inventory.Unit_Buying_Price)) as 'yValue',
                            (RTRIM(Drug_Inventory.Item_Name) + ' (' + CONVERT(varchar, Drug_Inventory.ItemIt_ID) + ')') as 'xValue'
                            from (
                            select Issue_Drug.ItemIt_ID, sum(Issue_Drug.Quantity) as 'Quantity'
                            from Issue_Drug 
                            inner join Drug_Inventory 
                            on Drug_Inventory.ItemIt_ID = Issue_Drug.ItemIt_ID
                            group by Issue_Drug.ItemIt_ID
                            ) x
                            inner join Drug_Inventory
                            on x.ItemIt_ID = Drug_Inventory.ItemIt_ID
                            order by yValue desc";

            string title = "Top 5 Profitable Drugs";
            string legendsTitle = "Drug";
            string seriesName = "Doctors";

            Font fnt = new Font("Microsoft Sans Serif", 15);
            Color foreClr = Color.DimGray;

            ChartColorPalette chrtColPlt = ChartColorPalette.BrightPastel;
            SeriesChartType chrtType = SeriesChartType.Doughnut;

            ChartWhat(chrt, query, title, legendsTitle, seriesName, chrtColPlt, chrtType, fnt, foreClr);
        }

        public void ChartDashD(Chart chrt)
        {
            string query = @"Select top 5
                            Doctor.Specialization as 'xValue', 
                            count(*) as 'yValue'
                            from Patient_Channel 
                            inner join Doctor
                            on Doctor.Doctor_ID = Patient_Channel.Doctor_ID
                            group by Doctor.Specialization
                            order by yValue desc";

            string title = "Top 5 Medical Specialties";
            string legendsTitle = "Specialty";
            string seriesName = "Specialty";

            Font fnt = new Font("Microsoft Sans Serif", 15);
            Color foreClr = Color.DimGray;

            ChartColorPalette chrtColPlt = ChartColorPalette.BrightPastel;
            SeriesChartType chrtType = SeriesChartType.Doughnut;

            ChartWhat(chrt, query, title, legendsTitle, seriesName, chrtColPlt, chrtType, fnt, foreClr);
        }

        public void ChartWhat(Chart chrt, string query, string title, string legendsTitle, string seriesName, ChartColorPalette chrtColPlt, SeriesChartType chrtType, Font fnt, Color foreClr)
        {
            try
            {
                chrt.Titles.Clear();
                chrt.Series.Clear();
                chrt.Legends.Clear();
                chrt.ChartAreas.Clear();

                chrt.ChartAreas.Add("Default");

                chrt.Titles.Add(title);
                chrt.Titles[0].Font = fnt;
                chrt.Titles[0].ForeColor = foreClr;

                chrt.Legends.Add("MyLegend");
                chrt.Legends[0].LegendStyle = LegendStyle.Table;
                chrt.Legends[0].Docking = Docking.Bottom;
                chrt.Legends[0].Alignment = StringAlignment.Center;
                chrt.Legends[0].Title = legendsTitle;
                chrt.Legends[0].BorderColor = Color.Black;

                chrt.BackColor = Color.Transparent;
                chrt.Legends[0].BackColor = Color.Transparent;
                chrt.ChartAreas[0].BackColor = Color.Transparent;

                chrt.Palette = chrtColPlt;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    chrt.DataSource = ds.Tables["tmpTable"];

                    chrt.Series.Add(seriesName);
                    chrt.Series[seriesName].XValueMember = "xValue";
                    chrt.Series[seriesName].YValueMembers = "yValue";
                    chrt.Series[seriesName].ChartType = chrtType;
                    chrt.Series[seriesName].IsValueShownAsLabel = true;
                    //chrt.Legends["Legend1"].Position = chrt.
                    //chrt.Series[seriesName].Font = new Font("Microsoft Sans Serif", 50);
                    //chrt.Series[seriesName]["3DLabelLineSize"] = "5";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataGridView dataGridDrugRemaining(DataGridView dgv)
        {
            string query = "";

            try
            {
                query = @"Select ItemIt_ID as 'Item ID', 
                        (' ' + CONVERT(varchar, Item_Name)) as 'Item name', 
                        Reorder_level as 'ROP', 
                        current_Quantity as 'Current Quantity', 
                        Issued_Qunatity as 'Issued', 
                        current_Quantity - Reorder_level as 'Need'
                        from Drug_Inventory
                        where (Reorder_level + (5 * (Reorder_level/100))) > current_Quantity
                        order by Need asc";

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
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                dgv.EnableHeadersVisualStyles = false;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dgv;
        }

        public DataGridView dataGridFutureAppointment(DataGridView dgv)
        {
            string query = "";

            try
            {
                query = @"Select 
                        (' ' + CONVERT(varchar, Patient_Channel.Channel_ID)) as 'Channel ID',
                        Patient_Channel.Channel_Date as 'Channel Date',
                        Patient_Channel.Channel_Time as 'Channel Time', 
                        Patient_Channel.Channel_Number as 'Chanel No',
                        Patient_Channel.Room_Number as 'Room No',
                        (Doctor_Name + ' (' + CONVERT(varchar, Doctor.Doctor_ID) + ')') as 'Doctor', 
                        (Registered_Patient.Patient_Name + ' ('+ CONVERT(varchar, Patient_Channel.Patient_Contact) + ')' ) as 'Customer'
                        from Patient_Channel
                        inner join Registered_Patient 
                        on Registered_Patient.Patient_Contact = Patient_Channel.Patient_Contact
                        inner join Doctor
                        on Doctor.Doctor_ID = Patient_Channel.Doctor_ID
                        where CAST(GETDATE() AS DATE) < Patient_Channel.Channel_Date";

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
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
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
