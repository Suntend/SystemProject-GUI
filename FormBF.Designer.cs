
namespace vsGUI
{
    partial class FormBF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBF));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBartending = new System.Windows.Forms.Label();
            this.pictureBoxGIF = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.labelBartending);
            this.panel1.Controls.Add(this.pictureBoxGIF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 361);
            this.panel1.TabIndex = 0;
            // 
            // labelBartending
            // 
            this.labelBartending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBartending.AutoSize = true;
            this.labelBartending.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBartending.Location = new System.Drawing.Point(345, 160);
            this.labelBartending.Name = "labelBartending";
            this.labelBartending.Size = new System.Drawing.Size(202, 35);
            this.labelBartending.TabIndex = 1;
            this.labelBartending.Text = "Bartending . . .";
            // 
            // pictureBoxGIF
            // 
            this.pictureBoxGIF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxGIF.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGIF.Image")));
            this.pictureBoxGIF.Location = new System.Drawing.Point(25, 25);
            this.pictureBoxGIF.Name = "pictureBoxGIF";
            this.pictureBoxGIF.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxGIF.TabIndex = 0;
            this.pictureBoxGIF.TabStop = false;
            // 
            // FormBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 361);
            this.Controls.Add(this.panel1);
            this.Name = "FormBF";
            this.Text = "FormBF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxGIF;
        private System.Windows.Forms.Label labelBartending;
    }
}