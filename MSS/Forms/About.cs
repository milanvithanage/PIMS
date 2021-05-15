using System.Drawing;
using System.Windows.Forms;

namespace MSS
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void About_Load(object sender, System.EventArgs e)
        {
            string header = "THE PIMS";

            string body = "";
            body += "This system is developed by... \n\n";
            body += " *  COL/A-058175    Dananjaya Wickramasinghe \n";
            body += " *  COL/E-002139    Dimuth Tharindu \n";
            body += " *  COL/A-058239    Milan Gimhana \n";
            body += " *  COL/E-003785    Oshan Gunathilake \n";

            string footer = "";
            

            lblHeader.Text = header;
            lblBody.Text = body;
            lblFooter.Text = footer;

        }
    }
}
