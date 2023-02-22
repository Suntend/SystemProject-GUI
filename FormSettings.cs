using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsGUI
{
    public partial class FormSettings : Form
    {
        private bool warnTemp = true;

        public FormSettings()
        {
            InitializeComponent();
            labelPortBtnInfoCN.Visible = false;
            labelPortBtnInfoEN.Visible = false;
            SetControlsLanguage();
            SetButtonLanguageIndex();
            SetButtonPort();

            //当没打开端口时
            if (GlobalValue.globalIsPortOpening == false )
            {
                GlobalMethod.GetPort();

                //没开 且 有可用端口时
                if (GlobalValue.globalPortName.Length != 0 && GlobalValue.globalPortName != null)
                {
                    InitComboBox();
                    labelNoPortWarn.Visible = false;
                    labelPortNameCOM.Visible = false;
                    SetPortInfoVisible();
                }
                //没开 且 没有可用端口
                else
                {
                    comboBoxPort.Visible = false;
                    buttonPortOpenClose.Visible = false;
                    labelPortNameCOM.Visible = false;
                }
            }
            //已经打开了端口
            else
            {
                labelPortNameCOM.Text = GlobalValue.globalPortNameSet;
                comboBoxPort.Visible = false;
                labelNoPortWarn.Visible = false;
                SetPortInfoVisible();
            }
        }

        private void InitComboBox()
        {
            comboBoxPort.Items.Clear();
            //遍历写入控件
            foreach (string s in GlobalValue.globalPortName)
            {
                comboBoxPort.Items.Add(s);
            }
            //添加默认索引，不然丑
            comboBoxPort.SelectedIndex = 0;
        }

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取当前选中端口
            GlobalValue.globalPortNameSet = comboBoxPort.SelectedItem.ToString();
            //GlobalMethod.LoadPort();
        }

        private void buttonPortOpenClose_Click(object sender, EventArgs e)
        {
            if (GlobalValue.globalIsPortOpening == false)
            {
                GlobalMethod.LoadPort();
                GlobalMethod.OpenPort();
                comboBoxPort.Visible = false;
                labelPortNameCOM.Text = GlobalValue.globalPortNameSet;
                labelPortNameCOM.Visible = true;
            }
            else if (GlobalValue.globalIsPortOpening == true)
            {
                GlobalMethod.ClosePort();
                labelPortNameCOM.Visible = false;
                comboBoxPort.Visible = true;
                InitComboBox();
            }

            SetButtonPort();
        }

        //端口开关按钮 换字换色
        private void SetButtonPort()
        {
            if (GlobalValue.globalIsPortOpening == true)
            {
                buttonPortOpenClose.BackColor = Color.Green;
                if (GlobalValue.globalLanguage)
                {
                    buttonPortOpenClose.Text = "已开启";
                    SetPortInfoVisible();
                }
                else
                {
                    buttonPortOpenClose.Text = "Opening";
                    SetPortInfoVisible();
                }

            }
            else if (GlobalValue.globalIsPortOpening == false)
            {
                buttonPortOpenClose.BackColor = Color.Red;
                if (GlobalValue.globalLanguage)
                {
                    buttonPortOpenClose.Text = "已关闭";
                    SetPortInfoVisible();
                }
                else
                {
                    buttonPortOpenClose.Text = "Closed";
                    SetPortInfoVisible();
                }
            }
        }

        //设置控件中文
        private void SetControlsLanguage()
        {
            if (GlobalValue.globalLanguage)
            {
                labelPortName.Text = "端口：";
                labelNoPortWarn.Text = "没有端口！";
                labelTemp.Text = "温度：";
                labelMore.Text = "探索更多：";
                buttonToO.Text = "官方网站 >";
                buttonToG.Text = "Github >";
                buttonToB.Text = "联系作者 >";
                labelLangBtnInfo.Text = "刷新页面以确认切换语言";
            }
            else
            {
                labelPortName.Text = "Port Name :";
                labelNoPortWarn.Text = "No Port !";
                labelTemp.Text = "Temperature :";
                labelMore.Text = "Explore More :";
                buttonToO.Text = "Official Website >";
                buttonToG.Text = "Browse in Github >";
                buttonToB.Text = "Contact Author >";
                labelLangBtnInfo.Text = "Refresh the page to confirm switching language";
            }
        }

        //端口介绍组件设置可见性
        private void SetPortInfoVisible()
        {
            if (GlobalValue.globalLanguage)
            {
                labelPortBtnInfoCN.Visible = true;
                labelPortBtnInfoEN.Visible = false;
            }
            else
            {
                labelPortBtnInfoCN.Visible = false;
                labelPortBtnInfoEN.Visible = true;
            }
        }

        //设置2选1按钮的选择情况
        private void SetButtonLanguageIndex()
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

        //当按下按钮，即更改语言生效
        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            if (radioButtonCN.Checked)
            {
                GlobalValue.globalLanguage = true;
                
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = @"D:\vsProject\vsGUI\Resources\SwitchToCN.wav";
                soundPlayer.Load();
                soundPlayer.Play();

                MessageBox.Show("已切换为简体中文！");
            }
            else if (radioButtonEN.Checked)
            {
                GlobalValue.globalLanguage = false;
                
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = @"D:\vsProject\vsGUI\Resources\SwitchToEN.wav";
                Console.WriteLine(Application.StartupPath);
                soundPlayer.Load();
                soundPlayer.Play();

                MessageBox.Show("Switched to English!");
            }
            SetControlsLanguage();
            SetButtonPort();
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

        private void UpdateTemp(object sender, EventArgs e)
        {
            labelTempNum.Text = GlobalValue.globalTemperature;
            try
            {
                double temp = double.Parse(GlobalValue.globalTemperature);
                if (warnTemp == true && temp > 30.0)
                {
                    WarnTemp();
                }
            }
            catch
            {
                Console.WriteLine(GlobalValue.globalTemperature);
            }
        }

        private void WarnTemp()
        {
            warnTemp = false;

            if (GlobalValue.globalLanguage)
            {
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = @"D:\vsProject\vsGUI\Resources\TempTooHighCN.wav";
                Console.WriteLine(Application.StartupPath);
                soundPlayer.Load();
                soundPlayer.Play();
            }
            else
            {
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = @"D:\vsProject\vsGUI\Resources\TempTooHighEN.wav";
                Console.WriteLine(Application.StartupPath);
                soundPlayer.Load();
                soundPlayer.Play();
            }
        }
    }
}
