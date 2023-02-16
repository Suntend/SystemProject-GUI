
namespace vsGUI
{
    partial class FormClassicInfo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClassicInfo2));
            this.labelInfoEN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfoCN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfoEN
            // 
            this.labelInfoEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfoEN.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfoEN.Location = new System.Drawing.Point(196, 24);
            this.labelInfoEN.Name = "labelInfoEN";
            this.labelInfoEN.Size = new System.Drawing.Size(360, 240);
            this.labelInfoEN.TabIndex = 6;
            this.labelInfoEN.Text = resources.GetString("labelInfoEN.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelInfoCN);
            this.panel1.Controls.Add(this.labelInfoEN);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonC1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 361);
            this.panel1.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(496, 289);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 60);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonC1
            // 
            this.buttonC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonC1.FlatAppearance.BorderSize = 0;
            this.buttonC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.buttonC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.buttonC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonC1.Location = new System.Drawing.Point(30, 271);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(160, 30);
            this.buttonC1.TabIndex = 4;
            this.buttonC1.Text = "Blue Hawaii";
            this.buttonC1.UseVisualStyleBackColor = true;
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
            // labelInfoCN
            // 
            this.labelInfoCN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfoCN.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfoCN.Location = new System.Drawing.Point(196, 24);
            this.labelInfoCN.Name = "labelInfoCN";
            this.labelInfoCN.Size = new System.Drawing.Size(360, 240);
            this.labelInfoCN.TabIndex = 7;
            this.labelInfoCN.Text = "       这款鸡尾酒是以朗姆酒为基酒，配以蓝橙力娇酒、椰奶、菠萝汁等辅料制作而成的一款鸡尾酒。\r\n       其中，蓝橙酒代表蓝色的海洋，塞满酒杯中的碎冰象" +
    "征着泛起的浪花，而酒杯里散发的果汁甜味犹如夏威夷的微风细语。\r\n\r\n基酒：朗姆酒（40ml）\r\n配料：菠萝汁（20ml），蓝橙酒（20ml）\r\n\r\n价格：25 " +
    "元人民币";
            // 
            // FormClassicInfo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(568, 361);
            this.Controls.Add(this.panel1);
            this.Name = "FormClassicInfo2";
            this.Text = "FormClassicInfo2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInfoEN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonC1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfoCN;
    }
}