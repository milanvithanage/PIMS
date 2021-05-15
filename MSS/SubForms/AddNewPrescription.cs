using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class AddNewPrescription : Form
    {
        public AddNewPrescription()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (!(bunifuDropdownDeseastype.selectedIndex == 0) && !(bunifuCustomTextboxDescription.Text == ""))
            {

                DBConnection.cn.Open();
                DBConnection.cmd.Connection = DBConnection.cn;
                DBConnection.cmd.CommandText = "INSERT INTO Prescriptions(Prescriptions_Date,Deseas_type,Description,Doctor_ID,Patient_Contact) VALUES('" + bunifuDatepicker.Value.ToShortDateString() + "','" + bunifuDropdownDeseastype.selectedValue.ToString() + "','" + bunifuCustomTextboxDescription.Text + "'," + bunifuCustomTextboxDocterID.Text + ",'" + bunifuCustomTextboxPatientContact.Text + "')";
                i = DBConnection.cmd.ExecuteNonQuery();

                DBConnection.cn.Close();

            }
            else
            {
                MessageBox.Show("Fill all the fields");
            }
            if (i == 1)
            {

                MessageBox.Show("New Prescription Add successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
