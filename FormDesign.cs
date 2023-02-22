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
    public partial class FormDesign : Form
    {
        private int currentNum = 0;
        private int num1 = 0;
        private int num2 = 0;
        private int num3 = 0;
        private int num4 = 0;
        private int num5 = 0;
        private int num6 = 0;

        private Form currentForm;

        public FormDesign()
        {
            InitializeComponent();
            InitLanguage();
        }

        private void button1m_Click(object sender, EventArgs e)
        {
            if (num1 <= 0)
            {
                return;
            }
            num1 = num1 - 1;
            button1num.Text = num1.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button1p_Click(object sender, EventArgs e)
        {
            if (num1 >= 8)
            {
                return;
            }
            num1 = num1 + 1;
            button1num.Text = num1.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button2m_Click(object sender, EventArgs e)
        {
            if (num2 <= 0)
            {
                return;
            }
            num2 = num2 - 1;
            button2num.Text = num2.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button2p_Click(object sender, EventArgs e)
        {
            if (num2 >= 8)
            {
                return;
            }
            num2 = num2 + 1;
            button2num.Text = num2.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button3m_Click(object sender, EventArgs e)
        {
            if (num3 <= 0)
            {
                return;
            }
            num3 = num3 - 1;
            button3num.Text = num3.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button3p_Click(object sender, EventArgs e)
        {
            if (num3 >= 8)
            {
                return;
            }
            num3 = num3 + 1;
            button3num.Text = num3.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button4m_Click(object sender, EventArgs e)
        {
            if (num4 <= 0)
            {
                return;
            }
            num4 = num4 - 1;
            button4num.Text = num4.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button4p_Click(object sender, EventArgs e)
        {
            if (num4 >= 8)
            {
                return;
            }
            num4 = num4 + 1;
            button4num.Text = num4.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button5m_Click(object sender, EventArgs e)
        {
            if (num5 <= 0)
            {
                return;
            }
            num5 = num5 - 1;
            button5num.Text = num5.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button5p_Click(object sender, EventArgs e)
        {
            if (num5 >= 8)
            {
                return;
            }
            num5 = num5 + 1;
            button5num.Text = num5.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button6m_Click(object sender, EventArgs e)
        {
            if (num6 <= 0)
            {
                return;
            }
            num6 = num6 - 1;
            button6num.Text = num6.ToString() + "0";
            UpdateCurrentNum();
        }

        private void button6p_Click(object sender, EventArgs e)
        {
            if (num6 >= 8)
            {
                return;
            }
            num6 = num6 + 1;
            button6num.Text = num6.ToString() + "0";
            UpdateCurrentNum();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (currentNum > 8)
            {
                if (GlobalValue.globalLanguage)
                {
                    MessageBox.Show("超过最大值！");
                }
                else
                {
                    MessageBox.Show("The maximum value has been exceeded!");
                }
                return;
            }

            StringBuilder sb = new StringBuilder();
            if (num1 != 0)
            {
                sb.Append("1" + num1);
            }
            if (num2 != 0)
            {
                sb.Append("2" + num2);
            }
            if (num3 != 0)
            {
                sb.Append("3" + num3);
            }
            if (num4 != 0)
            {
                sb.Append("4" + num4);
            }
            if (num5 != 0)
            {
                sb.Append("5" + num5);
            }
            if (num6 != 0)
            {
                sb.Append("6" + num6);
            }

            if (GlobalValue.globalIsPortOpening == true)
            {
                GlobalValue.globalCocktailCode = sb.ToString();
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

        private void UpdateCurrentNum()
        {
            currentNum = num1 + num2 + num3 + num4 + num5 + num6;

            if (GlobalValue.globalLanguage)
            {
                label3.Text = "当前 " + currentNum + "0 毫升";
            }
            else
            {
                label3.Text = "Now " + currentNum + "0 ml";
            }
        }

        private void InitLanguage()
        {
            if (GlobalValue.globalLanguage)
            {
                label1.Text = "基酒";
                label2.Text = "配料";
                label4.Text = "最大 80 毫升";
                button1.Text = "龙舌兰";
                button2.Text = "朗姆酒";
                button3.Text = "伏特加";
                button4.Text = "柠檬汁";
                button5.Text = "菠萝汁";
                button6.Text = "蓝橙酒";
            }
            else
            {
                label1.Text = "Base wine";
                label2.Text = "Ingredients";
                label4.Text = "Max 80 ml";
                button1.Text = "Tequila";
                button2.Text = "Rum";
                button3.Text = "Vodka";
                button4.Text = "Lemon Juice";
                button5.Text = "Pineapple Juice";
                button6.Text = "Blue Curacao";
            }
        }
    }
}
