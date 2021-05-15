using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class UpdatePrescription : Form
    {
        public UpdatePrescription(String PID, String Description, String DoctorID, String PatientID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;

            bunifuCustomTextboxPID.Text = PID;
            bunifuCustomTextboxDescription.Text = Description;
            bunifuCustomTextboxDoctorID.Text = DoctorID;
            bunifuCustomTextboxPatientID.Text = PatientID;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            try
            {
                int i = 0;

                if (!(bunifuDropdownDeseastype.selectedIndex == 0) && !(bunifuCustomTextboxDescription.Text == ""))
                {
                   
                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "UPDATE Prescriptions SET Prescriptions_Date='" + bunifuDatepickerPDate.Value.ToShortDateString() + "',Deseas_type='" + bunifuDropdownDeseastype.selectedValue.ToString() + "',Description='" + bunifuCustomTextboxDescription.Text + "',Doctor_ID='" + bunifuCustomTextboxDoctorID.Text + "',Patient_Contact='" + bunifuCustomTextboxPatientID.Text + "' Where Prescriptions_ID=" + bunifuCustomTextboxPID.Text;
                    i = DBConnection.cmd.ExecuteNonQuery();



                }
                else
                {
                    MessageBox.Show("Fill all the fields");
                }
                if (i == 1)
                {

                    MessageBox.Show("Update Prescription successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
            finally
            {
                DBConnection.cn.Close();
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
