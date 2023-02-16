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
    public partial class FormClassicInfo2 : Form
    {
        public FormClassicInfo2()
        {
            InitializeComponent();

            if (GlobalValue.globalLanguage)
            {
                buttonC1.Text = "蓝色夏威夷";
                labelInfoEN.Visible = false;
            }
            else
            {
                labelInfoCN.Visible = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
