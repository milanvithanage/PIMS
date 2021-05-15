using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace MSS
{
    class CommonDAO
    {
        // This class has the common used data access function
        // Updated 17 Dec 2017
        // Version 01

        private string provider = ConfigurationManager.AppSettings["provider"];
        private string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public DataSet GetDataFromDb(string queryCommand)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            DataSet ds = new DataSet();

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

                    command.Connection = connection; // Read data                    

                    using (DbDataAdapter adapter = factory.CreateDataAdapter())
                    {
                        command.CommandText = queryCommand;
                        adapter.SelectCommand = command;

                        adapter.Fill(ds, "tmpTable");
                        adapter.Dispose();
                        command.Dispose();
                        connection.Close();
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds;

            /***             
             * // Sample Usage 
             * CommonDAO cd = new CommonDAO();
             * DataSet ds = cd.GetDataFromDb(@"select * from Customer_Feedback");
             * cd.toDOMethod(ds);
             * 
             * // Sample Method 
             * public void toDOMethod(DataSet ds)
             * {
             *   foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
             *   {
             *      MessageBox.Show(Row["Service"].ToString());
             *   }
             * }             
            ***/
        }
    }
}
