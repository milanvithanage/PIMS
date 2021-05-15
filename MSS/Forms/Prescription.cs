using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Prescription : Form
    {

        String passPID;
        String passDate;
        String passDeseastpe;
        String passDescription;
        String passDoctorID;
        String passPatientID;

        //Following database connection only for search results

        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);

        SqlCommand cmd2 = new SqlCommand();


        public Prescription()
        {
            InitializeComponent();
            this.ShowIcon = false;

            bunifuDatepicker.Visible = false;
            bunifuCustomLabelNoOfRecords.Text = "No of Records :" + (bunifuCustomDataGrid.Rows.Count - 1).ToString();
        }

     
        private void Prescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIMSDbDataSetPrescription.Prescriptions' table. You can move, or remove it, as needed.
            this.prescriptionsTableAdapter.Fill(this.pIMSDbDataSetPrescription.Prescriptions);
            bunifuCustomLabelNoOfRecords.Text = "No of Records :" + (bunifuCustomDataGrid.Rows.Count - 1).ToString();

        }

        private void bunifuCustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                DataGridViewRow selectedRow = bunifuCustomDataGrid.Rows[index];

                passPID = selectedRow.Cells[0].Value.ToString();
                passDate = selectedRow.Cells[1].Value.ToString();
                passDeseastpe = selectedRow.Cells[2].Value.ToString();
                passDescription = selectedRow.Cells[3].Value.ToString();
                passDoctorID = selectedRow.Cells[4].Value.ToString();
                passPatientID = selectedRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid.DataSource = pIMSDbDataSetPrescription.Prescriptions;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (passPID == null)
            {
                MessageBox.Show("Please select a prescription ID for delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!(passPID == null))
            {
                if (MessageBox.Show("Do you want to delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "DELETE FROM Prescriptions WHERE Prescriptions_ID = " + passPID;
                    i = DBConnection.cmd.ExecuteNonQuery();
                    DBConnection.cn.Close();

                }


                if (i == 1)
                {
                    MessageBox.Show("Prescription remove from the system is successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           

            if (!(passPID == null))
            {
                UpdatePrescription UP = new UpdatePrescription(passPID, passDescription, passDoctorID, passPatientID);
                UP.TopMost = true;
                UP.Show();

            }
            else
            {
                MessageBox.Show("Please select a prescription ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       
    }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AddNewPrescription ANP = new AddNewPrescription();
            ANP.TopMost = true;
            ANP.Show();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {



            //Date search
            if (bunifuDropdownSearch.selectedIndex == 5)
            {

                if (this.bunifuCustomDataGrid.DataSource != null)
                {
                    this.bunifuCustomDataGrid.DataSource = null;
                }
                else
                {
                    this.bunifuCustomDataGrid.Rows.Clear();
                }



                try
                {

                    cn.Open();

                    SqlCommand cmd5 = new SqlCommand("Select * from Prescriptions where Prescriptions_Date = " + "'" + bunifuDatepicker.Value.ToShortDateString() + "'", cn);
                    SqlDataReader dr = cmd5.ExecuteReader();

                    while (dr.Read())
                    {

                        bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetDateTime(1).ToString("dd/MM/yyyy"), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetInt32(4).ToString(), dr.GetInt32(5).ToString());

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




            }
            else
            {

                if (bunifuDropdownSearch.selectedIndex == 0 || bunifuMetroTextboxSearch.Text == "")
                {

                    MessageBox.Show("Please select a field and Enter a keyword", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                else
                {

                    //Prescription Id search

                    if (bunifuDropdownSearch.selectedIndex == 1)
                    {
                        if (this.bunifuCustomDataGrid.DataSource != null)
                        {
                            this.bunifuCustomDataGrid.DataSource = null;
                        }
                        else
                        {
                            this.bunifuCustomDataGrid.Rows.Clear();
                        }



                        try
                        {
                            cn.Open();
                            SqlCommand cmd1 = new SqlCommand("Select * from Prescriptions where Prescriptions_ID = " + bunifuMetroTextboxSearch.Text, cn);
                            SqlDataReader dr = cmd1.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetDateTime(1).ToString("dd/MM/yyyy"), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetInt32(4).ToString(), dr.GetInt32(5).ToString());

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

                    }

                    // Deaseas type search

                    if (bunifuDropdownSearch.selectedIndex == 2)
                    {

                        if (this.bunifuCustomDataGrid.DataSource != null)
                        {
                            this.bunifuCustomDataGrid.DataSource = null;
                        }
                        else
                        {
                            this.bunifuCustomDataGrid.Rows.Clear();
                        }



                        try
                        {
                            cn.Open();
                            SqlCommand cmd2 = new SqlCommand("Select * from Prescriptions where Deseas_type = " + bunifuMetroTextboxSearch.Text, cn);
                            SqlDataReader dr = cmd2.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetDateTime(1).ToString("dd/MM/yyyy"), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetInt32(4).ToString(), dr.GetInt32(5).ToString());

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



                    }

                    //Pation contact search

                    if (bunifuDropdownSearch.selectedIndex == 3)
                    {

                        if (this.bunifuCustomDataGrid.DataSource != null)
                        {
                            this.bunifuCustomDataGrid.DataSource = null;
                        }
                        else
                        {
                            this.bunifuCustomDataGrid.Rows.Clear();
                        }



                        try
                        {
                            cn.Open();
                            SqlCommand cmd3 = new SqlCommand("Select * from Prescriptions where Patient_Contact = " + bunifuMetroTextboxSearch.Text, cn);
                            SqlDataReader dr = cmd3.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetDateTime(1).ToString("dd/MM/yyyy"), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetInt32(4).ToString(), dr.GetInt32(5).ToString());

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


                    }
                    //Doctor ID search

                    if (bunifuDropdownSearch.selectedIndex == 4)
                    {

                        if (this.bunifuCustomDataGrid.DataSource != null)
                        {
                            this.bunifuCustomDataGrid.DataSource = null;
                        }
                        else
                        {
                            this.bunifuCustomDataGrid.Rows.Clear();
                        }



                        try
                        {
                            cn.Open();
                            SqlCommand cmd4 = new SqlCommand("Select * from Prescriptions where Doctor_ID = " + bunifuMetroTextboxSearch.Text, cn);
                            SqlDataReader dr = cmd4.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetDateTime(1).ToString("dd/MM/yyyy"), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetInt32(4).ToString(), dr.GetInt32(5).ToString());

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


                    }




                }
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
            IssueDrug ID = new IssueDrug();
            ID.TopMost = true;
            ID.Show();
            
        }

        private void bunifuDropdownSearch_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdownSearch.selectedIndex == 5)
            {
                bunifuDatepicker.Visible = true;
            }
            else
            {
                bunifuDatepicker.Visible = false;
            }
        }

       


        }
    }

