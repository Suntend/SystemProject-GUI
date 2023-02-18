using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            if (GlobalValue.globalLanguage)
            {
                buttonC1.Text = "龙舌兰日出";
                labelInfoEN.Visible = false;
            }
            else
            {
                labelInfoCN.Visible = false;
            }
        }

        //When click the button, the corresponding childForm will be displayed.
        public void OpenForm(Form childForm, object btnSender)
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
                GlobalValue.globalCocktailCode = "144252";
                GlobalMethod.PortSend("checkP");
                buttonYes.Visible = false;

                //等待3秒，否则超时
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    if (GlobalValue.globalBartending)
                    {
                        OpenForm(new FormBF(), sender);
                    }
                }
                buttonYes.Visible = true;
            }
            else
            {
                MessageBox.Show("Port is not open!");
            }
        }
    }
}
