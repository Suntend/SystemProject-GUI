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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            comboBoxPort.Visible = false;
            buttonPortOpenClose.Visible = false;

            labelNoPortWarn.Visible = false;

            //获取端口列表
            GlobalMethod.GetPort();

            //判断是否为空
            if (GlobalValue.globalPortName.Length != 0 && GlobalValue.globalPortName != null)
            {
                //遍历写入控件
                foreach (string s in GlobalValue.globalPortName)
                {
                    comboBoxPort.Items.Add(s);
                }
                //添加默认索引，不然丑
                comboBoxPort.SelectedIndex = 0;

                comboBoxPort.Visible = true;
                buttonPortOpenClose.Visible = true;
                buttonSet();
            }
            else
            {
                //MessageBox.Show("No Port!");
                labelNoPortWarn.Visible = true;
            }
        }

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取当前选中端口
            GlobalValue.globalPortNameSet = comboBoxPort.SelectedItem.ToString();
            GlobalMethod.LoadPort();
        }

        private void buttonSet()
        {
            if (GlobalValue.globalIsPortOpening == true)
            {
                buttonPortOpenClose.BackColor = Color.Green;
                buttonPortOpenClose.Text = "Opening";
            }
            else if (GlobalValue.globalIsPortOpening == false)
            {
                buttonPortOpenClose.BackColor = Color.Red;
                buttonPortOpenClose.Text = "Closed";
            }
        }

        private void buttonPortOpenClose_Click(object sender, EventArgs e)
        {
            if (GlobalValue.globalIsPortOpening == false)
            {
                GlobalMethod.OpenPort();
            }
            else if (GlobalValue.globalIsPortOpening == true)
            {
                GlobalMethod.ClosePort();
            }
            buttonSet();
        }
    }
}
