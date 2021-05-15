using System;
using System.Configuration;
using System.Data.Common;
using System.Windows.Forms;

namespace MSS
{
    class DBTest
    {
        public void DbTesting()
        {
            // This class is used to verify database connection when starting application (Login Form)
            // Updated 17 Dec 2017
            // Version 01

            try
            {
                // This method will be called from the Main.cs(Main_Load)

                string provider = ConfigurationManager.AppSettings["provider"];
                string connectionString = ConfigurationManager.AppSettings["connectionString"];

                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

                using (DbConnection connection = factory.CreateConnection())
                {
                    // Verify Database connection
                    if (connection == null)
                    {
                        MessageBox.Show("Connection Error", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Console.WriteLine("Connection Error");
                        return;
                    }

                    connection.ConnectionString = connectionString;
                    connection.Open();

                    DbCommand command = factory.CreateCommand();

                    if (command == null)
                    {
                        MessageBox.Show("Command Error", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Console.WriteLine("Command Error");
                        return;
                    }

                    // Read data
                    /**
                    // Sample Query 
                    command.Connection = connection;
                    command.CommandText = "Select * from Registered_Patient";

                    using (DbDataReader dataReader = command.ExecuteReader())
                    {
                        string result = "";

                        while (dataReader.Read())
                        {
                            result += $"{dataReader["Patient_Name"]}" + $"{dataReader["Patient_NIC"]}" + "\n";                       
                            //Console.WriteLine($"{dataReader["User_ID"]}" + $"{dataReader["ContactNo"]}");
                        }
                        MessageBox.Show(result, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    **/
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}