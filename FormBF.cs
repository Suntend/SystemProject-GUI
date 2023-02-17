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
    public partial class FormBF : Form
    {
        public FormBF()
        {
            InitializeComponent();

            if (GlobalValue.globalLanguage)
            {
                labelBartending.Text = "制作中...";
            }
        }
    }
}
