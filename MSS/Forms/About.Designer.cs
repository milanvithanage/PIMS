namespace MSS
{
    partial class About
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(30, 30, 30, 5);
            this.lblHeader.Size = new System.Drawing.Size(231, 66);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "labelHeader";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBody.Location = new System.Drawing.Point(0, 66);
            this.lblBody.Name = "lblBody";
            this.lblBody.Padding = new System.Windows.Forms.Padding(30, 10, 30, 30);
            this.lblBody.Size = new System.Drawing.Size(167, 65);
            this.lblBody.TabIndex = 1;
            this.lblBody.Text = "labelBody";
            this.lblBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFooter.Location = new System.Drawing.Point(0, 289);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Padding = new System.Windows.Forms.Padding(30);
            this.lblFooter.Size = new System.Drawing.Size(119, 73);
            this.lblFooter.TabIndex = 2;
            this.lblFooter.Text = "labelFooter";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblHeader);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblFooter;
    }
}