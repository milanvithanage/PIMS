using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            DrugInventoryReports DIR = new DrugInventoryReports();
            //DIR.TopMost = true;
            DIR.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ProfitAccodingToReport PAR = new ProfitAccodingToReport();
            PAR.TopMost = true;
            PAR.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ChannelingAndSpecialzationReport CSR = new ChannelingAndSpecialzationReport();
            CSR.TopMost = true;
            CSR.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DoctoerAppoinmentReport DAR = new DoctoerAppoinmentReport();
            DAR.TopMost = true;
            DAR.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            CustomerFeedbackReport CFR = new CustomerFeedbackReport();
            CFR.TopMost = true;
            CFR.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            ReportPatientReg RprtCusInsights = new ReportPatientReg();
            RprtCusInsights.TopMost = false;
            RprtCusInsights.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
