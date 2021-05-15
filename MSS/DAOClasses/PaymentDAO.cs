using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace MSS
{
    class PaymentDAO
    {
        // This class is used to get data from the database related to the feedback form
        // Updated 17 Dec 2017
        // Version 01
        // Version 02
        // Changes - Add try catch for NoOfCustomers method.

        private string provider = ConfigurationManager.AppSettings["provider"];
        private string connectionString = ConfigurationManager.AppSettings["connectionString"];
        
        CommonDAO commonDAO = new CommonDAO();        

        public void AutoCompletePresID(TextBox txtPrescriptionID)
        {
            try
            {
                txtPrescriptionID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPrescriptionID.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection strngCollection = new AutoCompleteStringCollection();

                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

                using (DbConnection connection = factory.CreateConnection())
                {
                    // Verify Database connection
                    if (connection == null)
                    {
                        MessageBox.Show("Connection Error", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.ConnectionString = connectionString;
                    connection.Open();

                    DbCommand command = factory.CreateCommand();

                    if (command == null)
                    {
                        MessageBox.Show("Command Error", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string query = @"SELECT Prescriptions_ID 
                                FROM Issue_Receipt 
                                EXCEPT
                                SELECT Issue_Receipt.Prescriptions_ID 
                                FROM Issue_Receipt 
                                INNER JOIN Payment 
                                ON Payment.Prescriptions_ID = Issue_Receipt.Prescriptions_ID;";

                    // Read data
                    command.Connection = connection;
                    command.CommandText = query;

                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            strngCollection.Add(($"{dataReader["Prescriptions_ID"]}").Trim());
                        }
                        txtPrescriptionID.AutoCompleteCustomSource = strngCollection;
                    }
                }

            }
            catch (Exception)
            {
                // Do not add a message box
                //MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public string AutoCompletePresFee(string txtPrescriptionID)
        {
            string query = "";
            string output = "";

            try
            {
                query = @"SELECT SUM(price) AS 'TotalPrice'
                        FROM Issue_Drug t1
                        INNER JOIN Issue_Receipt t2 ON t1.Reference_No = t2.Reference_No
                        WHERE t2.Prescriptions_ID = " + txtPrescriptionID;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        //MessageBox.Show(Row["TotalPrice"].ToString());
                        output = Row["TotalPrice"].ToString();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }

        public List<string> AutoCompleteAllDetails(string txtPrescriptionID)
        {
            string query = "";
            List<string> outputList = new List<string>();

            try
            {
                query = @"SELECT t4.Patient_Name, t4.Patient_Contact, t1.Doctor_Name, t3.Channel_Date, t1.Channel_Fee
                        FROM Doctor t1 
                        INNER JOIN Prescriptions t2 ON t1.Doctor_ID = t2.Doctor_ID 
                        INNER JOIN Patient_Channel t3 ON t1.Doctor_ID = t3.Doctor_ID 
                        INNER JOIN Registered_Patient t4 ON t3.Patient_Contact = t4.Patient_Contact
                        WHERE t2.Prescriptions_ID = " + txtPrescriptionID;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        //MessageBox.Show(Row["TotalPrice"].ToString());
                        //output = Row["TotalPrice"].ToString();
                        outputList.Insert(0, Row["Patient_Name"].ToString());
                        outputList.Insert(1, Row["Patient_Contact"].ToString());
                        outputList.Insert(2, Row["Doctor_Name"].ToString());
                        outputList.Insert(3, Row["Channel_Date"].ToString());
                        outputList.Insert(4, Row["Channel_Fee"].ToString());
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return outputList;
        }

        public DataGridView AutoCompletePresDesc(string txtPrescriptionID, DataGridView dgv)
        {
            string query = "";

            try
            {
                query = @"SELECT t3.ItemIt_ID AS 'Item ID',
                        t3.Item_Name AS 'Item Name', 
                        t3.Drug_Type AS 'Drug Type', 
                        t3.Unit_Selling_Price AS 'Unit Price', 
                        t1.Quantity, t1.Price AS 'Total Price' 
                        FROM Issue_Drug t1 
                        INNER JOIN Issue_Receipt t2 ON t1.Reference_No = t2.Reference_No 
                        INNER JOIN Drug_Inventory t3 ON t1.ItemIt_ID = t3.ItemIt_ID 
                        WHERE t2.Prescriptions_ID = " + txtPrescriptionID; 

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


                // Remove Row headings  
                dgv.RowHeadersVisible = false;

                // Usage of Color
                dgv.RowsDefaultCellStyle.BackColor = Color.Lavender;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

                dgv.GridColor = Color.DimGray;

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

        public int PaymentSubmit(string Prescriptions_ID, string Amount, string Payment_Date, string Customer_Contact, string Payment_Type)
        {
            int rowsUpdated = 0;

            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

                using (DbConnection connection = factory.CreateConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Connection Error", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return rowsUpdated;
                    }

                    connection.ConnectionString = connectionString;
                    connection.Open();

                    DbCommand command = factory.CreateCommand();

                    if (command == null)
                    {
                        MessageBox.Show("Command Error", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return rowsUpdated;
                    }

                    string query = "";

                    query += "INSERT INTO [Payment] ";
                    query += "(Prescriptions_ID, Amount, Payment_Date, Customer_Contact, Payment_Type) ";
                    query += "VALUES ";
                    query += "(@Prescriptions_ID, @Amount, @Payment_Date, @Customer_Contact, @Payment_Type) ";

                    command.Connection = connection;
                    //command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = query;

                    // Parameter 01
                    DbParameter parameterA = command.CreateParameter();
                    parameterA.ParameterName = "@Prescriptions_ID";
                    parameterA.Value = Prescriptions_ID;
                    command.Parameters.Add(parameterA);

                    // Parameter 02
                    DbParameter parameterB = command.CreateParameter();
                    parameterB.ParameterName = "@Amount";
                    parameterB.Value = Amount;
                    command.Parameters.Add(parameterB);

                    // Parameter 03
                    DbParameter parameterC = command.CreateParameter();
                    parameterC.ParameterName = "@Payment_Date";
                    parameterC.Value = Payment_Date;
                    command.Parameters.Add(parameterC);

                    // Parameter 04
                    DbParameter parameterD = command.CreateParameter();
                    parameterD.ParameterName = "@Customer_Contact";
                    parameterD.Value = Customer_Contact;
                    command.Parameters.Add(parameterD);

                    // Parameter 05
                    DbParameter parameterE = command.CreateParameter();
                    parameterE.ParameterName = "@Payment_Type";
                    parameterE.Value = Payment_Type;
                    command.Parameters.Add(parameterE);

                    rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Data has been added", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }                
            }
            catch (DbException err)
            {
                MessageBox.Show("" + err.Message , "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show("" + err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rowsUpdated;
        }

        public DataSet PrescriptionList(string txtPrescriptionID)
        {
            string query = "";
            DataSet ds = new DataSet();

            try
            {
                query = @"SELECT t3.ItemIt_ID,
                        t3.Item_Name, 
                        t3.Drug_Type, 
                        t3.Unit_Selling_Price, 
                        t1.Quantity, t1.Price 
                        FROM Issue_Drug t1 
                        INNER JOIN Issue_Receipt t2 ON t1.Reference_No = t2.Reference_No 
                        INNER JOIN Drug_Inventory t3 ON t1.ItemIt_ID = t3.ItemIt_ID 
                        WHERE t2.Prescriptions_ID = " + txtPrescriptionID;

                ds = commonDAO.GetDataFromDb(query);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds;
        }
    }
}
