using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace MSS
{
    class ManageDumpData
    {
        // This class is used to insert dump data and delete data
        // Updated 17 Dec 2017
        // Version 01
        // Version 02
        // Changes - Add Try catch Function for every method.


        private string provider = ConfigurationManager.AppSettings["provider"];
        private string connectionString = ConfigurationManager.AppSettings["connectionString"];

        CommonDAO commonDAO = new CommonDAO();

        public void Issue_DrugDumpData()
        {
            try
            {
                string query = @"SELECT * FROM Issue_Receipt";
                int rowUpdated = 0;

                using (DataSet ds = commonDAO.GetDataFromDb(query))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        int x = 0;

                        Int32.TryParse(Row["NoOfItems"].ToString(), out x);

                        for (int a = 1; a < x; a++)
                        {
                            rowUpdated++;

                            query = "";

                            query = @"DECLARE @Random INT = ABS(Checksum(NewID()) % 20);";

                            query += @"insert into Issue_Drug 
                                    (Reference_No, ItemIt_ID, Quantity, Price) 
                                    select top 1 ";
                            query += Row["Reference_No"].ToString();

                            query += @", t2.ItemIt_ID,(@Random), t2.Unit_Selling_Price * @Random
                                    from Issue_Receipt t1, Drug_Inventory t2 
                                    ORDER BY NEWID()";

                            using (commonDAO.GetDataFromDb(query))
                            {
                                //lblRowUpdated.Text = "Please wait \nRows updated: " + rowUpdated.ToString();
                            }
                        }
                    }
                }

                query = @"delete from Issue_Drug where Quantity = 0";
                using (commonDAO.GetDataFromDb(query))
                {
                    MessageBox.Show("Task Completed \n" + rowUpdated.ToString() + " rows updated.");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void DeleteIssue_DrugData()
        {
            try
            {
                string query = @"delete from Issue_Drug";

                using (commonDAO.GetDataFromDb(query))
                {
                    MessageBox.Show("Task Completed");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrescriptionDumpData()
        {
            try
            {
                string query = @"Insert into Prescriptions 
                            (Prescriptions_Date, Deseas_type, Description, Doctor_ID, Patient_Contact) 
                            select 
                            (DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 360), '2017-01-01')), SUBSTRING(CONVERT(varchar(40), NEWID()),0,9), SUBSTRING(CONVERT(varchar(40), NEWID()),0,27), t1.Doctor_ID, t1.Patient_Contact 
                            from Patient_Channel t1
							inner join Registered_Patient on Registered_Patient.Patient_Contact = t1.Patient_Contact
                            ORDER BY NEWID()";

                using (commonDAO.GetDataFromDb(query))
                {
                    MessageBox.Show("Task Completed");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void DeletePrescriptionsData()
        {
            try
            {
                string query = @"delete from Prescriptions";

                using (commonDAO.GetDataFromDb(query))
                {
                    MessageBox.Show("Task Completed");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void IssueReceiptDumpData()
        {
            try
            {
                string query = @"IF NOT EXISTS (SELECT * FROM Issue_Receipt INNER JOIN Prescriptions t1 ON t1.Prescriptions_ID = Issue_Receipt.Prescriptions_ID)
                            INSERT INTO Issue_Receipt 
                            (NoOfItems, Date, Time, Prescriptions_ID) 
                            SELECT (ABS(Checksum(NewID()) % 10)), t1.Prescriptions_Date, DATEADD(s, ABS(CHECKSUM(NewId()) % 43201), CAST('08:00:00' AS Time)), t1.Prescriptions_ID 
                            FROM Prescriptions t1 ";

                using (commonDAO.GetDataFromDb(query))
                {
                    query = @"delete from Issue_Receipt where NoOfItems = 0";

                    commonDAO.GetDataFromDb(query);
                    MessageBox.Show("Task Completed");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void DeleteIssueReceiptData()
        {
            try
            {
                string query = @"delete from Issue_Receipt";

                using (commonDAO.GetDataFromDb(query))
                {
                    MessageBox.Show("Task Completed");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public void PatientChannelDumpData()
        {
            try
            {
                string query = @"Insert into Patient_Channel 
                            (Channel_Date, Channel_Time, Channel_Fee, Channel_Number, Room_Number, Doctor_ID, Patient_Contact) 
                            select top 20 
                            (DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 360), '2017-01-01')),  DATEADD(s, ABS(CHECKSUM(NewId()) % 43201), CAST('08:00:00' AS Time)) , (ABS(Checksum(NewID()) % 2000) + 100),  (ABS(Checksum(NewID()) % 50) + 1), (ABS(Checksum(NewID()) % 20)), t2.Doctor_ID, t1.Patient_Contact 
                            from Registered_Patient t1, Doctor t2 
                            ORDER BY NEWID()";

                using (commonDAO.GetDataFromDb(query))
                {
                    MessageBox.Show("Task Completed");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeletePatientChannelData()
        {
            try
            {
                string query = @"delete from Patient_Channel";

                using (commonDAO.GetDataFromDb(query))
                {
                    MessageBox.Show("Task Completed");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
