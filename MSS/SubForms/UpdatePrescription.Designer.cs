namespace MSS
{
    partial class UpdatePrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePrescription));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomTextboxPatientID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxDoctorID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatepickerPDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDropdownDeseastype = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomTextboxDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextboxPID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.panel1.Size = new System.Drawing.Size(620, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Update Prescription";
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
            this.panel2.Controls.Add(this.bunifuCustomTextboxPatientID);
            this.panel2.Controls.Add(this.bunifuCustomTextboxDoctorID);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuDatepickerPDate);
            this.panel2.Controls.Add(this.bunifuDropdownDeseastype);
            this.panel2.Controls.Add(this.bunifuCustomTextboxDescription);
            this.panel2.Controls.Add(this.bunifuCustomTextboxPID);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 415);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuCustomTextboxPatientID
            // 
            this.bunifuCustomTextboxPatientID.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxPatientID.Location = new System.Drawing.Point(65, 315);
            this.bunifuCustomTextboxPatientID.Name = "bunifuCustomTextboxPatientID";
            this.bunifuCustomTextboxPatientID.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxPatientID.TabIndex = 32;
            // 
            // bunifuCustomTextboxDoctorID
            // 
            this.bunifuCustomTextboxDoctorID.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxDoctorID.Location = new System.Drawing.Point(65, 241);
            this.bunifuCustomTextboxDoctorID.Name = "bunifuCustomTextboxDoctorID";
            this.bunifuCustomTextboxDoctorID.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxDoctorID.TabIndex = 31;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(62, 290);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(54, 13);
            this.bunifuCustomLabel8.TabIndex = 30;
            this.bunifuCustomLabel8.Text = "Patient ID";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(62, 224);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel7.TabIndex = 29;
            this.bunifuCustomLabel7.Text = "Doctor ID";
            // 
            // bunifuDatepickerPDate
            // 
            this.bunifuDatepickerPDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDatepickerPDate.BorderRadius = 6;
            this.bunifuDatepickerPDate.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepickerPDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepickerPDate.FormatCustom = null;
            this.bunifuDatepickerPDate.Location = new System.Drawing.Point(356, 79);
            this.bunifuDatepickerPDate.Name = "bunifuDatepickerPDate";
            this.bunifuDatepickerPDate.Size = new System.Drawing.Size(199, 55);
            this.bunifuDatepickerPDate.TabIndex = 28;
            this.bunifuDatepickerPDate.Value = new System.DateTime(2017, 11, 23, 8, 40, 50, 976);
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
            this.bunifuDropdownDeseastype.Location = new System.Drawing.Point(65, 154);
            this.bunifuDropdownDeseastype.Name = "bunifuDropdownDeseastype";
            this.bunifuDropdownDeseastype.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDropdownDeseastype.onHoverColor = System.Drawing.Color.Gainsboro;
            this.bunifuDropdownDeseastype.selectedIndex = 0;
            this.bunifuDropdownDeseastype.Size = new System.Drawing.Size(230, 35);
            this.bunifuDropdownDeseastype.TabIndex = 27;
            // 
            // bunifuCustomTextboxDescription
            // 
            this.bunifuCustomTextboxDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomTextboxDescription.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxDescription.Location = new System.Drawing.Point(356, 208);
            this.bunifuCustomTextboxDescription.Multiline = true;
            this.bunifuCustomTextboxDescription.Name = "bunifuCustomTextboxDescription";
            this.bunifuCustomTextboxDescription.Size = new System.Drawing.Size(199, 79);
            this.bunifuCustomTextboxDescription.TabIndex = 26;
            // 
            // bunifuCustomTextboxPID
            // 
            this.bunifuCustomTextboxPID.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxPID.Location = new System.Drawing.Point(65, 79);
            this.bunifuCustomTextboxPID.Name = "bunifuCustomTextboxPID";
            this.bunifuCustomTextboxPID.ReadOnly = true;
            this.bunifuCustomTextboxPID.Size = new System.Drawing.Size(230, 20);
            this.bunifuCustomTextboxPID.TabIndex = 25;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(353, 176);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(60, 13);
            this.bunifuCustomLabel6.TabIndex = 21;
            this.bunifuCustomLabel6.Text = "Description";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(353, 53);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(93, 13);
            this.bunifuCustomLabel5.TabIndex = 22;
            this.bunifuCustomLabel5.Text = "Prescriptions Date";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(62, 121);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "Deseas type";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(62, 53);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 13);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "Prescriptions ID";
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(226, 370);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(155, 31);
            this.bunifuThinButton21.TabIndex = 20;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // UpdatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePrescription";
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
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxPatientID;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxDoctorID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepickerPDate;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdownDeseastype;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxDescription;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxPID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}