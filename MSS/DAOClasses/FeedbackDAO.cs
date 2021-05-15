using System;
using System.Configuration;
using System.Data.Common;
using System.Windows.Forms;

namespace MSS
{
    class FeedbackDAO
    {
        // This class is no longer used.        

        // This class was used to get data from the database related to the feedback form
        // Updated 17 Dec 2017
        // Version 01

        /**
        private string provider = ConfigurationManager.AppSettings["provider"];
        private string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public void NoOfCustomers(TextBox txtPrescriptionID)
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

                // Read data
                command.Connection = connection;
                command.CommandText = "SELECT Prescriptions_ID FROM [Prescriptions]";

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

        public string AutoCompleteCusName(string txtPrescriptionID)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            string txtCusName = "";             

            try
            {
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

                    // Read data
                    command.Connection = connection;
                    string queryCommand = "";
                    queryCommand += "SELECT Registered_Patient.Patient_Contact, Registered_Patient.Patient_Name ";
                    queryCommand += "FROM Registered_Patient ";
                    queryCommand += "INNER JOIN Prescriptions ON Prescriptions.Patient_Contact = Registered_Patient.Patient_Contact ";
                    queryCommand += "WHERE Prescriptions.Prescriptions_ID = " + txtPrescriptionID;

                    command.CommandText = queryCommand;

                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            txtCusName = ($"{dataReader["Patient_Name"]}").Trim();
                        }                        
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
            }
            
            return txtCusName;
        }

        public string AutoCompleteCusNo(string txtPrescriptionID)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            string txtCusNo = "";

            try
            {
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

                    // Read data
                    command.Connection = connection;
                    string queryCommand = "";
                    queryCommand += "SELECT Registered_Patient.Patient_Contact, Registered_Patient.Patient_Name ";
                    queryCommand += "FROM Registered_Patient ";
                    queryCommand += "INNER JOIN Prescriptions ON Prescriptions.Patient_Contact = Registered_Patient.Patient_Contact ";
                    queryCommand += "WHERE Prescriptions.Prescriptions_ID = " + txtPrescriptionID;

                    command.CommandText = queryCommand;

                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            txtCusNo = ($"{dataReader["Patient_Contact"]}").Trim();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                // No operation
            }
            return txtCusNo;
        }

        public void FeedbackSubmit(string feedbackType, string txtPresID, string txtService, string txtIssue, string rTxtFeedback)
        {
            try
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

                using (DbConnection connection = factory.CreateConnection())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Connection Error", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    connection.ConnectionString = connectionString;
                    connection.Open();

                    DbCommand command = factory.CreateCommand();

                    if (command == null)
                    {
                        MessageBox.Show("Command Error", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "";

                    query += "INSERT INTO [Customer_Feedback] ";
                    query += "(Prescriptions_ID, Feedback, Service, Issue, FeedbackType) ";
                    query += "VALUES ";
                    query += "(@Prescriptions_ID, @Feedback, @Service, @Issue, @FeedbackType) ";

                    command.Connection = connection;
                    //command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = query;

                    // Parameter 01
                    DbParameter parameterA = command.CreateParameter();
                    parameterA.ParameterName = "@Prescriptions_ID";
                    parameterA.Value = txtPresID;
                    command.Parameters.Add(parameterA);

                    // Parameter 02
                    DbParameter parameterB = command.CreateParameter();
                    parameterB.ParameterName = "@Feedback";
                    parameterB.Value = rTxtFeedback;
                    command.Parameters.Add(parameterB);

                    // Parameter 03
                    DbParameter parameterC = command.CreateParameter();
                    parameterC.ParameterName = "@Service";
                    parameterC.Value = txtService;
                    command.Parameters.Add(parameterC);

                    // Parameter 04
                    DbParameter parameterD = command.CreateParameter();
                    parameterD.ParameterName = "@Issue";
                    parameterD.Value = txtIssue;
                    command.Parameters.Add(parameterD);

                    // Parameter 05
                    DbParameter parameterE = command.CreateParameter();
                    parameterE.ParameterName = "@FeedbackType";
                    parameterE.Value = feedbackType;
                    command.Parameters.Add(parameterE);

                    int rowsUpdated = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Data has been added", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (DbException)
            {
                MessageBox.Show("Feedback for the related Prescription is already added.", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show("" + err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    **/
    }
}
