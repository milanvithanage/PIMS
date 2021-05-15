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
    public partial class Users : Form
    {
        String passUID;
        String passUsername;
        String passFirstname;
        String passLastname;
        String passGender;
        String passUserType;
        String passContactNo;
        String passNIC;

        //Following database connection only for search results

        SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);

        SqlCommand cmd2 = new SqlCommand();

        public Users()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pIMSDbDataSetUsers.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pIMSDbDataSetUsers.Users);
            bunifuCustomLabelNoOfRecords.Text = "No of Records :" + (bunifuCustomDataGrid.Rows.Count - 1).ToString();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            AddNewUsers ANU = new AddNewUsers();
            ANU.TopMost = true;
            ANU.Show();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           if (!(passUID == null))
            {
                UpdateUsers UP = new UpdateUsers(passUID, passUsername, passFirstname, passLastname, passContactNo, passNIC);
                UP.TopMost = true;
                UP.Show();

            }
            else
            {
                MessageBox.Show("Please select a prescription ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (passUID == null)
            {
                MessageBox.Show("Please select a prescription ID for delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!(passUID == null))
            {
                if (MessageBox.Show("Do you want to delete ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "DELETE FROM Users WHERE Prescriptions_ID = " + passUID;
                    i = DBConnection.cmd.ExecuteNonQuery();
                    DBConnection.cn.Close();
                }


                if (i == 1)
                {
                    MessageBox.Show("User remove from the system is successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuDropdownSearch_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdownSearch.selectedIndex == 5)
            {
                bunifuDropdownUserType.Visible = true;
            }
            else
            {
                bunifuDropdownUserType.Visible = false;
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            //Usertype search
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
                    int x = 0;
                    cn.Open();
                    SqlCommand cmd4 = new SqlCommand("Select * from Users where UserType = " + "'" + bunifuDropdownUserType.selectedValue.ToString() + "'", cn);
                    SqlDataReader dr = cmd4.ExecuteReader(); ;

                    while (dr.Read())
                    {

                        bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetString(4).ToString(), dr.GetString(5).ToString(), dr.GetInt32(7).ToString(), dr.GetInt32(8).ToString());
                        x = 1;
                    }
                    if (x == 0)
                    {
                        MessageBox.Show("No results");
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

                    //User Id search


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
                            SqlCommand cmd1 = new SqlCommand("Select * from Users where ID = " + bunifuMetroTextboxSearch.Text, cn);
                            SqlDataReader dr = cmd1.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetString(4).ToString(), dr.GetString(5).ToString(), dr.GetInt32(7).ToString(), dr.GetInt32(8).ToString());
                                x = 1;
                            }
                            if (x == 0)
                            {
                                MessageBox.Show("No results");
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

                    // Username  search

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
                            SqlCommand cmd2 = new SqlCommand("Select * from Users where Username = " + "'" + bunifuMetroTextboxSearch.Text + "'", cn);
                            SqlDataReader dr = cmd2.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetString(4).ToString(), dr.GetString(5).ToString(), dr.GetInt32(7).ToString(), dr.GetInt32(8).ToString());
                                x = 1;
                            }
                            if (x == 0)
                            {
                                MessageBox.Show("No results");
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

                    //Firstname search

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
                            SqlCommand cmd3 = new SqlCommand("Select * from Users where FirstName = " + "'" + bunifuMetroTextboxSearch.Text + "'", cn);
                            SqlDataReader dr = cmd3.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetString(4).ToString(), dr.GetString(5).ToString(), dr.GetInt32(7).ToString(), dr.GetInt32(8).ToString());
                                x = 1;
                            }
                            if (x == 0)
                            {
                                MessageBox.Show("No results");
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
                    //Lastname search

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
                            int x = 0;
                            cn.Open();
                            SqlCommand cmd4 = new SqlCommand("Select * from Users where LastName = " + "'" + bunifuMetroTextboxSearch.Text + "'", cn);
                            SqlDataReader dr = cmd4.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetString(4).ToString(), dr.GetString(5).ToString(), dr.GetInt32(7).ToString(), dr.GetInt32(8).ToString());
                                x = 1;
                            }
                            if (x == 0)
                            {
                                MessageBox.Show("No results");
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


                    //Contact No Search

                    if (bunifuDropdownSearch.selectedIndex == 6)
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
                            SqlCommand cmd4 = new SqlCommand("Select * from Users where ContactNo = " + bunifuMetroTextboxSearch.Text, cn);
                            SqlDataReader dr = cmd4.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetString(4).ToString(), dr.GetString(5).ToString(), dr.GetInt32(7).ToString(), dr.GetInt32(8).ToString());
                                x = 1;
                            }
                            if (x == 0)
                            {
                                MessageBox.Show("No results");
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
                    //NIC Search
                    if (bunifuDropdownSearch.selectedIndex == 7)
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
                            SqlCommand cmd4 = new SqlCommand("Select * from Users where NIC = " + bunifuMetroTextboxSearch.Text, cn);
                            SqlDataReader dr = cmd4.ExecuteReader(); ;

                            while (dr.Read())
                            {

                                bunifuCustomDataGrid.Rows.Add(dr.GetInt32(0).ToString(), dr.GetString(1).ToString(), dr.GetString(2).ToString(), dr.GetString(3).ToString(), dr.GetString(4).ToString(), dr.GetString(5).ToString(), dr.GetInt32(7).ToString(), dr.GetInt32(8).ToString());
                                x = 1;
                            }
                            if (x == 0)
                            {
                                MessageBox.Show("No results");
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

        private void bunifuCustomDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            try
            {
                DataGridViewRow selectedRow = bunifuCustomDataGrid.Rows[index];

                passUID = selectedRow.Cells[0].Value.ToString();
                passUsername = selectedRow.Cells[1].Value.ToString();
                passFirstname = selectedRow.Cells[2].Value.ToString();
                passLastname = selectedRow.Cells[3].Value.ToString();
                passGender = selectedRow.Cells[4].Value.ToString();
                passUserType = selectedRow.Cells[5].Value.ToString();
                passContactNo = selectedRow.Cells[6].Value.ToString();
                passNIC = selectedRow.Cells[7].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid.DataSource = pIMSDbDataSetUsers.Users;
        }
    }
}
