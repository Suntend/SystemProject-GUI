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
    public partial class FormMain : Form
    {
        private Button currentButton;
        private Form   currentForm;

        public FormMain()
        {
            //Initialize the window, This code must be loaded first.
            InitializeComponent();

            GlobalValue.globalFormNumber = 0;
            buttonBack.Visible = false;
            buttonYes.Visible = false;

            SetLabelInfoLanguage();
        }

        private void SetLabelInfoLanguage()
        {
            if (GlobalValue.globalLanguage)
            {
                labelInfoCN.Visible = true;
                labelInfoEN.Visible = false;
                buttonClassic.Text  = LanguageStrings.FM_C_buttonClassic;
                buttonDesign.Text   = LanguageStrings.FM_C_buttonDesign;
                buttonSettings.Text = LanguageStrings.FM_C_buttonSettings;
            }
            else
            {
                labelInfoCN.Visible = false;
                labelInfoEN.Visible = true;
                buttonClassic.Text  = LanguageStrings.FM_E_buttonClassic;
                buttonDesign.Text   = LanguageStrings.FM_E_buttonDesign;
                buttonSettings.Text = LanguageStrings.FM_E_buttonSettings;
            }
        }

        //Configure button display effect.
        //When the button is pressed, the current focus button will change some UI.
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(250, 222, 200);
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 134);
                    buttonBack.Visible = true;
                }
            }
        }

        //Configure button display effect.
        //When the button loses focus, change its UI back to the default.
        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(255, 240, 220);
                    previousButton.ForeColor = Color.Black;
                    previousButton.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
                }
            }
        }

        private void OpenForm(Form childForm, object btnSender)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            ActivateButton(btnSender);
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (GlobalValue.globalLanguage)
            {
                switch (GlobalValue.globalFormNumber)
                {
                    case 0:
                        labelTitle.Text = LanguageStrings.FM_C_labelTitle1; break;

                    case 1:
                        labelTitle.Text = LanguageStrings.FM_C_labelTitle2; break;

                    case 2:
                        labelTitle.Text = LanguageStrings.FM_C_labelTitle3; break;

                    case 3:
                        labelTitle.Text = LanguageStrings.FM_C_labelTitle4; break;

                    case 4: case 5: case 6:
                        labelTitle.Text = LanguageStrings.FM_C_labelTitle2; break;

                    case 7:
                        labelTitle.Text = LanguageStrings.FM_C_labelTitle3; break;

                    case 8:
                        labelTitle.Text = LanguageStrings.FM_C_labelTitle5;
                        buttonBack.Visible = false;
                        break;
                }
            }
            else
            {
                switch (GlobalValue.globalFormNumber)
                {
                    case 0:
                        labelTitle.Text = LanguageStrings.FM_E_labelTitle1; break;

                    case 1:
                        labelTitle.Text = LanguageStrings.FM_E_labelTitle2; break;

                    case 2:
                        labelTitle.Text = LanguageStrings.FM_E_labelTitle3; break;

                    case 3:
                        labelTitle.Text = LanguageStrings.FM_E_labelTitle4; break;

                    case 4: case 5: case 6:
                        labelTitle.Text = LanguageStrings.FM_E_labelTitle2; break;

                    case 7:
                        labelTitle.Text = LanguageStrings.FM_E_labelTitle3; break;

                    case 8:
                        labelTitle.Text = LanguageStrings.FM_E_labelTitle5;
                        buttonBack.Visible = false;
                        break;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentForm != null && GlobalValue.globalBartending == false)
            {
                switch (GlobalValue.globalFormNumber)
                {
                    case 0: //Form Main

                    case 1: //Form Classic

                    case 2: //Form Design

                    case 3: //Form Settings

                        if (GlobalValue.globalLanguage)
                        {
                            labelTitle.Text = LanguageStrings.FM_C_labelTitle1;
                        }
                        else
                        {
                            labelTitle.Text = LanguageStrings.FM_E_labelTitle1;
                        }
                        currentForm.Close();
                        buttonBack.Visible = false;
                        break;

                    case 4: //C-1

                    case 5: //C-2

                    case 6: //C-3

                        if (GlobalValue.globalLanguage)
                        {
                            labelTitle.Text = LanguageStrings.FM_C_labelTitle2;
                        }
                        else
                        {
                            labelTitle.Text = LanguageStrings.FM_E_labelTitle2;
                        }
                        GlobalValue.globalFormNumber = 1;
                        OpenForm(new FormClassic(), sender);
                        break;

                    case 7: //D

                        if (GlobalValue.globalLanguage)
                        {
                            labelTitle.Text = LanguageStrings.FM_C_labelTitle3;
                        }
                        else
                        {
                            labelTitle.Text = LanguageStrings.FM_E_labelTitle3;
                        }
                        GlobalValue.globalFormNumber = 2;
                        OpenForm(new FormDesign(), sender);
                        break;

                    default:
                        if (GlobalValue.globalLanguage)
                        {
                            labelTitle.Text = LanguageStrings.FM_C_labelTitle1;
                        }
                        else
                        {
                            labelTitle.Text = LanguageStrings.FM_E_labelTitle1;
                        }
                        currentForm.Close();
                        buttonBack.Visible = false;
                        break;
                }

                DisableButton();
                currentButton = null;
            }
            else if (GlobalValue.globalBartending)
            {
                if (GlobalValue.globalLanguage)
                {
                    labelTitle.Text = "请等待当前任务完成！";
                }
                else
                {
                    labelTitle.Text = "Please wait for the current task to complete!";
                }
            }

            SetLabelInfoLanguage();
            buttonBack.BackColor = Color.FromArgb(178, 216, 233);
        }

        private void buttonClassic_Click(object sender, EventArgs e)
        {
            if (GlobalValue.globalBartending)
            {
                if (GlobalValue.globalLanguage)
                {
                    labelTitle.Text = "请等待当前任务完成！";
                }
                else
                {
                    labelTitle.Text = "Please wait for the current task to complete!";
                }
            }
            else
            {
                GlobalValue.globalFormNumber = 1;
                OpenForm(new FormClassic(), sender);
                SetLabelInfoLanguage();
            }
        }

        private void buttonDesign_Click(object sender, EventArgs e)
        {
            if (GlobalValue.globalBartending)
            {
                if (GlobalValue.globalLanguage)
                {
                    labelTitle.Text = "请等待当前任务完成！";
                }
                else
                {
                    labelTitle.Text = "Please wait for the current task to complete!";
                }
            }
            else
            {
                GlobalValue.globalFormNumber = 2;
                OpenForm(new FormDesign(), sender);
                SetLabelInfoLanguage();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (GlobalValue.globalBartending)
            {
                if (GlobalValue.globalLanguage)
                {
                    labelTitle.Text = "请等待当前任务完成！";
                }
                else
                {
                    labelTitle.Text = "Please wait for the current task to complete!";
                }
            }
            else
            {
                GlobalValue.globalFormNumber = 3;
                OpenForm(new FormSettings(), sender);
                SetLabelInfoLanguage();
            }
        }
    }
}