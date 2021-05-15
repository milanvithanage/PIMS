namespace MSS
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlDataGridViewHeader = new System.Windows.Forms.Panel();
            this.lblDataGridView = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.txtPrescriptionID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPresFee = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCusNo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDocName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtChannelDate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtChannelFee = new System.Windows.Forms.TextBox();
            this.panelHome.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlDataGridViewHeader.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.pnlDataGridView);
            this.panelHome.Controls.Add(this.panel6);
            this.panelHome.Controls.Add(this.panel5);
            this.panelHome.Controls.Add(this.panel2);
            this.panelHome.Controls.Add(this.panel4);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1252, 669);
            this.panelHome.TabIndex = 3;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Controls.Add(this.dataGridView1);
            this.pnlDataGridView.Controls.Add(this.pnlDataGridViewHeader);
            this.pnlDataGridView.Location = new System.Drawing.Point(33, 398);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(1053, 223);
            this.pnlDataGridView.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 192);
            this.dataGridView1.TabIndex = 54;
            // 
            // pnlDataGridViewHeader
            // 
            this.pnlDataGridViewHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlDataGridViewHeader.Controls.Add(this.lblDataGridView);
            this.pnlDataGridViewHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataGridViewHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDataGridViewHeader.Name = "pnlDataGridViewHeader";
            this.pnlDataGridViewHeader.Size = new System.Drawing.Size(1053, 31);
            this.pnlDataGridViewHeader.TabIndex = 53;
            // 
            // lblDataGridView
            // 
            this.lblDataGridView.AutoSize = true;
            this.lblDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataGridView.Location = new System.Drawing.Point(479, 11);
            this.lblDataGridView.Name = "lblDataGridView";
            this.lblDataGridView.Size = new System.Drawing.Size(62, 13);
            this.lblDataGridView.TabIndex = 0;
            this.lblDataGridView.Text = "Prescription";
            this.lblDataGridView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnPrint);
            this.panel6.Controls.Add(this.cmbBoxPaymentType);
            this.panel6.Controls.Add(this.txtPrescriptionID);
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.btnSubmit);
            this.panel6.Controls.Add(this.lblPrescriptionID);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtTotalAmount);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtPaymentDate);
            this.panel6.Location = new System.Drawing.Point(33, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(525, 348);
            this.panel6.TabIndex = 51;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(160, 190);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 39);
            this.btnPrint.TabIndex = 56;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbBoxPaymentType
            // 
            this.cmbBoxPaymentType.FormattingEnabled = true;
            this.cmbBoxPaymentType.Location = new System.Drawing.Point(160, 149);
            this.cmbBoxPaymentType.Name = "cmbBoxPaymentType";
            this.cmbBoxPaymentType.Size = new System.Drawing.Size(310, 21);
            this.cmbBoxPaymentType.TabIndex = 55;
            // 
            // txtPrescriptionID
            // 
            this.txtPrescriptionID.Location = new System.Drawing.Point(160, 37);
            this.txtPrescriptionID.Name = "txtPrescriptionID";
            this.txtPrescriptionID.Size = new System.Drawing.Size(310, 20);
            this.txtPrescriptionID.TabIndex = 54;
            this.txtPrescriptionID.TextChanged += new System.EventHandler(this.txtPrescriptionID_TextChanged);
            this.txtPrescriptionID.Leave += new System.EventHandler(this.txtPrescriptionID_Leave);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(272, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 39);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(381, 191);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 39);
            this.btnSubmit.TabIndex = 52;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Location = new System.Drawing.Point(46, 41);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(76, 13);
            this.lblPrescriptionID.TabIndex = 21;
            this.lblPrescriptionID.Text = "Prescription ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(160, 76);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(310, 20);
            this.txtTotalAmount.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Payment Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Payment Type";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Location = new System.Drawing.Point(160, 111);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.Size = new System.Drawing.Size(310, 20);
            this.txtPaymentDate.TabIndex = 34;
            this.txtPaymentDate.TextChanged += new System.EventHandler(this.txtPaymentDate_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtPresFee);
            this.panel5.Location = new System.Drawing.Point(586, 331);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 52);
            this.panel5.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Prescription Fee";
            // 
            // txtPresFee
            // 
            this.txtPresFee.Location = new System.Drawing.Point(154, 14);
            this.txtPresFee.Name = "txtPresFee";
            this.txtPresFee.Size = new System.Drawing.Size(310, 20);
            this.txtPresFee.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCusName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtCusNo);
            this.panel2.Location = new System.Drawing.Point(586, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 102);
            this.panel2.TabIndex = 49;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(154, 13);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(310, 20);
            this.txtCusName.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Customer Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Customer Contact No";
            // 
            // txtCusNo
            // 
            this.txtCusNo.Location = new System.Drawing.Point(154, 60);
            this.txtCusNo.Name = "txtCusNo";
            this.txtCusNo.Size = new System.Drawing.Size(310, 20);
            this.txtCusNo.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtDocName);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.txtChannelDate);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.txtChannelFee);
            this.panel4.Location = new System.Drawing.Point(586, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 150);
            this.panel4.TabIndex = 50;
            // 
            // txtDocName
            // 
            this.txtDocName.Location = new System.Drawing.Point(154, 18);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(310, 20);
            this.txtDocName.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Doctor Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Doctor channeling fee";
            // 
            // txtChannelDate
            // 
            this.txtChannelDate.Location = new System.Drawing.Point(154, 60);
            this.txtChannelDate.Name = "txtChannelDate";
            this.txtChannelDate.Size = new System.Drawing.Size(310, 20);
            this.txtChannelDate.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Channel Date";
            // 
            // txtChannelFee
            // 
            this.txtChannelFee.Location = new System.Drawing.Point(154, 100);
            this.txtChannelFee.Name = "txtChannelFee";
            this.txtChannelFee.Size = new System.Drawing.Size(310, 20);
            this.txtChannelFee.TabIndex = 38;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 741);
            this.Controls.Add(this.panelHome);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panelHome.ResumeLayout(false);
            this.pnlDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlDataGridViewHeader.ResumeLayout(false);
            this.pnlDataGridViewHeader.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlDataGridViewHeader;
        private System.Windows.Forms.Label lblDataGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbBoxPaymentType;
        private System.Windows.Forms.TextBox txtPrescriptionID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPresFee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCusNo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDocName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtChannelDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtChannelFee;
    }
}