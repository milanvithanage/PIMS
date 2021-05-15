using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS.CrystalReports
{
    public partial class DrugIssueReportForm : Form
    {
        String ReferenceNo, Date, Time, Amount, NoOfItems;
        public DrugIssueReportForm(String referenceNo, String date, String time, String amount, String noofitem)
        {
            this.ReferenceNo = referenceNo;
            this.Date = date;
            this.Time = time;
            this.Amount = amount;
            this.NoOfItems = noofitem;
            this.TopMost = true;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DrugIssueReport Obj = new DrugIssueReport();
            Obj.SetParameterValue("ReferenceNo", ReferenceNo);
            Obj.SetParameterValue("Date", Date);
            Obj.SetParameterValue("Time", Time);
            Obj.SetParameterValue("Total", Amount);
            Obj.SetParameterValue("NoOfItem", NoOfItems);
            crystalReportViewer1.ReportSource = Obj;
            crystalReportViewer1.Refresh();
        }
    }
}
