using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class AddNewUsers : Form
    {
        public AddNewUsers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bunifuDropdownUserType_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int i = 0;
            if ((bunifuCustomTextboxUsername.Text == "") || (bunifuCustomTextboxFirstname.Text == "") || (bunifuCustomTextboxLastname.Text == "") || (bunifuDropdownGender.selectedIndex == 0) || (bunifuDropdownUserType.selectedIndex == 0) || (bunifuCustomTextboxPassword.Text == "") || (bunifuCustomTextboxContactNo.Text == "") || (bunifuCustomTextboxNIC.Text == ""))
            {
                MessageBox.Show("Fill All the fields and select gender and user type");
            }
            else
            {
                try
                {

                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "INSERT INTO Users(Username,FirstName,Lastname,Gender,USertype,Password,ContactNo,NIC) VALUES('" + bunifuCustomTextboxUsername.Text + "','" + bunifuCustomTextboxFirstname.Text + "','" + bunifuCustomTextboxLastname.Text + "','" + bunifuDropdownGender.selectedValue.ToString() + "','" + bunifuDropdownUserType.selectedValue.ToString() + "','" + bunifuCustomTextboxPassword.Text + "','" + bunifuCustomTextboxContactNo.Text + "','" + bunifuCustomTextboxNIC.Text + "')";
                    i = DBConnection.cmd.ExecuteNonQuery();

                    DBConnection.cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }


            if (i == 1)
            {

                MessageBox.Show("New User Add to the system is successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
