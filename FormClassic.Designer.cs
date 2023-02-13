
namespace vsGUI
{
    partial class FormClassic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClassic));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(204, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 240);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(378, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 240);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonC3);
            this.panel1.Controls.Add(this.buttonC2);
            this.panel1.Controls.Add(this.buttonC1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 361);
            this.panel1.TabIndex = 3;
            // 
            // buttonC1
            // 
            this.buttonC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonC1.Location = new System.Drawing.Point(30, 271);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(160, 30);
            this.buttonC1.TabIndex = 3;
            this.buttonC1.Text = "Tequila Sunrise";
            this.buttonC1.UseVisualStyleBackColor = true;
            this.buttonC1.Click += new System.EventHandler(this.buttonC1_Click);
            // 
            // buttonC2
            // 
            this.buttonC2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonC2.Location = new System.Drawing.Point(204, 271);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(160, 30);
            this.buttonC2.TabIndex = 4;
            this.buttonC2.Text = "Blue Hawaii";
            this.buttonC2.UseVisualStyleBackColor = true;
            this.buttonC2.Click += new System.EventHandler(this.buttonC2_Click);
            // 
            // buttonC3
            // 
            this.buttonC3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonC3.Location = new System.Drawing.Point(378, 271);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(160, 30);
            this.buttonC3.TabIndex = 5;
            this.buttonC3.Text = "Long Island Iced Tea";
            this.buttonC3.UseVisualStyleBackColor = true;
            this.buttonC3.Click += new System.EventHandler(this.buttonC3_Click);
            // 
            // FormClassic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(568, 361);
            this.Controls.Add(this.panel1);
            this.Name = "FormClassic";
            this.Text = "FormClassic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonC3;
        private System.Windows.Forms.Button buttonC2;
        private System.Windows.Forms.Button buttonC1;
    }
}