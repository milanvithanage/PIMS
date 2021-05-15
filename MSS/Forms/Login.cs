using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSS
{
    public partial class Login : Form
    {
        String UserType;
        public Login()
        {
            InitializeComponent();
            this.ShowIcon = false;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            DBTest dBTest = new DBTest();
            dBTest.DbTesting();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.cn.Open();
                DBConnection.cmd = new SqlCommand("select * from Users where Username = '" + bunifuCustomTextboxUsername.Text + "' and Password = '" + bunifuCustomTextboxPassword.Text + "'", DBConnection.cn);

                DBConnection.dr = DBConnection.cmd.ExecuteReader();
                DBConnection.dr.Read();
                if (DBConnection.dr.HasRows)
                {
                    UserType = DBConnection.dr.GetString(5);
                    //MessageBox.Show("Welcome to the PIMS ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalFun.CurrentUser = bunifuCustomTextboxUsername.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("incorrect user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            bunifuCustomTextboxUsername.Text = "";
            bunifuCustomTextboxPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
