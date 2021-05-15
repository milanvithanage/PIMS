using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MSS
{
    public partial class Payment : Form
    {
        // This Form is used to pay prescriptions
        // Updated 17 Dec 2017
        // Version 01

        PaymentDAO paymentDAO = new PaymentDAO();
        Validate validateClass = new Validate();

        public Payment()
        {
            InitializeComponent();
            this.ShowIcon = false;

            pnlDataGridView.Visible = false;
            //paymentDAO.AutoCompletePresID(txtPrescriptionID); // These line should be after the InitializeComponent

            txtCusName.ReadOnly = true;
            txtCusNo.ReadOnly = true;
            txtDocName.ReadOnly = true;
            txtChannelDate.ReadOnly = true;
            txtChannelFee.ReadOnly = true;
            txtPresFee.ReadOnly = true;

            txtPaymentDate.Text = DateTime.Today.ToString("MM/dd/yyyy");

            cmbBoxPaymentType.Items.Add("Cash");
            cmbBoxPaymentType.Items.Add("Credit & Debit cards");
            cmbBoxPaymentType.Items.Add("Online payments");
            cmbBoxPaymentType.SelectedItem = "Cash";

            btnPrint.Enabled = false;
        }

        private void PaymentInputClear()
        {
            txtCusName.Text = "";
            txtCusNo.Text = "";
            txtDocName.Text = "";
            txtChannelDate.Text = "";
            txtChannelFee.Text = "";
            txtPresFee.Text = "";
            txtPrescriptionID.Text = "";
            txtTotalAmount.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateClass.IsTextboxEmpty(txtPrescriptionID))
            {
                int rowsUpdated = paymentDAO.PaymentSubmit(txtPrescriptionID.Text, txtTotalAmount.Text, txtPaymentDate.Text, txtCusNo.Text, cmbBoxPaymentType.Text);

                if (rowsUpdated > 0)
                {
                    //PaymentInputClear();
                    btnPrint.Enabled = true;
                    pnlDataGridView.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please insert the all data", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrescriptionID_Leave(object sender, EventArgs e)
        {
            if (validateClass.IsTextboxEmpty(txtPrescriptionID))
            {
                txtPresFee.Text = paymentDAO.AutoCompletePresFee(txtPrescriptionID.Text);

                try
                {
                    txtCusName.Text = "";
                    txtCusNo.Text = "";
                    txtDocName.Text = "";
                    txtChannelDate.Text = "";
                    txtChannelFee.Text = "";

                    List<string> outputList = new List<string>();
                    outputList = paymentDAO.AutoCompleteAllDetails(txtPrescriptionID.Text);

                    // 0 - Patient_Name
                    // 1 - Patient_Contact
                    // 2 - Doctor_Name
                    // 3 - Channel_Date
                    // 4 - Channel_Fee

                    txtCusName.Text = outputList[0];
                    txtCusNo.Text = outputList[1];
                    txtDocName.Text = outputList[2];
                    txtChannelDate.Text = outputList[3];
                    txtChannelFee.Text = outputList[4];
                }
                catch (Exception)
                {
                }

                try
                {
                    double channelFee = 0;
                    double presFee = 0;

                    Double.TryParse(txtChannelFee.Text, out channelFee);
                    Double.TryParse(txtPresFee.Text, out presFee);

                    txtTotalAmount.Text = (presFee + channelFee).ToString();
                }
                catch (Exception)
                {
                }

                dataGridView1 = (paymentDAO.AutoCompletePresDesc(txtPrescriptionID.Text, dataGridView1));
                pnlDataGridView.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PaymentInputClear();
            pnlDataGridView.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (validateClass.IsTextboxEmpty(txtPrescriptionID))
            {
                PrintReceipt();
            }
            PaymentInputClear();
        }

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += PrintDocument_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Graphics graphics = e.Graphics;
                Font font = new Font("Courier New", 12);
                SolidBrush solidBrush = new SolidBrush(Color.Black);

                float fontHeight = font.GetHeight();

                int startX = 10;
                int startY = 10;
                int offset = 35;

                string printOutput = "";

                graphics.DrawString("Welcome to PIMS", new Font("Courier New", 18), solidBrush, startX, startY);

                //string txt = ("This is a test").PadRight(30);
                //offset = offset + (int)fontHeight + 5;

                printOutput += "-------------------------------" + "\n";
                printOutput += "Cutomer Name: " + txtCusName.Text + "\n";
                printOutput += "Cutomer Contact No: " + txtCusNo.Text + "\n";
                printOutput += "Date: " + txtPaymentDate.Text + "\n\n";
                printOutput += "Channeling Date: " + txtChannelDate.Text + "\n";
                printOutput += "Channeling Doctor: " + txtDocName.Text + "\n";
                printOutput += "Channeling Fee: " + txtChannelFee.Text + "\n\n";
                printOutput += "Prescription ID: " + txtPrescriptionID.Text + "\n";
                printOutput += "Total Prescription Fee: " + txtPresFee.Text + "\n\n\n";

                // Prescription List
                DataSet ds = new DataSet();

                using (ds = paymentDAO.PrescriptionList(txtPrescriptionID.Text))
                {
                    foreach (DataRow Row in ds.Tables["tmpTable"].Rows)
                    {
                        printOutput += Row["Item_Name"].ToString().Trim().PadRight(30);
                        //output += Row["Drug_Type"].ToString().PadRight(10);
                        printOutput += Row["Unit_Selling_Price"].ToString().Trim().PadRight(10);
                        printOutput += Row["Quantity"].ToString().Trim().PadRight(10);
                        printOutput += Row["Price"].ToString().Trim().PadRight(10);
                        printOutput += "\n";
                    }
                }
                // End of Prescription List

                graphics.DrawString(printOutput, font, solidBrush, startX, startY + offset);

                offset = offset + (font.Height * printOutput.Split('\n').Length);

                graphics.DrawString("Total Fee: LKR " + txtTotalAmount.Text, new Font("Courier New", 14), solidBrush, startX, startY + offset);
                offset += 25;

                graphics.DrawString("-------------------------------", font, solidBrush, startX, startY + offset);
                offset += 25;

                graphics.DrawString("Thank you, Come Again.", new Font("Courier New", 10), solidBrush, startX, startY + offset);
                offset += 20;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void txtPaymentDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrescriptionID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
