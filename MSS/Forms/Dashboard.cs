using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class frmDashboard : Form
    {
        DashboardDAO DashboardDAO = new DashboardDAO();

        public frmDashboard()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblCustomers.Text = DashboardDAO.NoOfWhat(@"Select count(*) as 'Count' from Registered_Patient");
            lblDoctors.Text = DashboardDAO.NoOfWhat(@"Select count(*) as 'Count' from Doctor");
            lblDrugs.Text = DashboardDAO.NoOfWhat(@"Select count(*) as 'Count' from Drug_Inventory");
            lblAppointments.Text = DashboardDAO.NoOfWhat(@"Select count(*) as 'Count' from Patient_Channel");
            lblPayments.Text = DashboardDAO.NoOfWhat(@"Select count(*) as 'Count' from Payment");
            lblFeedbacks.Text = DashboardDAO.NoOfWhat(@"Select count(*) as 'Count' from Customer_Feedback");

            lblAppMore.Text = DashboardDAO.AppointmentsMoreDetails();
            lblDrugsMore.Text = DashboardDAO.DrugsMoreDetails();
            lblFeedbackMore.Text = DashboardDAO.FeedbacksMoreDetails();
            lblCustomersMore.Text = DashboardDAO.CustomersMoreDetails();


            DashboardDAO.ChartDashA(chrtABestCus);
            DashboardDAO.ChartDashB(chrtBBestDoc);
            DashboardDAO.ChartDashC(chrtCBestProfitDrug);
            DashboardDAO.ChartDashD(chrtDReqSpe);

            DashboardDAO.dataGridDrugRemaining(dataGridViewDrugRemaining);
            DashboardDAO.dataGridFutureAppointment(dataGridViewFutureAppointment);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDrugRemaining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridViewDrugRemaining_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
