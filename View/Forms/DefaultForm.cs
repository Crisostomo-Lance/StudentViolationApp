using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentViolationApp.View
{
    public partial class DefaultForm : Form
    {

        public DefaultForm()
        {
            InitializeComponent();
            AccountPanel();
        }

        //Function to hide the account panel
        private void AccountPanel()
        {
            panelAccountConainer.Visible = false;

        }

        private void toggleAccountPanel()
        {
            // Toggle the visibility of the account panel
            panelAccountConainer.Visible = !panelAccountConainer.Visible;
        }


        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            toggleAccountPanel();
        }

        //Function to handle the KeyDown event for the search TextBox
        private void txtBoxSearchAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { e.SuppressKeyPress = true;
                MessageBox.Show("Enter key pressed in the search box.");
                // Optionally, prevent the default behavior (like beep on Enter in TextBox)
                
     
            }
        }

        private void txtBoxSearchAll_TextChanged(object sender, EventArgs e)
        {
            txtBoxSearchAll_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }




    }
}
