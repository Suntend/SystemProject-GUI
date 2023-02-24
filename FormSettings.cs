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
            SetControlsLanguage();     //初始化文本
            SetButtonLanguageIndex();  //初始化语言按钮
            SetButtonPort();           //初始化端口按钮

            //当没打开端口时
            if (GlobalValue.globalIsPortOpening == false )
            {
                GlobalMethod.GetPort();  //加载所有可用端口

                //没开端口 且 有可用端口时
                if (GlobalValue.globalPortName.Length != 0 && GlobalValue.globalPortName != null)
                {
                    InitComboBox();  //初始化下拉栏
                    labelNoPortWarn.Visible = false;
                    labelPortNameCOM.Visible = false;
                    SetPortInfoVisible();
                }
                //没开端口 且 没有可用端口
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
                labelPortNameCOM.Text = GlobalValue.globalPortNameSet;  //显示当前端口名称
                comboBoxPort.Visible = false;
                labelNoPortWarn.Visible = false;
                SetPortInfoVisible();
            }
        }

        //初始化下拉栏
        private void InitComboBox()
        {
            //清空下拉栏
            comboBoxPort.Items.Clear();
            //遍历端口并写入
            foreach (string s in GlobalValue.globalPortName)
            {
                comboBoxPort.Items.Add(s);
            }
            //添加默认索引为0，不然丑
            comboBoxPort.SelectedIndex = 0;
        }

        //注册事件，当下拉栏文本改变时执行
        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取当前选中端口，写入全局变量
            GlobalValue.globalPortNameSet = comboBoxPort.SelectedItem.ToString();
        }

        //当控制端口的按钮被点击时
        private void buttonPortOpenClose_Click(object sender, EventArgs e)
        {
            if (GlobalValue.globalIsPortOpening == false)
            {
                //如果当前是关闭状态，则打开
                GlobalMethod.LoadPort();
                GlobalMethod.OpenPort();
                comboBoxPort.Visible = false;
                labelPortNameCOM.Text = GlobalValue.globalPortNameSet;
                labelPortNameCOM.Visible = true;
            }
            else if (GlobalValue.globalIsPortOpening == true)
            {
                //如果当前时打开状态，则关闭
                GlobalMethod.ClosePort();
                labelPortNameCOM.Visible = false;
                comboBoxPort.Visible = true;
                InitComboBox();
            }

            SetButtonPort();  //刷新端口按钮样式
        }

        //设置端口按钮样式
        private void SetButtonPort()
        {
            if (GlobalValue.globalIsPortOpening == true)
            {
                buttonPortOpenClose.BackColor = Color.Green;
                if (GlobalValue.globalLanguage)
                {
                    buttonPortOpenClose.Text = "已开启";
                    SetPortInfoVisible();  //设置端口介绍label可见性
                }
                else
                {
                    buttonPortOpenClose.Text = "Opening";
                    SetPortInfoVisible();  //设置端口介绍label可见性
                }

            }
            else if (GlobalValue.globalIsPortOpening == false)
            {
                buttonPortOpenClose.BackColor = Color.Red;
                if (GlobalValue.globalLanguage)
                {
                    buttonPortOpenClose.Text = "已关闭";
                    SetPortInfoVisible();  //设置端口介绍label可见性
                }
                else
                {
                    buttonPortOpenClose.Text = "Closed";
                    SetPortInfoVisible();  //设置端口介绍label可见性
                }
            }
        }

        //设置控件文本
        private void SetControlsLanguage()
        {
            if (GlobalValue.globalLanguage)
            {
                //CN
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
                //EN
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

        //设置端口介绍label可见性
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
                GlobalValue.globalLanguage = true;  //更新状态
                
                SoundPlayer soundPlayer = new SoundPlayer();  //播放音频
                soundPlayer.SoundLocation = @"D:\vsProject\vsGUI\Resources\SwitchToCN.wav";
                soundPlayer.Load();
                soundPlayer.Play();

                MessageBox.Show("已切换为简体中文！");
            }
            else if (radioButtonEN.Checked)
            {
                GlobalValue.globalLanguage = false;  //更新状态
                
                SoundPlayer soundPlayer = new SoundPlayer();  //播放音频
                soundPlayer.SoundLocation = @"D:\vsProject\vsGUI\Resources\SwitchToEN.wav";
                Console.WriteLine(Application.StartupPath);
                soundPlayer.Load();
                soundPlayer.Play();

                MessageBox.Show("Switched to English!");
            }

            SetControlsLanguage();  //刷新文本
            SetButtonPort();        //刷新按钮样式
        }

        //跳转网页
        private void buttonToO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://icms.jamsg.cn");
        }

        //跳转网页
        private void buttonToG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Suntend/vsGUI");
        }

        //跳转网页
        private void buttonToB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/340532672");
        }

        //实时更新温度，温度过高会报警
        private void UpdateTemp(object sender, EventArgs e)
        {
            labelTempNum.Text = GlobalValue.globalTemperature;  //显示温度

            try
            {
                double temp = double.Parse(GlobalValue.globalTemperature);  //string转double
                if (warnTemp == true && temp > 30.0)
                {
                    WarnTemp();  //温度报警
                }
            }
            catch
            {
                Console.WriteLine(GlobalValue.globalTemperature);  //输出错误信息
            }
        }

        private void WarnTemp()
        {
            warnTemp = false;  //每次进入设置页，至多触发1次报警

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
