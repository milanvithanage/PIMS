namespace MSS
{
    partial class Medicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicines));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHome = new System.Windows.Forms.Panel();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabelNoOfRecords = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.itemItIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBuyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedQunatityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugInventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pIMSDbDataSetDrugs = new MSS.PIMSDbDataSetDrugs();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuDropdownDrugCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdownDrugType = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuMetroTextboxSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDropdownSearch = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drugInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIMSDbDataSet = new MSS.PIMSDbDataSet();
            this.drug_InventoryTableAdapter = new MSS.PIMSDbDataSetTableAdapters.Drug_InventoryTableAdapter();
            this.drug_InventoryTableAdapter1 = new MSS.PIMSDbDataSetDrugsTableAdapters.Drug_InventoryTableAdapter();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugInventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIMSDbDataSetDrugs)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIMSDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.bunifuThinButton24);
            this.panelHome.Controls.Add(this.bunifuCustomLabelNoOfRecords);
            this.panelHome.Controls.Add(this.bunifuCustomDataGrid);
            this.panelHome.Controls.Add(this.panel8);
            this.panelHome.Controls.Add(this.panel3);
            this.panelHome.Controls.Add(this.panel2);
            this.panelHome.Location = new System.Drawing.Point(12, 12);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1118, 669);
            this.panelHome.TabIndex = 3;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.DarkViolet;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.Magenta;
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Refresh";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Purple;
            this.bunifuThinButton24.Location = new System.Drawing.Point(58, 590);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(99, 30);
            this.bunifuThinButton24.TabIndex = 5;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuCustomLabelNoOfRecords
            // 
            this.bunifuCustomLabelNoOfRecords.AutoSize = true;
            this.bunifuCustomLabelNoOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelNoOfRecords.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabelNoOfRecords.Location = new System.Drawing.Point(55, 569);
            this.bunifuCustomLabelNoOfRecords.Name = "bunifuCustomLabelNoOfRecords";
            this.bunifuCustomLabelNoOfRecords.Size = new System.Drawing.Size(112, 16);
            this.bunifuCustomLabelNoOfRecords.TabIndex = 4;
            this.bunifuCustomLabelNoOfRecords.Text = "No of Records ";
            // 
            // bunifuCustomDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemItIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemCategoryDataGridViewTextBoxColumn,
            this.unitSellingPriceDataGridViewTextBoxColumn,
            this.reorderlevelDataGridViewTextBoxColumn,
            this.unitBuyingPriceDataGridViewTextBoxColumn,
            this.issuedQunatityDataGridViewTextBoxColumn,
            this.drugTypeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.currentQuantityDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid.DataSource = this.drugInventoryBindingSource1;
            this.bunifuCustomDataGrid.DoubleBuffered = true;
            this.bunifuCustomDataGrid.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.SlateBlue;
            this.bunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.PowderBlue;
            this.bunifuCustomDataGrid.Location = new System.Drawing.Point(23, 180);
            this.bunifuCustomDataGrid.Name = "bunifuCustomDataGrid";
            this.bunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid.Size = new System.Drawing.Size(1082, 363);
            this.bunifuCustomDataGrid.TabIndex = 3;
            this.bunifuCustomDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid_CellContentClick);
            this.bunifuCustomDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid_CellContentClick);
            // 
            // itemItIDDataGridViewTextBoxColumn
            // 
            this.itemItIDDataGridViewTextBoxColumn.DataPropertyName = "ItemIt_ID";
            this.itemItIDDataGridViewTextBoxColumn.HeaderText = "ItemIt_ID";
            this.itemItIDDataGridViewTextBoxColumn.Name = "itemItIDDataGridViewTextBoxColumn";
            this.itemItIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Item_Description";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item_Description";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            // 
            // itemCategoryDataGridViewTextBoxColumn
            // 
            this.itemCategoryDataGridViewTextBoxColumn.DataPropertyName = "Item_Category";
            this.itemCategoryDataGridViewTextBoxColumn.HeaderText = "Item_Category";
            this.itemCategoryDataGridViewTextBoxColumn.Name = "itemCategoryDataGridViewTextBoxColumn";
            // 
            // unitSellingPriceDataGridViewTextBoxColumn
            // 
            this.unitSellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Selling_Price";
            this.unitSellingPriceDataGridViewTextBoxColumn.HeaderText = "Unit_Selling_Price";
            this.unitSellingPriceDataGridViewTextBoxColumn.Name = "unitSellingPriceDataGridViewTextBoxColumn";
            // 
            // reorderlevelDataGridViewTextBoxColumn
            // 
            this.reorderlevelDataGridViewTextBoxColumn.DataPropertyName = "Reorder_level";
            this.reorderlevelDataGridViewTextBoxColumn.HeaderText = "Reorder_level";
            this.reorderlevelDataGridViewTextBoxColumn.Name = "reorderlevelDataGridViewTextBoxColumn";
            // 
            // unitBuyingPriceDataGridViewTextBoxColumn
            // 
            this.unitBuyingPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Buying_Price";
            this.unitBuyingPriceDataGridViewTextBoxColumn.HeaderText = "Unit_Buying_Price";
            this.unitBuyingPriceDataGridViewTextBoxColumn.Name = "unitBuyingPriceDataGridViewTextBoxColumn";
            // 
            // issuedQunatityDataGridViewTextBoxColumn
            // 
            this.issuedQunatityDataGridViewTextBoxColumn.DataPropertyName = "Issued_Qunatity";
            this.issuedQunatityDataGridViewTextBoxColumn.HeaderText = "Issued_Qunatity";
            this.issuedQunatityDataGridViewTextBoxColumn.Name = "issuedQunatityDataGridViewTextBoxColumn";
            // 
            // drugTypeDataGridViewTextBoxColumn
            // 
            this.drugTypeDataGridViewTextBoxColumn.DataPropertyName = "Drug_Type";
            this.drugTypeDataGridViewTextBoxColumn.HeaderText = "Drug_Type";
            this.drugTypeDataGridViewTextBoxColumn.Name = "drugTypeDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            // 
            // currentQuantityDataGridViewTextBoxColumn
            // 
            this.currentQuantityDataGridViewTextBoxColumn.DataPropertyName = "current_Quantity";
            this.currentQuantityDataGridViewTextBoxColumn.HeaderText = "current_Quantity";
            this.currentQuantityDataGridViewTextBoxColumn.Name = "currentQuantityDataGridViewTextBoxColumn";
            // 
            // drugInventoryBindingSource1
            // 
            this.drugInventoryBindingSource1.DataMember = "Drug_Inventory";
            this.drugInventoryBindingSource1.DataSource = this.pIMSDbDataSetDrugs;
            // 
            // pIMSDbDataSetDrugs
            // 
            this.pIMSDbDataSetDrugs.DataSetName = "PIMSDbDataSetDrugs";
            this.pIMSDbDataSetDrugs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1118, 100);
            this.panel8.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuDropdownDrugCategory);
            this.panel3.Controls.Add(this.bunifuDropdownDrugType);
            this.panel3.Controls.Add(this.bunifuThinButton23);
            this.panel3.Controls.Add(this.bunifuThinButton22);
            this.panel3.Controls.Add(this.bunifuMetroTextboxSearch);
            this.panel3.Controls.Add(this.bunifuThinButton21);
            this.panel3.Controls.Add(this.bunifuDropdownSearch);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.bunifuFlatButton14);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 43);
            this.panel3.TabIndex = 1;
            // 
            // bunifuDropdownDrugCategory
            // 
            this.bunifuDropdownDrugCategory.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownDrugCategory.BorderRadius = 6;
            this.bunifuDropdownDrugCategory.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownDrugCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownDrugCategory.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdownDrugCategory.Items = new string[] {
        "--Select--",
        "Item Category 1",
        "Item Category 2",
        "Item Category 3",
        "Item Category 4",
        "Item Category 5",
        "Item Category 6",
        "Item Category 7",
        "Item Category 8"};
            this.bunifuDropdownDrugCategory.Location = new System.Drawing.Point(836, 0);
            this.bunifuDropdownDrugCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdownDrugCategory.Name = "bunifuDropdownDrugCategory";
            this.bunifuDropdownDrugCategory.NomalColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuDropdownDrugCategory.onHoverColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuDropdownDrugCategory.selectedIndex = -1;
            this.bunifuDropdownDrugCategory.Size = new System.Drawing.Size(199, 43);
            this.bunifuDropdownDrugCategory.TabIndex = 12;
            // 
            // bunifuDropdownDrugType
            // 
            this.bunifuDropdownDrugType.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownDrugType.BorderRadius = 6;
            this.bunifuDropdownDrugType.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownDrugType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownDrugType.ForeColor = System.Drawing.Color.White;
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
            this.bunifuDropdownDrugType.Location = new System.Drawing.Point(836, 0);
            this.bunifuDropdownDrugType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdownDrugType.Name = "bunifuDropdownDrugType";
            this.bunifuDropdownDrugType.NomalColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuDropdownDrugType.onHoverColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuDropdownDrugType.selectedIndex = 0;
            this.bunifuDropdownDrugType.Size = new System.Drawing.Size(199, 43);
            this.bunifuDropdownDrugType.TabIndex = 11;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Delete";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(388, 0);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(181, 43);
            this.bunifuThinButton23.TabIndex = 9;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.DarkBlue;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Update";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(204, 0);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(184, 43);
            this.bunifuThinButton22.TabIndex = 8;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuMetroTextboxSearch
            // 
            this.bunifuMetroTextboxSearch.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextboxSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextboxSearch.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextboxSearch.BorderThickness = 2;
            this.bunifuMetroTextboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuMetroTextboxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextboxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextboxSearch.isPassword = false;
            this.bunifuMetroTextboxSearch.Location = new System.Drawing.Point(836, 0);
            this.bunifuMetroTextboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextboxSearch.Name = "bunifuMetroTextboxSearch";
            this.bunifuMetroTextboxSearch.Size = new System.Drawing.Size(198, 43);
            this.bunifuMetroTextboxSearch.TabIndex = 7;
            this.bunifuMetroTextboxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add New";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.Location = new System.Drawing.Point(23, 0);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 43);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuDropdownSearch
            // 
            this.bunifuDropdownSearch.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownSearch.BorderRadius = 6;
            this.bunifuDropdownSearch.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownSearch.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdownSearch.Items = new string[] {
        "--Select--",
        "Drug ID",
        "Item_Category",
        "Drug_Type",
        "Item_Name"};
            this.bunifuDropdownSearch.Location = new System.Drawing.Point(648, 0);
            this.bunifuDropdownSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdownSearch.Name = "bunifuDropdownSearch";
            this.bunifuDropdownSearch.NomalColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuDropdownSearch.onHoverColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuDropdownSearch.selectedIndex = 0;
            this.bunifuDropdownSearch.Size = new System.Drawing.Size(180, 43);
            this.bunifuDropdownSearch.TabIndex = 3;
            this.bunifuDropdownSearch.onItemSelected += new System.EventHandler(this.bunifuDropdownSearch_onItemSelected);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(877, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(16, 43);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1034, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 43);
            this.panel6.TabIndex = 3;
            // 
            // bunifuFlatButton14
            // 
            this.bunifuFlatButton14.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton14.BorderRadius = 0;
            this.bunifuFlatButton14.ButtonText = "";
            this.bunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton14.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton14.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton14.Iconimage")));
            this.bunifuFlatButton14.Iconimage_right = null;
            this.bunifuFlatButton14.Iconimage_right_Selected = null;
            this.bunifuFlatButton14.Iconimage_Selected = null;
            this.bunifuFlatButton14.IconMarginLeft = 0;
            this.bunifuFlatButton14.IconMarginRight = 0;
            this.bunifuFlatButton14.IconRightVisible = true;
            this.bunifuFlatButton14.IconRightZoom = 0D;
            this.bunifuFlatButton14.IconVisible = true;
            this.bunifuFlatButton14.IconZoom = 90D;
            this.bunifuFlatButton14.IsTab = false;
            this.bunifuFlatButton14.Location = new System.Drawing.Point(1050, 0);
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.Size = new System.Drawing.Size(45, 43);
            this.bunifuFlatButton14.TabIndex = 3;
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton14.Click += new System.EventHandler(this.bunifuFlatButton14_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1095, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 43);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 43);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 39);
            this.panel2.TabIndex = 0;
            // 
            // drugInventoryBindingSource
            // 
            this.drugInventoryBindingSource.DataMember = "Drug_Inventory";
            this.drugInventoryBindingSource.DataSource = this.pIMSDbDataSet;
            // 
            // pIMSDbDataSet
            // 
            this.pIMSDbDataSet.DataSetName = "PIMSDbDataSet";
            this.pIMSDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drug_InventoryTableAdapter
            // 
            this.drug_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // drug_InventoryTableAdapter1
            // 
            this.drug_InventoryTableAdapter1.ClearBeforeFill = true;
            // 
            // Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelHome);
            this.Name = "Medicines";
            this.Text = "Medicines";
            this.Load += new System.EventHandler(this.Medicines_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugInventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIMSDbDataSetDrugs)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drugInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIMSDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabelNoOfRecords;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownDrugCategory;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownDrugType;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownSearch;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid;
        private PIMSDbDataSet pIMSDbDataSet;
        private System.Windows.Forms.BindingSource drugInventoryBindingSource;
        private PIMSDbDataSetTableAdapters.Drug_InventoryTableAdapter drug_InventoryTableAdapter;
        private PIMSDbDataSetDrugs pIMSDbDataSetDrugs;
        private System.Windows.Forms.BindingSource drugInventoryBindingSource1;
        private PIMSDbDataSetDrugsTableAdapters.Drug_InventoryTableAdapter drug_InventoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemItIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBuyingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedQunatityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQuantityDataGridViewTextBoxColumn;
    }
}