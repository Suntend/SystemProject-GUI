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

            if (GlobalValue.globalLanguage)  //初始化文本
            {
                buttonC1.Text = "龙舌兰日出";
                buttonC2.Text = "蓝色夏威夷";
                buttonC3.Text = "长岛冰茶";
            }
        }

        //打开新窗口
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

        /// <summary>
        /// 按钮监听，分别对应3种经典鸡尾酒
        /// button C1~C3
        /// </summary>
        private void buttonC1_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 4;           //更新状态
            GlobalValue.globalCocktailCode = "144252";  //将鸡尾酒代码写入全局变量
            OpenForm(new FormClassicInfo1(), sender);   //打开介绍页面
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 5;           //同上
            GlobalValue.globalCocktailCode = "245262";
            OpenForm(new FormClassicInfo2(), sender);
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 6;           //同上
            GlobalValue.globalCocktailCode = "133342";
            OpenForm(new FormClassicInfo3(), sender);
        }
    }
}
