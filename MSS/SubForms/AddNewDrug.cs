using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class AddNewDrug : Form
    {
        public AddNewDrug()
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
            int i = 0;

            if (!(bunifuDropdownItemCategory.selectedIndex == 0) && !(bunifuCustomTextboxItemDescription.Text == "") && !(bunifuCustomTextboxUnitSellingPrice.Text == "") && !(bunifuCustomTextboxReorderLevel.Text == "") && !(bunifuCustomTextboxUnitBuyingPrice.Text == "") && !(bunifuDropdownDrugType.selectedIndex == 0) && !(bunifuDropdownItemCategory.selectedIndex == 0) && !(bunifuCustomTextboxShelf.Text == ""))
            {

                try
                {
                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "INSERT INTO Drug_Inventory(Item_Description,Item_Name,Item_Category,Unit_Selling_Price,Reorder_level,Unit_Buying_Price,Issued_Qunatity,Drug_Type,Category,Shelf,current_Quantity) VALUES('" + bunifuCustomTextboxItemDescription.Text + "','" + bunifuCustomTextboxDrugName.Text + "','" + bunifuDropdownItemCategory.selectedValue.ToString() + "'," + bunifuCustomTextboxUnitSellingPrice.Text + "," + bunifuCustomTextboxReorderLevel.Text + "," + bunifuCustomTextboxUnitBuyingPrice.Text + "," + bunifuCustomTextboxIssuedQuantity.Text + ",'" + bunifuDropdownDrugType.selectedValue.ToString() + "','" + bunifuDropdownCategory.selectedValue.ToString() + "','" + bunifuCustomTextboxShelf.Text + "'," + bunifuCustomTextboxcurrent_Quantity.Text + ")";
                    i = DBConnection.cmd.ExecuteNonQuery();


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
            else
            {
                MessageBox.Show("Fill all the fields");
            }
            if (i == 1)
            {

                MessageBox.Show("New Drug Add successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
