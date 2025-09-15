using StudentViolationApp.View.Forms;
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
            loadForms(new DashboardForm());
        }

        private void loadForms(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
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

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            loadForms(new DashboardForm());
           
        }

        private void btnStudentsForm_Click(object sender, EventArgs e)
        {
            loadForms(new StudentForm());
          
        }

        private void btnViolationsForm_Click(object sender, EventArgs e)
        {
            loadForms(new ViolationForm());
          
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            loadForms(new ReportsForm());
         
        }

        private void btnSettingForm_Click(object sender, EventArgs e)
        {
            loadForms(new SettingForm());
        
        }

        private void lbl_Role_Click(object sender, EventArgs e)
        {

        }


        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
