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

            comboBoxPort.Visible        = false;
            buttonPortOpenClose.Visible = false;
            labelNoPortWarn.Visible     = false;
            labelPortNameCOM.Visible    = false;

            if (GlobalValue.globalLanguage)
            {
                labelPortName.Text = "端口：";
                labelNoPortWarn.Text = "没有端口！";
                labelMore.Text = "探索更多：";
                buttonToO.Text = "官方网站 >";
                buttonToG.Text = "Github >";
                buttonToB.Text = "联系作者 >";
            }

            buttonLanguageSet();
            buttonPortSet();

            //获取端口列表，判断状态防止open时load
            //当没开端口时
            if (GlobalValue.globalIsPortOpening == false)
            {
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
                    labelNoPortWarn.Visible = false;
                    labelPortNameCOM.Visible = false;
                    buttonPortSet();
                }
                else
                {
                    //MessageBox.Show("No Port!");
                    comboBoxPort.Visible = false;
                    buttonPortOpenClose.Visible = false;
                    labelNoPortWarn.Visible = true;
                    labelPortNameCOM.Visible = false;
                }
            }
            //若已经打开了端口
            else if (GlobalValue.globalIsPortOpening == true)
            {
                comboBoxPort.Visible = false;
                buttonPortOpenClose.Visible = true;
                labelNoPortWarn.Visible = false;
                labelPortNameCOM.Text = GlobalValue.globalPortNameSet;
                labelPortNameCOM.Visible = true;
            }
            
        }

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取当前选中端口
            GlobalValue.globalPortNameSet = comboBoxPort.SelectedItem.ToString();
            GlobalMethod.LoadPort();
        }

        private void buttonPortOpenClose_Click(object sender, EventArgs e)
        {
            if (GlobalValue.globalIsPortOpening == false)
            {
                GlobalMethod.OpenPort();
                comboBoxPort.Visible = false;
                labelPortNameCOM.Text = GlobalValue.globalPortNameSet;
                labelPortNameCOM.Visible = true;
            }
            else if (GlobalValue.globalIsPortOpening == true)
            {
                GlobalMethod.ClosePort();
                comboBoxPort.Visible = true;
                labelPortNameCOM.Visible = false;
            }
            buttonPortSet();
        }

        //开关按钮 换字换色
        private void buttonPortSet()
        {
            if (GlobalValue.globalIsPortOpening == true)
            {
                buttonPortOpenClose.BackColor = Color.Green;
                if (GlobalValue.globalLanguage)
                {
                    buttonPortOpenClose.Text = "已开启";
                    labelPortBtnInfoEN.Visible = false;
                    labelPortBtnInfoCN.Visible = true;
                }
                else
                {
                    buttonPortOpenClose.Text = "Opening";
                    labelPortBtnInfoEN.Visible = true;
                    labelPortBtnInfoCN.Visible = false;
                } 
                    
            }
            else if (GlobalValue.globalIsPortOpening == false)
            {
                buttonPortOpenClose.BackColor = Color.Red;
                if (GlobalValue.globalLanguage)
                {
                    buttonPortOpenClose.Text = "已关闭";
                    labelPortBtnInfoEN.Visible = false;
                    labelPortBtnInfoCN.Visible = true;
                }
                else
                {
                    buttonPortOpenClose.Text = "Closed";
                    labelPortBtnInfoEN.Visible = true;
                    labelPortBtnInfoCN.Visible = false;
                }
            }
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            if (radioButtonCN.Checked)
            {
                GlobalValue.globalLanguage = true;
                MessageBox.Show("已切换为简体中文！");
            }
            else if (radioButtonEN.Checked)
            {
                GlobalValue.globalLanguage = false;
                MessageBox.Show("Switched to English!");
            }
            buttonLanguageSet();
        }

        private void buttonLanguageSet()
        {
            if (GlobalValue.globalLanguage == false)
            {
                radioButtonEN.Checked = true;
                radioButtonCN.Checked = false;
            }
            else if (GlobalValue.globalLanguage == true)
            {
                radioButtonEN.Checked = false;
                radioButtonCN.Checked = true;
            }
        }

        private void buttonToO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.baidu.com/");
        }

        private void buttonToG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Suntend/vsGUI");
        }

        private void buttonToB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/340532672");
        }
    }
}
