namespace MSS
{
    partial class AddNewDrug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewDrug));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomTextboxDrugName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextboxcurrent_Quantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextboxShelf = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDropdownCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDropdownDrugType = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextboxIssuedQuantity = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextboxUnitBuyingPrice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDropdownItemCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomTextboxItemDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxReorderLevel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxUnitSellingPrice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomTextboxDrugID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add New Drug";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.bunifuCustomTextboxDrugName);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomTextboxcurrent_Quantity);
            this.panel2.Controls.Add(this.bunifuCustomLabel13);
            this.panel2.Controls.Add(this.bunifuCustomTextboxShelf);
            this.panel2.Controls.Add(this.bunifuCustomLabel12);
            this.panel2.Controls.Add(this.bunifuDropdownCategory);
            this.panel2.Controls.Add(this.bunifuCustomLabel11);
            this.panel2.Controls.Add(this.bunifuDropdownDrugType);
            this.panel2.Controls.Add(this.bunifuCustomLabel10);
            this.panel2.Controls.Add(this.bunifuCustomTextboxIssuedQuantity);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomTextboxUnitBuyingPrice);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.bunifuDropdownItemCategory);
            this.panel2.Controls.Add(this.bunifuCustomTextboxItemDescription);
            this.panel2.Controls.Add(this.bunifuCustomTextboxReorderLevel);
            this.panel2.Controls.Add(this.bunifuCustomTextboxUnitSellingPrice);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.bunifuCustomTextboxDrugID);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 615);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuCustomTextboxDrugName
            // 
            this.bunifuCustomTextboxDrugName.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxDrugName.Location = new System.Drawing.Point(48, 168);
            this.bunifuCustomTextboxDrugName.Name = "bunifuCustomTextboxDrugName";
            this.bunifuCustomTextboxDrugName.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxDrugName.TabIndex = 52;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(45, 140);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(61, 13);
            this.bunifuCustomLabel1.TabIndex = 51;
            this.bunifuCustomLabel1.Text = "Drug Name";
            // 
            // bunifuCustomTextboxcurrent_Quantity
            // 
            this.bunifuCustomTextboxcurrent_Quantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxcurrent_Quantity.Location = new System.Drawing.Point(340, 506);
            this.bunifuCustomTextboxcurrent_Quantity.Name = "bunifuCustomTextboxcurrent_Quantity";
            this.bunifuCustomTextboxcurrent_Quantity.Size = new System.Drawing.Size(85, 20);
            this.bunifuCustomTextboxcurrent_Quantity.TabIndex = 48;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(337, 479);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(83, 13);
            this.bunifuCustomLabel13.TabIndex = 47;
            this.bunifuCustomLabel13.Text = "Current Quantity";
            // 
            // bunifuCustomTextboxShelf
            // 
            this.bunifuCustomTextboxShelf.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxShelf.Location = new System.Drawing.Point(343, 434);
            this.bunifuCustomTextboxShelf.Name = "bunifuCustomTextboxShelf";
            this.bunifuCustomTextboxShelf.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxShelf.TabIndex = 46;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(340, 404);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(31, 13);
            this.bunifuCustomLabel12.TabIndex = 45;
            this.bunifuCustomLabel12.Text = "Shelf";
            // 
            // bunifuDropdownCategory
            // 
            this.bunifuDropdownCategory.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownCategory.BorderRadius = 6;
            this.bunifuDropdownCategory.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownCategory.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownCategory.Items = new string[] {
        "--Select--",
        "Category 1",
        "Category 2",
        "Category 3",
        "Category 4",
        "Category 5",
        "Category 6",
        "Category 7",
        "Category 8"};
            this.bunifuDropdownCategory.Location = new System.Drawing.Point(343, 342);
            this.bunifuDropdownCategory.Name = "bunifuDropdownCategory";
            this.bunifuDropdownCategory.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDropdownCategory.onHoverColor = System.Drawing.Color.Gainsboro;
            this.bunifuDropdownCategory.selectedIndex = 0;
            this.bunifuDropdownCategory.Size = new System.Drawing.Size(230, 35);
            this.bunifuDropdownCategory.TabIndex = 44;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(340, 321);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel11.TabIndex = 43;
            this.bunifuCustomLabel11.Text = "Category ";
            // 
            // bunifuDropdownDrugType
            // 
            this.bunifuDropdownDrugType.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownDrugType.BorderRadius = 6;
            this.bunifuDropdownDrugType.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownDrugType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownDrugType.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownDrugType.Items = new string[] {
        "--Select--",
        "Drug Type 1",
        "Drug Type 2",
        "Drug Type 3",
        "Drug Type 4",
        "Drug Type 5",
        "Drug Type 6",
        "Drug Type 7",
        "Drug Type 8"};
            this.bunifuDropdownDrugType.Location = new System.Drawing.Point(343, 252);
            this.bunifuDropdownDrugType.Name = "bunifuDropdownDrugType";
            this.bunifuDropdownDrugType.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDropdownDrugType.onHoverColor = System.Drawing.Color.Gainsboro;
            this.bunifuDropdownDrugType.selectedIndex = 0;
            this.bunifuDropdownDrugType.Size = new System.Drawing.Size(230, 35);
            this.bunifuDropdownDrugType.TabIndex = 42;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(340, 222);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(57, 13);
            this.bunifuCustomLabel10.TabIndex = 41;
            this.bunifuCustomLabel10.Text = "Drug Type";
            // 
            // bunifuCustomTextboxIssuedQuantity
            // 
            this.bunifuCustomTextboxIssuedQuantity.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxIssuedQuantity.Location = new System.Drawing.Point(343, 168);
            this.bunifuCustomTextboxIssuedQuantity.Name = "bunifuCustomTextboxIssuedQuantity";
            this.bunifuCustomTextboxIssuedQuantity.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxIssuedQuantity.TabIndex = 40;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(340, 140);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(80, 13);
            this.bunifuCustomLabel6.TabIndex = 39;
            this.bunifuCustomLabel6.Text = "Issued Quantity";
            // 
            // bunifuCustomTextboxUnitBuyingPrice
            // 
            this.bunifuCustomTextboxUnitBuyingPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxUnitBuyingPrice.Location = new System.Drawing.Point(343, 78);
            this.bunifuCustomTextboxUnitBuyingPrice.Name = "bunifuCustomTextboxUnitBuyingPrice";
            this.bunifuCustomTextboxUnitBuyingPrice.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxUnitBuyingPrice.TabIndex = 38;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(45, 404);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(84, 13);
            this.bunifuCustomLabel9.TabIndex = 37;
            this.bunifuCustomLabel9.Text = "Unit selling price";
            // 
            // bunifuDropdownItemCategory
            // 
            this.bunifuDropdownItemCategory.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownItemCategory.BorderRadius = 6;
            this.bunifuDropdownItemCategory.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownItemCategory.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownItemCategory.Items = new string[] {
        "--Select--",
        "Item Category 1",
        "Item Category 2",
        "Item Category 3",
        "Item Category 4",
        "Item Category 5",
        "Item Category 6",
        "Item Category 7",
        "Item Category 8"};
            this.bunifuDropdownItemCategory.Location = new System.Drawing.Point(48, 342);
            this.bunifuDropdownItemCategory.Name = "bunifuDropdownItemCategory";
            this.bunifuDropdownItemCategory.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDropdownItemCategory.onHoverColor = System.Drawing.Color.Gainsboro;
            this.bunifuDropdownItemCategory.selectedIndex = 0;
            this.bunifuDropdownItemCategory.Size = new System.Drawing.Size(230, 35);
            this.bunifuDropdownItemCategory.TabIndex = 36;
            // 
            // bunifuCustomTextboxItemDescription
            // 
            this.bunifuCustomTextboxItemDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxItemDescription.Location = new System.Drawing.Point(48, 241);
            this.bunifuCustomTextboxItemDescription.Multiline = true;
            this.bunifuCustomTextboxItemDescription.Name = "bunifuCustomTextboxItemDescription";
            this.bunifuCustomTextboxItemDescription.Size = new System.Drawing.Size(230, 46);
            this.bunifuCustomTextboxItemDescription.TabIndex = 35;
            // 
            // bunifuCustomTextboxReorderLevel
            // 
            this.bunifuCustomTextboxReorderLevel.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxReorderLevel.Location = new System.Drawing.Point(48, 506);
            this.bunifuCustomTextboxReorderLevel.Name = "bunifuCustomTextboxReorderLevel";
            this.bunifuCustomTextboxReorderLevel.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxReorderLevel.TabIndex = 34;
            // 
            // bunifuCustomTextboxUnitSellingPrice
            // 
            this.bunifuCustomTextboxUnitSellingPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxUnitSellingPrice.Location = new System.Drawing.Point(48, 434);
            this.bunifuCustomTextboxUnitSellingPrice.Name = "bunifuCustomTextboxUnitSellingPrice";
            this.bunifuCustomTextboxUnitSellingPrice.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxUnitSellingPrice.TabIndex = 33;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(45, 479);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(74, 13);
            this.bunifuCustomLabel8.TabIndex = 32;
            this.bunifuCustomLabel8.Text = "Reorder Level";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(56, 321);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(72, 13);
            this.bunifuCustomLabel7.TabIndex = 31;
            this.bunifuCustomLabel7.Text = "Item Category";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(242, 553);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(155, 31);
            this.bunifuThinButton21.TabIndex = 30;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // bunifuCustomTextboxDrugID
            // 
            this.bunifuCustomTextboxDrugID.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxDrugID.Location = new System.Drawing.Point(48, 78);
            this.bunifuCustomTextboxDrugID.Name = "bunifuCustomTextboxDrugID";
            this.bunifuCustomTextboxDrugID.ReadOnly = true;
            this.bunifuCustomTextboxDrugID.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxDrugID.TabIndex = 29;
            this.bunifuCustomTextboxDrugID.Text = "Automatic Generated";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(340, 40);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(88, 13);
            this.bunifuCustomLabel5.TabIndex = 27;
            this.bunifuCustomLabel5.Text = "Unit Buying Price";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(45, 222);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(83, 13);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Item Description";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 40);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(47, 13);
            this.bunifuCustomLabel2.TabIndex = 26;
            this.bunifuCustomLabel2.Text = "Drug  ID";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddNewDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewDrug";
            this.Text = "AddNewPrescription";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxcurrent_Quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxShelf;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownDrugType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxIssuedQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxUnitBuyingPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownItemCategory;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxItemDescription;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxReorderLevel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxUnitSellingPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxDrugID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxDrugName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}