namespace MSS
{
    partial class AddNewPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPrescription));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomTextboxPatientContact = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxDocterID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDropdownDeseastype = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomTextboxDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            this.panel1.Size = new System.Drawing.Size(617, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add New Prescription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 9);
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
            this.panel2.Controls.Add(this.bunifuCustomTextboxPatientContact);
            this.panel2.Controls.Add(this.bunifuCustomTextboxDocterID);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.bunifuDatepicker);
            this.panel2.Controls.Add(this.bunifuDropdownDeseastype);
            this.panel2.Controls.Add(this.bunifuCustomTextboxDescription);
            this.panel2.Controls.Add(this.bunifuCustomTextbox1);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 388);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuCustomTextboxPatientContact
            // 
            this.bunifuCustomTextboxPatientContact.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxPatientContact.Location = new System.Drawing.Point(65, 291);
            this.bunifuCustomTextboxPatientContact.Name = "bunifuCustomTextboxPatientContact";
            this.bunifuCustomTextboxPatientContact.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxPatientContact.TabIndex = 24;
            // 
            // bunifuCustomTextboxDocterID
            // 
            this.bunifuCustomTextboxDocterID.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxDocterID.Location = new System.Drawing.Point(65, 222);
            this.bunifuCustomTextboxDocterID.Name = "bunifuCustomTextboxDocterID";
            this.bunifuCustomTextboxDocterID.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxDocterID.TabIndex = 23;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(62, 274);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(80, 13);
            this.bunifuCustomLabel8.TabIndex = 22;
            this.bunifuCustomLabel8.Text = "Patient Contact";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(62, 195);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel7.TabIndex = 21;
            this.bunifuCustomLabel7.Text = "Docter ID";
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(216, 330);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(155, 31);
            this.bunifuThinButton21.TabIndex = 20;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuDatepicker
            // 
            this.bunifuDatepicker.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDatepicker.BorderRadius = 6;
            this.bunifuDatepicker.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker.FormatCustom = null;
            this.bunifuDatepicker.Location = new System.Drawing.Point(356, 53);
            this.bunifuDatepicker.Name = "bunifuDatepicker";
            this.bunifuDatepicker.Size = new System.Drawing.Size(199, 55);
            this.bunifuDatepicker.TabIndex = 19;
            this.bunifuDatepicker.Value = new System.DateTime(2017, 11, 23, 8, 40, 50, 976);
            // 
            // bunifuDropdownDeseastype
            // 
            this.bunifuDropdownDeseastype.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownDeseastype.BorderRadius = 6;
            this.bunifuDropdownDeseastype.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdownDeseastype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdownDeseastype.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownDeseastype.Items = new string[] {
        "--Select--",
        "Heart, Lung and Other Organ Diseases",
        "Blood and Immune System Diseases",
        "Cancer",
        "Injury",
        "Brain and Nervous System Diseases",
        "Endocrine System Diseases",
        "Infectious and Parasitic Diseases",
        "Pregnancy and Childbirth-Related Diseases",
        "Inherited Diseases",
        "Environmentally-Acquired Diseases"};
            this.bunifuDropdownDeseastype.Location = new System.Drawing.Point(65, 128);
            this.bunifuDropdownDeseastype.Name = "bunifuDropdownDeseastype";
            this.bunifuDropdownDeseastype.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDropdownDeseastype.onHoverColor = System.Drawing.Color.Gainsboro;
            this.bunifuDropdownDeseastype.selectedIndex = 0;
            this.bunifuDropdownDeseastype.Size = new System.Drawing.Size(230, 35);
            this.bunifuDropdownDeseastype.TabIndex = 18;
            // 
            // bunifuCustomTextboxDescription
            // 
            this.bunifuCustomTextboxDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomTextboxDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxDescription.Location = new System.Drawing.Point(356, 182);
            this.bunifuCustomTextboxDescription.Multiline = true;
            this.bunifuCustomTextboxDescription.Name = "bunifuCustomTextboxDescription";
            this.bunifuCustomTextboxDescription.Size = new System.Drawing.Size(199, 79);
            this.bunifuCustomTextboxDescription.TabIndex = 17;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(65, 53);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.ReadOnly = true;
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextbox1.TabIndex = 16;
            this.bunifuCustomTextbox1.Text = "Automatic Generated";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(353, 150);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(60, 13);
            this.bunifuCustomLabel6.TabIndex = 12;
            this.bunifuCustomLabel6.Text = "Description";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(353, 27);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(93, 13);
            this.bunifuCustomLabel5.TabIndex = 13;
            this.bunifuCustomLabel5.Text = "Prescriptions Date";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(62, 95);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel4.TabIndex = 14;
            this.bunifuCustomLabel4.Text = "Deseas type";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(62, 27);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 13);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Prescriptions ID";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddNewPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewPrescription";
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
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxPatientContact;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxDocterID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownDeseastype;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxDescription;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
    }
}