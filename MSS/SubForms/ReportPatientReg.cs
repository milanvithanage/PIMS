using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class ReportPatientReg : Form
    {
        // This Form is used to get Customer Insights
        // Updated 17 Dec 2017
        // Version 01
        // Verions 02
        // Changes - Remove all unnecessary methods.
        // Changes - Add try catch block to Form load.

        ReportPatientRegDAO clsPatientReg = new ReportPatientRegDAO();

        public ReportPatientReg()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;
            this.ShowIcon = false;
        }

        private void ReportPatientReg_Load(object sender, EventArgs e)
        {
            try
            {
                clsPatientReg.chartPatientRegAMethod(chartPatientRegA);
                clsPatientReg.chartPatientRegBMethod(chartPatientRegB);
                clsPatientReg.chartPatientRegCMethod(chartPatientRegC);
                clsPatientReg.chartPatientRegDMethod(chartPatientRegD);
                clsPatientReg.chartPatientRegEMethod(chartPatientRegE);
                clsPatientReg.chartPatientRegFMethod(chartPatientRegF);

                clsPatientReg.chartPatientRegGMethod(chartPatientRegG, dtTmPckrFrom, dtTmPckrTo);

                clsPatientReg.chartPatientRegHMethod(chartPatientRegH);
                clsPatientReg.chartPatientRegIMethod(chartPatientRegI);
                clsPatientReg.chartPatientRegJMethod(chartPatientRegJ);
                clsPatientReg.chartPatientRegKMethod(chartPatientRegK);
                clsPatientReg.chartPatientRegLMethod(chartPatientRegL);
                clsPatientReg.chartPatientRegMMethod(chartPatientRegM);

                clsPatientReg.dataGridMostValuableCus(dataGridViewCusM);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            clsPatientReg.chartPatientRegGMethod(chartPatientRegG, dtTmPckrFrom, dtTmPckrTo);
        }

        private void dateTimePicker2_Leave(object sender, EventArgs e)
        {
            clsPatientReg.chartPatientRegGMethod(chartPatientRegG, dtTmPckrFrom, dtTmPckrTo);
        }

        private void dataGridViewDrugRemaining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartPatientRegA_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpBoxReportBy_Enter(object sender, EventArgs e)
        {

        }

        private void dtTmPckrTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
