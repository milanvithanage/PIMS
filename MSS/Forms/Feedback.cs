using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS
{
    public partial class Feedback : Form
    {
        FeedbackDAO fdbackDAO = new FeedbackDAO();
        Validate validateClass = new Validate();

        public Feedback()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String feedback="feedback";
            if (radioButton1.Checked) { feedback = "Very Dissatisfied"; }
            if (radioButton2.Checked) { feedback = "Dissatisfied"; }
            if (radioButton3.Checked) { feedback = "Neutral"; }
            if (radioButton4.Checked) { feedback = "Stisfied"; }
            if (radioButton5.Checked) { feedback = "Very Stisfied"; }

            int i = 0;

            if (!(bunifuDropdown1.selectedIndex == 0) && !(textBox1.Text == "")&&!(TextBoxFeddback.Text=="") )
            {

                try
                {
                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "INSERT INTO Customer_Feedback(Prescriptions_ID,Rating,Service,Feedback) VALUES(" + textBox1.Text + ",'" + feedback + "','" + bunifuDropdown1.selectedValue.ToString() + "','" + TextBoxFeddback.Text + "' )";
                    i = DBConnection.cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
                finally
                {
                    DBConnection.cn.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill all the fields");
            }
            if (i == 1)
            {
                MessageBox.Show("Prescription Add successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxFeddback.Text = "";
            textBox1.Text = "";
        }
    }
}
