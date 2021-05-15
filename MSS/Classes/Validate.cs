using System;
using System.Windows.Forms;

namespace MSS
{
    class Validate
    {
        // This class is used to verify user inputs
        // Updated 17 Dec 2017
        // Version 01

        public Boolean IsTextboxEmpty(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //MessageBox.Show("Please insert the all data", "PIMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
