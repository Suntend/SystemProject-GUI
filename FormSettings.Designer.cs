﻿
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
            this.panelMore = new System.Windows.Forms.Panel();
            this.buttonToOff = new System.Windows.Forms.Button();
            this.buttonToGithub = new System.Windows.Forms.Button();
            this.buttonToBilibili = new System.Windows.Forms.Button();
            this.panelPort = new System.Windows.Forms.Panel();
            this.labelPortBtnInfoEN = new System.Windows.Forms.Label();
            this.labelNoPortWarn = new System.Windows.Forms.Label();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.buttonLanguage = new System.Windows.Forms.Button();
            this.radioButtonCN = new System.Windows.Forms.RadioButton();
            this.radioButtonEN = new System.Windows.Forms.RadioButton();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelPortNameCOM = new System.Windows.Forms.Label();
            this.labelPortBtnInfoCN = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMore.SuspendLayout();
            this.panelPort.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPort.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(180, 27);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 27);
            this.comboBoxPort.TabIndex = 1;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // labelPortName
            // 
            this.labelPortName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPortName.AutoSize = true;
            this.labelPortName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPortName.Location = new System.Drawing.Point(30, 30);
            this.labelPortName.Name = "labelPortName";
            this.labelPortName.Size = new System.Drawing.Size(88, 20);
            this.labelPortName.TabIndex = 2;
            this.labelPortName.Text = "Port Name :";
            // 
            // buttonPortOpenClose
            // 
            this.buttonPortOpenClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPortOpenClose.BackColor = System.Drawing.Color.Red;
            this.buttonPortOpenClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPortOpenClose.Location = new System.Drawing.Point(360, 25);
            this.buttonPortOpenClose.Name = "buttonPortOpenClose";
            this.buttonPortOpenClose.Size = new System.Drawing.Size(120, 30);
            this.buttonPortOpenClose.TabIndex = 3;
            this.buttonPortOpenClose.Text = "Closed";
            this.buttonPortOpenClose.UseVisualStyleBackColor = false;
            this.buttonPortOpenClose.Click += new System.EventHandler(this.buttonPortOpenClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMore);
            this.panel1.Controls.Add(this.panelPort);
            this.panel1.Controls.Add(this.panelLanguage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 361);
            this.panel1.TabIndex = 4;
            // 
            // panelMore
            // 
            this.panelMore.Controls.Add(this.label);
            this.panelMore.Controls.Add(this.buttonToOff);
            this.panelMore.Controls.Add(this.buttonToGithub);
            this.panelMore.Controls.Add(this.buttonToBilibili);
            this.panelMore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMore.Location = new System.Drawing.Point(0, 180);
            this.panelMore.Margin = new System.Windows.Forms.Padding(2);
            this.panelMore.Name = "panelMore";
            this.panelMore.Size = new System.Drawing.Size(568, 120);
            this.panelMore.TabIndex = 11;
            // 
            // buttonToOff
            // 
            this.buttonToOff.Location = new System.Drawing.Point(184, 19);
            this.buttonToOff.Name = "buttonToOff";
            this.buttonToOff.Size = new System.Drawing.Size(193, 23);
            this.buttonToOff.TabIndex = 8;
            this.buttonToOff.Text = "Browse the official website";
            this.buttonToOff.UseVisualStyleBackColor = true;
            // 
            // buttonToGithub
            // 
            this.buttonToGithub.Location = new System.Drawing.Point(184, 57);
            this.buttonToGithub.Margin = new System.Windows.Forms.Padding(2);
            this.buttonToGithub.Name = "buttonToGithub";
            this.buttonToGithub.Size = new System.Drawing.Size(132, 22);
            this.buttonToGithub.TabIndex = 7;
            this.buttonToGithub.Text = "Browse in github >";
            this.buttonToGithub.UseVisualStyleBackColor = true;
            // 
            // buttonToBilibili
            // 
            this.buttonToBilibili.Location = new System.Drawing.Point(184, 93);
            this.buttonToBilibili.Margin = new System.Windows.Forms.Padding(2);
            this.buttonToBilibili.Name = "buttonToBilibili";
            this.buttonToBilibili.Size = new System.Drawing.Size(132, 24);
            this.buttonToBilibili.TabIndex = 6;
            this.buttonToBilibili.Text = "Contact author >";
            this.buttonToBilibili.UseVisualStyleBackColor = true;
            // 
            // panelPort
            // 
            this.panelPort.Controls.Add(this.labelPortBtnInfoCN);
            this.panelPort.Controls.Add(this.labelPortNameCOM);
            this.panelPort.Controls.Add(this.labelPortName);
            this.panelPort.Controls.Add(this.comboBoxPort);
            this.panelPort.Controls.Add(this.labelPortBtnInfoEN);
            this.panelPort.Controls.Add(this.buttonPortOpenClose);
            this.panelPort.Controls.Add(this.labelNoPortWarn);
            this.panelPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPort.Location = new System.Drawing.Point(0, 80);
            this.panelPort.Margin = new System.Windows.Forms.Padding(2);
            this.panelPort.Name = "panelPort";
            this.panelPort.Size = new System.Drawing.Size(568, 100);
            this.panelPort.TabIndex = 10;
            // 
            // labelPortBtnInfoEN
            // 
            this.labelPortBtnInfoEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPortBtnInfoEN.AutoSize = true;
            this.labelPortBtnInfoEN.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPortBtnInfoEN.Location = new System.Drawing.Point(180, 70);
            this.labelPortBtnInfoEN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPortBtnInfoEN.Name = "labelPortBtnInfoEN";
            this.labelPortBtnInfoEN.Size = new System.Drawing.Size(197, 17);
            this.labelPortBtnInfoEN.TabIndex = 8;
            this.labelPortBtnInfoEN.Text = "Click the button to shift the state";
            // 
            // labelNoPortWarn
            // 
            this.labelNoPortWarn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNoPortWarn.AutoSize = true;
            this.labelNoPortWarn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNoPortWarn.Location = new System.Drawing.Point(180, 30);
            this.labelNoPortWarn.Name = "labelNoPortWarn";
            this.labelNoPortWarn.Size = new System.Drawing.Size(69, 20);
            this.labelNoPortWarn.TabIndex = 4;
            this.labelNoPortWarn.Text = "No Port !";
            // 
            // panelLanguage
            // 
            this.panelLanguage.Controls.Add(this.buttonLanguage);
            this.panelLanguage.Controls.Add(this.radioButtonCN);
            this.panelLanguage.Controls.Add(this.radioButtonEN);
            this.panelLanguage.Controls.Add(this.labelLanguage);
            this.panelLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLanguage.Location = new System.Drawing.Point(0, 0);
            this.panelLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Size = new System.Drawing.Size(568, 80);
            this.panelLanguage.TabIndex = 9;
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLanguage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLanguage.Location = new System.Drawing.Point(360, 25);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Size = new System.Drawing.Size(120, 30);
            this.buttonLanguage.TabIndex = 5;
            this.buttonLanguage.Text = "OK / 确认";
            this.buttonLanguage.UseVisualStyleBackColor = true;
            this.buttonLanguage.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // radioButtonCN
            // 
            this.radioButtonCN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCN.AutoSize = true;
            this.radioButtonCN.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonCN.Location = new System.Drawing.Point(270, 28);
            this.radioButtonCN.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCN.Name = "radioButtonCN";
            this.radioButtonCN.Size = new System.Drawing.Size(83, 24);
            this.radioButtonCN.TabIndex = 2;
            this.radioButtonCN.TabStop = true;
            this.radioButtonCN.Text = "简体中文";
            this.radioButtonCN.UseVisualStyleBackColor = true;
            // 
            // radioButtonEN
            // 
            this.radioButtonEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonEN.AutoSize = true;
            this.radioButtonEN.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonEN.Location = new System.Drawing.Point(180, 28);
            this.radioButtonEN.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEN.Name = "radioButtonEN";
            this.radioButtonEN.Size = new System.Drawing.Size(76, 24);
            this.radioButtonEN.TabIndex = 1;
            this.radioButtonEN.TabStop = true;
            this.radioButtonEN.Text = "English";
            this.radioButtonEN.UseVisualStyleBackColor = true;
            // 
            // labelLanguage
            // 
            this.labelLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLanguage.Location = new System.Drawing.Point(30, 30);
            this.labelLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(125, 20);
            this.labelLanguage.TabIndex = 0;
            this.labelLanguage.Text = "Language / 语言 :";
            // 
            // labelPortNameCOM
            // 
            this.labelPortNameCOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPortNameCOM.AutoSize = true;
            this.labelPortNameCOM.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPortNameCOM.Location = new System.Drawing.Point(180, 30);
            this.labelPortNameCOM.Name = "labelPortNameCOM";
            this.labelPortNameCOM.Size = new System.Drawing.Size(50, 20);
            this.labelPortNameCOM.TabIndex = 9;
            this.labelPortNameCOM.Text = "label1";
            // 
            // labelPortBtnInfoCN
            // 
            this.labelPortBtnInfoCN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPortBtnInfoCN.AutoSize = true;
            this.labelPortBtnInfoCN.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPortBtnInfoCN.Location = new System.Drawing.Point(180, 70);
            this.labelPortBtnInfoCN.Name = "labelPortBtnInfoCN";
            this.labelPortBtnInfoCN.Size = new System.Drawing.Size(116, 17);
            this.labelPortBtnInfoCN.TabIndex = 10;
            this.labelPortBtnInfoCN.Text = "点击按钮以切换状态";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 12);
            this.label.TabIndex = 9;
            this.label.Text = "label1";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(568, 361);
            this.Controls.Add(this.panel1);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.panel1.ResumeLayout(false);
            this.panelMore.ResumeLayout(false);
            this.panelMore.PerformLayout();
            this.panelPort.ResumeLayout(false);
            this.panelPort.PerformLayout();
            this.panelLanguage.ResumeLayout(false);
            this.panelLanguage.PerformLayout();
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
        private System.Windows.Forms.Label labelPortBtnInfoEN;
        private System.Windows.Forms.Panel panelPort;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.Panel panelMore;
        private System.Windows.Forms.RadioButton radioButtonCN;
        private System.Windows.Forms.RadioButton radioButtonEN;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Button buttonLanguage;
        private System.Windows.Forms.Button buttonToOff;
        private System.Windows.Forms.Label labelPortNameCOM;
        private System.Windows.Forms.Label labelPortBtnInfoCN;
        private System.Windows.Forms.Label label;
    }
}