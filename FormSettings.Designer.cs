
namespace vsGUI
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelPortName = new System.Windows.Forms.Label();
            this.buttonPortOpenClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNoPortWarn = new System.Windows.Forms.Label();
            this.buttonToBilibili = new System.Windows.Forms.Button();
            this.buttonToGithub = new System.Windows.Forms.Button();
            this.labelPortBtnInfo = new System.Windows.Forms.Label();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.panelPort = new System.Windows.Forms.Panel();
            this.panelMore = new System.Windows.Forms.Panel();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.radioButtonEN = new System.Windows.Forms.RadioButton();
            this.radioButtonCN = new System.Windows.Forms.RadioButton();
            this.labelReToEffEN = new System.Windows.Forms.Label();
            this.labelReToEffCN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.panelPort.SuspendLayout();
            this.panelMore.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(182, 24);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(238, 32);
            this.comboBoxPort.TabIndex = 1;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // labelPortName
            // 
            this.labelPortName.AutoSize = true;
            this.labelPortName.Location = new System.Drawing.Point(28, 21);
            this.labelPortName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPortName.Name = "labelPortName";
            this.labelPortName.Size = new System.Drawing.Size(142, 24);
            this.labelPortName.TabIndex = 2;
            this.labelPortName.Text = "Port Name :";
            // 
            // buttonPortOpenClose
            // 
            this.buttonPortOpenClose.BackColor = System.Drawing.Color.Red;
            this.buttonPortOpenClose.Location = new System.Drawing.Point(448, 10);
            this.buttonPortOpenClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonPortOpenClose.Name = "buttonPortOpenClose";
            this.buttonPortOpenClose.Size = new System.Drawing.Size(150, 46);
            this.buttonPortOpenClose.TabIndex = 3;
            this.buttonPortOpenClose.Text = "Closed";
            this.buttonPortOpenClose.UseVisualStyleBackColor = false;
            this.buttonPortOpenClose.Click += new System.EventHandler(this.buttonPortOpenClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelMore);
            this.panel1.Controls.Add(this.panelPort);
            this.panel1.Controls.Add(this.panelLanguage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 722);
            this.panel1.TabIndex = 4;
            // 
            // labelNoPortWarn
            // 
            this.labelNoPortWarn.AutoSize = true;
            this.labelNoPortWarn.Location = new System.Drawing.Point(182, 27);
            this.labelNoPortWarn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNoPortWarn.Name = "labelNoPortWarn";
            this.labelNoPortWarn.Size = new System.Drawing.Size(118, 24);
            this.labelNoPortWarn.TabIndex = 4;
            this.labelNoPortWarn.Text = "No Port !";
            // 
            // buttonToBilibili
            // 
            this.buttonToBilibili.Location = new System.Drawing.Point(3, 60);
            this.buttonToBilibili.Name = "buttonToBilibili";
            this.buttonToBilibili.Size = new System.Drawing.Size(264, 47);
            this.buttonToBilibili.TabIndex = 6;
            this.buttonToBilibili.Text = "Contact author >";
            this.buttonToBilibili.UseVisualStyleBackColor = true;
            // 
            // buttonToGithub
            // 
            this.buttonToGithub.Location = new System.Drawing.Point(3, 0);
            this.buttonToGithub.Name = "buttonToGithub";
            this.buttonToGithub.Size = new System.Drawing.Size(264, 45);
            this.buttonToGithub.TabIndex = 7;
            this.buttonToGithub.Text = "Browse in github >";
            this.buttonToGithub.UseVisualStyleBackColor = true;
            // 
            // labelPortBtnInfo
            // 
            this.labelPortBtnInfo.AutoSize = true;
            this.labelPortBtnInfo.Location = new System.Drawing.Point(98, 62);
            this.labelPortBtnInfo.Name = "labelPortBtnInfo";
            this.labelPortBtnInfo.Size = new System.Drawing.Size(430, 24);
            this.labelPortBtnInfo.TabIndex = 8;
            this.labelPortBtnInfo.Text = "Click the button to shift the state";
            // 
            // panelLanguage
            // 
            this.panelLanguage.Controls.Add(this.labelReToEffCN);
            this.panelLanguage.Controls.Add(this.labelReToEffEN);
            this.panelLanguage.Controls.Add(this.radioButtonCN);
            this.panelLanguage.Controls.Add(this.radioButtonEN);
            this.panelLanguage.Controls.Add(this.labelLanguage);
            this.panelLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLanguage.Location = new System.Drawing.Point(0, 0);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(1136, 125);
            this.panelLanguage.TabIndex = 9;
            // 
            // panelPort
            // 
            this.panelPort.Controls.Add(this.labelPortName);
            this.panelPort.Controls.Add(this.comboBoxPort);
            this.panelPort.Controls.Add(this.labelPortBtnInfo);
            this.panelPort.Controls.Add(this.buttonPortOpenClose);
            this.panelPort.Controls.Add(this.labelNoPortWarn);
            this.panelPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPort.Location = new System.Drawing.Point(0, 125);
            this.panelPort.Name = "panelPort";
            this.panelPort.Size = new System.Drawing.Size(1136, 125);
            this.panelPort.TabIndex = 10;
            // 
            // panelMore
            // 
            this.panelMore.Controls.Add(this.buttonToGithub);
            this.panelMore.Controls.Add(this.buttonToBilibili);
            this.panelMore.Location = new System.Drawing.Point(270, 518);
            this.panelMore.Name = "panelMore";
            this.panelMore.Size = new System.Drawing.Size(441, 138);
            this.panelMore.TabIndex = 11;
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(61, 40);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(190, 24);
            this.labelLanguage.TabIndex = 0;
            this.labelLanguage.Text = "Language/语言 :";
            // 
            // radioButtonEN
            // 
            this.radioButtonEN.AutoSize = true;
            this.radioButtonEN.Location = new System.Drawing.Point(295, 21);
            this.radioButtonEN.Name = "radioButtonEN";
            this.radioButtonEN.Size = new System.Drawing.Size(125, 28);
            this.radioButtonEN.TabIndex = 1;
            this.radioButtonEN.TabStop = true;
            this.radioButtonEN.Text = "English";
            this.radioButtonEN.UseVisualStyleBackColor = true;
            this.radioButtonEN.CheckedChanged += new System.EventHandler(this.radioButtonEN_CheckedChanged);
            // 
            // radioButtonCN
            // 
            this.radioButtonCN.AutoSize = true;
            this.radioButtonCN.Location = new System.Drawing.Point(295, 62);
            this.radioButtonCN.Name = "radioButtonCN";
            this.radioButtonCN.Size = new System.Drawing.Size(137, 28);
            this.radioButtonCN.TabIndex = 2;
            this.radioButtonCN.TabStop = true;
            this.radioButtonCN.Text = "简体中文";
            this.radioButtonCN.UseVisualStyleBackColor = true;
            this.radioButtonCN.CheckedChanged += new System.EventHandler(this.radioButtonCN_CheckedChanged);
            // 
            // labelReToEffEN
            // 
            this.labelReToEffEN.AutoSize = true;
            this.labelReToEffEN.Location = new System.Drawing.Point(501, 21);
            this.labelReToEffEN.Name = "labelReToEffEN";
            this.labelReToEffEN.Size = new System.Drawing.Size(394, 24);
            this.labelReToEffEN.TabIndex = 3;
            this.labelReToEffEN.Text = "Refresh the page to take effect.";
            // 
            // labelReToEffCN
            // 
            this.labelReToEffCN.AutoSize = true;
            this.labelReToEffCN.Location = new System.Drawing.Point(501, 64);
            this.labelReToEffCN.Name = "labelReToEffCN";
            this.labelReToEffCN.Size = new System.Drawing.Size(226, 24);
            this.labelReToEffCN.TabIndex = 4;
            this.labelReToEffCN.Text = "刷新页面即可生效。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1136, 722);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
            this.panelPort.ResumeLayout(false);
            this.panelPort.PerformLayout();
            this.panelMore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelPortName;
        private System.Windows.Forms.Button buttonPortOpenClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNoPortWarn;
        private System.Windows.Forms.Button buttonToGithub;
        private System.Windows.Forms.Button buttonToBilibili;
        private System.Windows.Forms.Label labelPortBtnInfo;
        private System.Windows.Forms.Panel panelPort;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.Panel panelMore;
        private System.Windows.Forms.RadioButton radioButtonCN;
        private System.Windows.Forms.RadioButton radioButtonEN;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelReToEffCN;
        private System.Windows.Forms.Label labelReToEffEN;
        private System.Windows.Forms.Label label1;
    }
}