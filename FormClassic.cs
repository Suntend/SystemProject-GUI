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
    public partial class FormClassic : Form
    {
        private Form currentForm;

        public FormClassic()
        {
            InitializeComponent();

            if (GlobalValue.globalLanguage)
            {
                buttonC1.Text = "龙舌兰日出";
                buttonC2.Text = "蓝色夏威夷";
                buttonC3.Text = "长岛冰茶";
            }
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

        private void buttonC1_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 4;
            OpenForm(new FormClassicInfo1(), sender);
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 5;
            OpenForm(new FormClassicInfo2(), sender);
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 6;
            OpenForm(new FormClassicInfo3(), sender);
        }
    }
}
