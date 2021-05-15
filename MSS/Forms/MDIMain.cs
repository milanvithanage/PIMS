using System;
using System.Windows.Forms;

namespace MSS
{
    public partial class MDIMainForm : Form
    {
        // This is the Main Form
        // Updated 17 Dec 2017
        // Version 01

        MainDAO mainDAO = new MainDAO();        

        private int childFormNumber = 0;
        
        public MDIMainForm()
        {
            InitializeComponent();
            this.ShowIcon = false;
            this.TopMost = false;

            DBTest dBTest = new DBTest();
            dBTest.DbTesting();

            UserType();
        }

        private void UserType()
        {
            string usertype = mainDAO.GetUserType();            

            if (string.Equals(usertype, "admin", StringComparison.OrdinalIgnoreCase))
            {
                btnNavPatients.Enabled = true; btnPatients.Enabled = true;
                btnChannel.Enabled = true; btnNavChannel.Enabled = true;
                btnMedicines.Enabled = true; btnNavMedicines.Enabled = true;
                btnDoctors.Enabled = true; btnNavDocs.Enabled = true;
                btnPrescription.Enabled = true; btnNavPrescription.Enabled = true;
                btnPayment.Enabled = true; btnNavPayment.Enabled = true;
                btnUsers.Enabled = true; btnNavUsers.Enabled = true;
                btnReports.Enabled = true; btnNavReports.Enabled = true;
                btnCusFeedback.Enabled = true; btnNavCusFeedback.Enabled = true;
            }
            else if (string.Equals(usertype, "coordinator", StringComparison.OrdinalIgnoreCase))
            {
                btnNavPatients.Enabled = true; btnPatients.Enabled = true;
                btnChannel.Enabled = true; btnNavChannel.Enabled = true;
                btnMedicines.Enabled = false; btnNavMedicines.Enabled = false;
                btnDoctors.Enabled = false; btnNavDocs.Enabled = false;
                btnPrescription.Enabled = false; btnNavPrescription.Enabled = false;
                btnPayment.Enabled = false; btnNavPayment.Enabled = false;
                btnUsers.Enabled = false; btnNavUsers.Enabled = false;
                btnReports.Enabled = false; btnNavReports.Enabled = false;
                btnCusFeedback.Enabled = true; btnNavCusFeedback.Enabled = true;
            }
            else if (string.Equals(usertype, "medical superintendent", StringComparison.OrdinalIgnoreCase))
            {
                btnNavPatients.Enabled = true; btnPatients.Enabled = true;
                btnChannel.Enabled = true; btnNavChannel.Enabled = true;
                btnMedicines.Enabled = true; btnNavMedicines.Enabled = true;
                btnDoctors.Enabled = true; btnNavDocs.Enabled = true;
                btnPrescription.Enabled = true; btnNavPrescription.Enabled = true;
                btnPayment.Enabled = true; btnNavPayment.Enabled = true;
                btnUsers.Enabled = false; btnNavUsers.Enabled = false;
                btnReports.Enabled = true; btnNavReports.Enabled = true;
                btnCusFeedback.Enabled = true; btnNavCusFeedback.Enabled = true;
            }
            else if (string.Equals(usertype, "pharmacist", StringComparison.OrdinalIgnoreCase))
            {
                btnNavPatients.Enabled = false; btnPatients.Enabled = false;
                btnChannel.Enabled = true; btnNavChannel.Enabled = true;
                btnMedicines.Enabled = true; btnNavMedicines.Enabled = true;
                btnDoctors.Enabled = false; btnNavDocs.Enabled = false;
                btnPrescription.Enabled = true; btnNavPrescription.Enabled = true;
                btnPayment.Enabled = false; btnNavPayment.Enabled = false;
                btnUsers.Enabled = true; btnNavUsers.Enabled = false;
                btnReports.Enabled = false; btnNavReports.Enabled = false;
                btnCusFeedback.Enabled = false; btnNavCusFeedback.Enabled = false;
            }
            else if (string.Equals(usertype, "dispensers", StringComparison.OrdinalIgnoreCase))
            {
                btnNavPatients.Enabled = false; btnPatients.Enabled = false;
                btnChannel.Enabled = false; btnNavChannel.Enabled = false;
                btnMedicines.Enabled = true; btnNavMedicines.Enabled = true;
                btnDoctors.Enabled = false; btnNavDocs.Enabled = false;
                btnPrescription.Enabled = true; btnNavPrescription.Enabled = true;
                btnPayment.Enabled = false; btnNavPayment.Enabled = false;
                btnUsers.Enabled = false; btnNavUsers.Enabled = false;
                btnReports.Enabled = false; btnNavReports.Enabled = false;
                btnCusFeedback.Enabled = false; btnNavCusFeedback.Enabled = false;
            }
            else if (string.Equals(usertype, "cashiers", StringComparison.OrdinalIgnoreCase))
            {
                btnNavPatients.Enabled = false; btnPatients.Enabled = false;
                btnChannel.Enabled = false; btnNavChannel.Enabled = false;
                btnMedicines.Enabled = false; btnNavMedicines.Enabled = false;
                btnDoctors.Enabled = false; btnNavDocs.Enabled = false;
                btnPrescription.Enabled = false; btnNavPrescription.Enabled = false;
                btnPayment.Enabled = true; btnNavPayment.Enabled = true;
                btnUsers.Enabled = false; btnNavUsers.Enabled = false;
                btnReports.Enabled = false; btnNavReports.Enabled = false;
                btnCusFeedback.Enabled = true; btnNavCusFeedback.Enabled = true;
            }
            else
            {
                //MessageBox.Show("Something went wrong");
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void picBoxHomeIcon_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
        }

        private void lblMinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblCloseProgram_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void FormOpen(Form frm)
        {
            frm.MdiParent = this;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            tblLayoutPnlFuctions.Hide();
            frm.Size = pnlFormOpenArea.Size;
            frm.Dock = DockStyle.Right;
            pnlFormOpenArea.Controls.Add(frm);
            frm.Show();
        }

        public void CloseAllOpenedForm()
        {
            foreach (Form childForm in Application.OpenForms)
            {
                if (!(childForm.Name == this.Name))
                {
                    childForm.Close();
                    tblLayoutPnlFuctions.Show();
                    return;
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            frmDashboard dashboard = new frmDashboard();
            FormOpen(dashboard);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Payment payment = new Payment();
            FormOpen(payment);
        }

        private void btnCusFeedback_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Feedback feedback = new Feedback();
            FormOpen(feedback);
        }

        private void btnChannel_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Channel channel = new Channel();
            FormOpen(channel);
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Prescription prescription = new Prescription();
            FormOpen(prescription);
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Medicines medicines = new Medicines();
            FormOpen(medicines);
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Patients patients = new Patients();
            FormOpen(patients);
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Doctors doctors = new Doctors();
            FormOpen(doctors);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Users users = new Users();
            FormOpen(users);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            Reports reports = new Reports();
            FormOpen(reports);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            CloseAllOpenedForm();
            About about = new About();
            FormOpen(about);
        }

        // Navigation Buttion
        // Used main fuctions. Therefore, no need to modify these method.
        private void btnNavDash_Click(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }

        private void btnNavChannel_Click(object sender, EventArgs e)
        {
            btnChannel_Click(sender, e);
        }

        private void btnNavPrescription_Click(object sender, EventArgs e)
        {
            btnPrescription_Click(sender, e);
        }

        private void btnNavMedicines_Click(object sender, EventArgs e)
        {
            btnMedicines_Click(sender, e);
        }

        private void btnNavPayment_Click(object sender, EventArgs e)
        {
            btnPayment_Click(sender, e);
        }

        private void btnNavPatients_Click(object sender, EventArgs e)
        {
            btnPatients_Click(sender, e);
        }

        private void btnNavDocs_Click(object sender, EventArgs e)
        {
            btnDoctors_Click(sender, e);
        }

        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            btnUsers_Click(sender, e);
        }

        private void btnNavCusFeedback_Click(object sender, EventArgs e)
        {
            btnCusFeedback_Click(sender, e);
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            btnReports_Click(sender, e);
        }

        private void btnNavAbout_Click(object sender, EventArgs e)
        {
            btnAbout_Click(sender, e);
        }

        private void pnlFormOpenArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want logout?", "PIMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void MDIMainForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = GlobalFun.CurrentUserWithGreeting();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void tblLayoutPnlFuctions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
