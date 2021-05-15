using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class UpdateUsers : Form
    {
        public UpdateUsers(String passUID, String passUsername, String passFirstName, String passLastName, String passContactNo, String passNIC)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;

            bunifuCustomTextboxUID.Text = passUID;
            bunifuCustomTextboxUsername.Text = passUsername;
            bunifuCustomTextboxFirstname.Text = passFirstName;
            bunifuCustomTextboxLastname.Text = passLastName;
            bunifuCustomTextboxContactNo.Text = passContactNo;
            bunifuCustomTextboxNIC.Text = passNIC;
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

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
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
                    MessageBox.Show("Update Users SET Username ='" + bunifuCustomTextboxUsername.Text + "',FirstName='" + bunifuCustomTextboxFirstname.Text + "',Lastname='" + bunifuCustomTextboxLastname.Text + "',Gender='" + bunifuDropdownGender.selectedValue.ToString() + "',USertype='" + bunifuDropdownUserType.selectedValue.ToString() + "',Password='" + bunifuCustomTextboxPassword.Text + "',ContactNo='" + bunifuCustomTextboxContactNo.Text + "',NIC='" + bunifuCustomTextboxNIC.Text + "'Where ID=" + bunifuCustomTextboxUID.Text);
                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "Update Users SET Username ='" + bunifuCustomTextboxUsername.Text + "',FirstName='" + bunifuCustomTextboxFirstname.Text + "',Lastname='" + bunifuCustomTextboxLastname.Text + "',Gender='" + bunifuDropdownGender.selectedValue.ToString() + "',USertype='" + bunifuDropdownUserType.selectedValue.ToString() + "',Password='" + bunifuCustomTextboxPassword.Text + "',ContactNo='" + bunifuCustomTextboxContactNo.Text + "',NIC='" + bunifuCustomTextboxNIC.Text + "'Where ID=" + bunifuCustomTextboxUID.Text;


                    i = DBConnection.cmd.ExecuteNonQuery();
                    DBConnection.cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                };

            }


            if (i == 1)
            {

                MessageBox.Show(" User update is successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
