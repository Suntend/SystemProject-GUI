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

            switch(GlobalValue.globalFormNumber)
            {
                case 0:
                    labelTitle.Text = "W E L C O M E";
                    break;

                case 1:
                    labelTitle.Text = "Classic cocktails";
                    break;

                case 2:
                    labelTitle.Text = "Design your own";
                    break;

                case 3:
                    labelTitle.Text = "Settings";
                    break;

                case 4:

                case 5:

                case 6:

                    labelTitle.Text = "Classic cocktails";
                    break;

                case 7:
                    labelTitle.Text = "Design your own";
                    break;

                case 8:
                    labelTitle.Text = "Bartending";
                    buttonBack.Visible = false;
                    break;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                switch (GlobalValue.globalFormNumber)
                {
                    case 0: //Form Main

                    case 1: //Form Classic

                    case 2: //Form Design

                    case 3: //Form Settings

                        labelTitle.Text = "W E L C O M E";
                        currentForm.Close();
                        buttonBack.Visible = false;
                        break;

                    case 4: //C-1

                    case 5: //C-2

                    case 6: //C-3

                        labelTitle.Text = "Classic cocktails";
                        GlobalValue.globalFormNumber = 1;
                        OpenForm(new FormClassic(), sender);
                        break;

                    case 7: //D

                        labelTitle.Text = "Design your own";
                        GlobalValue.globalFormNumber = 2;
                        OpenForm(new FormDesign(), sender);
                        break;

                    default:
                        labelTitle.Text = "W E L C O M E";
                        currentForm.Close();
                        buttonBack.Visible = false;
                        break;
                }

                DisableButton();
                currentButton = null;
            }
            buttonBack.BackColor = Color.FromArgb(178, 216, 233);
        }

        private void buttonClassic_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 1;
            OpenForm(new FormClassic(), sender);
        }

        private void buttonDesign_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 2;
            OpenForm(new FormDesign(), sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            GlobalValue.globalFormNumber = 3;
            OpenForm(new FormSettings(), sender);
        }
    }
}