
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(85, 55);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPort.TabIndex = 1;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // labelPortName
            // 
            this.labelPortName.AutoSize = true;
            this.labelPortName.Location = new System.Drawing.Point(20, 55);
            this.labelPortName.Name = "labelPortName";
            this.labelPortName.Size = new System.Drawing.Size(71, 12);
            this.labelPortName.TabIndex = 2;
            this.labelPortName.Text = "Port Name :";
            // 
            // buttonPortOpenClose
            // 
            this.buttonPortOpenClose.BackColor = System.Drawing.Color.Red;
            this.buttonPortOpenClose.Location = new System.Drawing.Point(212, 55);
            this.buttonPortOpenClose.Name = "buttonPortOpenClose";
            this.buttonPortOpenClose.Size = new System.Drawing.Size(75, 23);
            this.buttonPortOpenClose.TabIndex = 3;
            this.buttonPortOpenClose.Text = "Closed";
            this.buttonPortOpenClose.UseVisualStyleBackColor = false;
            this.buttonPortOpenClose.Click += new System.EventHandler(this.buttonPortOpenClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNoPortWarn);
            this.panel1.Controls.Add(this.labelPortName);
            this.panel1.Controls.Add(this.buttonPortOpenClose);
            this.panel1.Controls.Add(this.comboBoxPort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 361);
            this.panel1.TabIndex = 4;
            // 
            // labelNoPortWarn
            // 
            this.labelNoPortWarn.AutoSize = true;
            this.labelNoPortWarn.Location = new System.Drawing.Point(86, 55);
            this.labelNoPortWarn.Name = "labelNoPortWarn";
            this.labelNoPortWarn.Size = new System.Drawing.Size(59, 12);
            this.labelNoPortWarn.TabIndex = 4;
            this.labelNoPortWarn.Text = "No Port !";
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelPortName;
        private System.Windows.Forms.Button buttonPortOpenClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNoPortWarn;
    }
}