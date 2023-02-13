using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsGUI
{
    public partial class FormClassicInfo1 : Form
    {
        private Form currentForm;

        public FormClassicInfo1()
        {
            InitializeComponent();
        }

        //When click the button, the corresponding childForm will be displayed.
        private void OpenForm(Form childForm, object btnSender)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (GlobalValue.globalIsPortOpening == true)
            {
                GlobalMethod.PortSend("1");
            }
            else
            {
                MessageBox.Show("Port is not open!");
            }
        }
    }
}
