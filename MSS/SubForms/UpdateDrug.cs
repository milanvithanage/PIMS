using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class UpdateDrug : Form
    {
        public UpdateDrug(String ItemID, String ItemName, String ItemDescription, String UnitSellingPrice, String ReorderLevel, String unitbuyingPrice, String IssuedQuantity, String Shelf, String currentQuantity)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;

            bunifuCustomTextboxDrugID.Text = ItemID;
            bunifuCustomTextboxDrugName.Text = ItemName;
            bunifuCustomTextboxItemDescription.Text = ItemDescription;
            bunifuCustomTextboxUnitSellingPrice.Text = UnitSellingPrice;
            bunifuCustomTextboxReorderLevel.Text = ReorderLevel;
            bunifuCustomTextboxUnitBuyingPrice.Text = unitbuyingPrice;
            bunifuCustomTextboxIssuedQuantity.Text = IssuedQuantity;
            bunifuCustomTextboxShelf.Text = Shelf;
            bunifuCustomTextboxCurrentQuantity.Text = currentQuantity;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (!(bunifuDropdownItemCategory.selectedIndex == 0) && !(bunifuCustomTextboxItemDescription.Text == "") && !(bunifuCustomTextboxUnitSellingPrice.Text == "") && !(bunifuCustomTextboxReorderLevel.Text == "") && !(bunifuCustomTextboxUnitBuyingPrice.Text == "") && !(bunifuDropdownDrugType.selectedIndex == 0) && !(bunifuDropdownItemCategory.selectedIndex == 0) && !(bunifuCustomTextboxShelf.Text == ""))
            {

                try
                {
                    DBConnection.cn.Open();
                    DBConnection.cmd.Connection = DBConnection.cn;
                    DBConnection.cmd.CommandText = "Update Drug_Inventory SET Item_Description ='" + bunifuCustomTextboxItemDescription.Text + "',Item_Name='" + bunifuCustomTextboxDrugName.Text + "',Item_Category='" + bunifuDropdownItemCategory.selectedValue.ToString() + "',Unit_Selling_Price=" + bunifuCustomTextboxUnitSellingPrice.Text + ",Reorder_level=" + bunifuCustomTextboxReorderLevel.Text + ",Unit_Buying_Price=" + bunifuCustomTextboxUnitBuyingPrice.Text + ",Issued_Qunatity=" + bunifuCustomTextboxIssuedQuantity.Text + ",Drug_Type='" + bunifuDropdownDrugType.selectedValue.ToString() + "',Category='" + bunifuDropdownCategory.selectedValue.ToString() + "',Shelf='" + bunifuCustomTextboxShelf.Text + "',current_Quantity=" + bunifuCustomTextboxCurrentQuantity.Text + " where ItemIt_ID =" + bunifuCustomTextboxDrugID.Text;
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

                MessageBox.Show("Update Drug successful", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
