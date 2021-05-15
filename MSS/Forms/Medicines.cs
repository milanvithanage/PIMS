using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Medicines : Form
    {

        String passItemID;
        String passItemName;
        String passItemDescription;
        String passItemCategory;
        String passUnitSellingPrice;
        String passReorderLevel;
        String passUnitBuyingprice;
        String passIssuedQuantity;
        String passDrugType;
        String passCategory;
        String passShelf;
        String passcurrentQuantity;

        //Following database connection only for search results

        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);

        SqlCommand cmd2 = new SqlCommand();

        public Medicines()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void Medicines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIMSDbDataSetDrugs.Drug_Inventory' table. You can move, or remove it, as needed.
            this.drug_InventoryTableAdapter1.Fill(this.pIMSDbDataSetDrugs.Drug_Inventory);
            // TODO: This line of code loads data into the 'pIMSDbDataSet.Drug_Inventory' table. You can move, or remove it, as needed.
            this.drug_InventoryTableAdapter.Fill(this.pIMSDbDataSet.Drug_Inventory);
            bunifuCustomLabelNoOfRecords.Text = "No of Records :" + (bunifuCustomDataGrid.Rows.Count - 1).ToString();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AddNewDrug AND = new AddNewDrug();
            AND.TopMost = true;
            AND.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (!(passItemID == null))
            {
                UpdateDrug UD = new UpdateDrug(passItemID, passItemName, passItemDescription, passUnitSellingPrice, passReorderLevel, passUnitBuyingprice, passIssuedQuantity, passShelf, passcurrentQuantity);
                UD.TopMost = true;
                UD.Show();

            }
            else
            {
                MessageBox.Show("Please select a prescription ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (passItemID == null)
            {
                MessageBox.Show("Please select a Drug ID for delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!(passItemID == null))
            {
                if (MessageBox.Show("Do you want to delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "DELETE FROM Drug_Inventory WHERE ItemIt_ID = " + passItemID;
                    i = DBConnection.cmd.ExecuteNonQuery();
                    DBConnection.cn.Close();

                }


                if (i == 1)
                {
                    MessageBox.Show("Drug remove from the system is successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {




            //Item category search
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
                    int x = 0;
                    cn.Open();

                    SqlCommand cmd5 = new SqlCommand("Select * from Drug_Inventory where Item_Category = '" + bunifuDropdownDrugCategory.selectedValue.ToString() + "'", cn);
                    SqlDataReader dr = cmd5.ExecuteReader();

                    while (dr.Read())
                    {

                        bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetDouble(4).ToString(), dr.GetInt32(5).ToString(), dr.GetDouble(6).ToString(), dr.GetInt32(7).ToString(), dr.GetString(8).ToString(), dr.GetString(9).ToString(), dr.GetString(10).ToString(), dr.GetInt32(11).ToString());
                        x = 1;
                    }
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




            }
            //Dtug type search
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
                    int x = 0;
                    cn.Open();

                    SqlCommand cmd5 = new SqlCommand("Select * from Drug_Inventory where Drug_Type = " + "'" + bunifuDropdownDrugType.selectedValue.ToString() + "'", cn);
                    SqlDataReader dr = cmd5.ExecuteReader();

                    while (dr.Read())
                    {

                        bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetDouble(4).ToString(), dr.GetInt32(5).ToString(), dr.GetDouble(6).ToString(), dr.GetInt32(7).ToString(), dr.GetString(8).ToString(), dr.GetString(9).ToString(), dr.GetString(10).ToString(), dr.GetInt32(11).ToString());
                        x = 1;
                    }
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

            }

            if (!(bunifuDropdownSearch.selectedIndex == 2 || bunifuDropdownSearch.selectedIndex == 3))
            {

                if (bunifuDropdownSearch.selectedIndex == 0 || bunifuMetroTextboxSearch.Text == "")
                {

                    MessageBox.Show("Please select a field and Enter a keyword", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                else
                {

                    //Drug Id search

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
                            int x = 0;
                            cn.Open();
                            SqlCommand cmd1 = new SqlCommand("Select * from Drug_Inventory where ItemIt_ID = " + bunifuMetroTextboxSearch.Text, cn);
                            SqlDataReader dr = cmd1.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetDouble(4).ToString(), dr.GetInt32(5).ToString(), dr.GetDouble(6).ToString(), dr.GetInt32(7).ToString(), dr.GetString(8).ToString(), dr.GetString(9).ToString(), dr.GetString(10).ToString(), dr.GetInt32(11).ToString());
                                x = 1;
                            }
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

                    }
                    //Item name search
                    if (bunifuDropdownSearch.selectedIndex == 4) {
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
                            int x = 0;
                            cn.Open();
                            SqlCommand cmd1 = new SqlCommand("Select * from Drug_Inventory where Item_Name = '" + bunifuMetroTextboxSearch.Text+"'", cn);
                            SqlDataReader dr = cmd1.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetDouble(4).ToString(), dr.GetInt32(5).ToString(), dr.GetDouble(6).ToString(), dr.GetInt32(7).ToString(), dr.GetString(8).ToString(), dr.GetString(9).ToString(), dr.GetString(10).ToString(), dr.GetInt32(11).ToString());
                                x = 1;
                            }
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


                    }
                }
            }
        }

        private void bunifuDropdownSearch_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdownSearch.selectedIndex == 2)
            {
                bunifuDropdownDrugCategory.Visible = true;
            }
            else
            {
                bunifuDropdownDrugCategory.Visible = false;
            }

            if (bunifuDropdownSearch.selectedIndex == 3)
            {
                bunifuDropdownDrugType.Visible = true;
            }
            else
            {
                bunifuDropdownDrugType.Visible = false;
            }
        }

        private void bunifuCustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                DataGridViewRow selectedRow = bunifuCustomDataGrid.Rows[index];

                passItemID = selectedRow.Cells[0].Value.ToString();
                passItemName = selectedRow.Cells[1].Value.ToString();
                passItemDescription = selectedRow.Cells[2].Value.ToString();
                passItemCategory = selectedRow.Cells[3].Value.ToString();
                passUnitSellingPrice = selectedRow.Cells[4].Value.ToString();
                passReorderLevel = selectedRow.Cells[5].Value.ToString();
                passUnitBuyingprice = selectedRow.Cells[6].Value.ToString();
                passIssuedQuantity = selectedRow.Cells[7].Value.ToString();
                passDrugType = selectedRow.Cells[8].Value.ToString();
                passCategory = selectedRow.Cells[9].Value.ToString();
                passShelf = selectedRow.Cells[10].Value.ToString();
                passcurrentQuantity = selectedRow.Cells[11].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid.DataSource = pIMSDbDataSet.Drug_Inventory;
        }
    }
    }

