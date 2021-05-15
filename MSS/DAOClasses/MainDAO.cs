using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;


namespace MSS
{
    class MainDAO
    {
        // Main Class
        // Updated 01 Jan 2018
        // Version 01

        private string provider = ConfigurationManager.AppSettings["provider"];
        private string connectionString = ConfigurationManager.AppSettings["connectionString"];

        CommonDAO commonDAO = new CommonDAO();

        public string GetUserType()
        {
            string query = "";
            string output = "";
            string currentUser = GlobalFun.CurrentUser;

            try
            {
                query = @"SELECT UserType 'UserType'
                        from users 
                        where Username = '" + currentUser + "'";

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        //MessageBox.Show(Row["TotalPrice"].ToString());
                        output = Row["UserType"].ToString();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }
    }
}
