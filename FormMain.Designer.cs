
namespace vsGUI
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonDesign = new System.Windows.Forms.Button();
            this.buttonClassic = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.labelInfoCN = new System.Windows.Forms.Label();
            this.labelInfoEN = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerListener = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonDesign);
            this.panelMenu.Controls.Add(this.buttonClassic);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 461);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Black;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 386);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(200, 75);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "  Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonDesign
            // 
            this.buttonDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.buttonDesign.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDesign.FlatAppearance.BorderSize = 0;
            this.buttonDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesign.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDesign.ForeColor = System.Drawing.Color.Black;
            this.buttonDesign.Image = ((System.Drawing.Image)(resources.GetObject("buttonDesign.Image")));
            this.buttonDesign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesign.Location = new System.Drawing.Point(0, 150);
            this.buttonDesign.Name = "buttonDesign";
            this.buttonDesign.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonDesign.Size = new System.Drawing.Size(200, 75);
            this.buttonDesign.TabIndex = 2;
            this.buttonDesign.Text = "  Design";
            this.buttonDesign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDesign.UseVisualStyleBackColor = false;
            this.buttonDesign.Click += new System.EventHandler(this.buttonDesign_Click);
            // 
            // buttonClassic
            // 
            this.buttonClassic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.buttonClassic.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClassic.FlatAppearance.BorderSize = 0;
            this.buttonClassic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassic.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClassic.ForeColor = System.Drawing.Color.Black;
            this.buttonClassic.Image = ((System.Drawing.Image)(resources.GetObject("buttonClassic.Image")));
            this.buttonClassic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClassic.Location = new System.Drawing.Point(0, 75);
            this.buttonClassic.Name = "buttonClassic";
            this.buttonClassic.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonClassic.Size = new System.Drawing.Size(200, 75);
            this.buttonClassic.TabIndex = 1;
            this.buttonClassic.Text = "  Classic";
            this.buttonClassic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClassic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClassic.UseVisualStyleBackColor = false;
            this.buttonClassic.Click += new System.EventHandler(this.buttonClassic_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLogo.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelLogo.Location = new System.Drawing.Point(80, 24);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(65, 27);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "ICMS";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(40, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(233)))));
            this.panelTitle.Controls.Add(this.buttonYes);
            this.panelTitle.Controls.Add(this.buttonBack);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(584, 75);
            this.panelTitle.TabIndex = 1;
            // 
            // buttonYes
            // 
            this.buttonYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonYes.FlatAppearance.BorderSize = 0;
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYes.Image = ((System.Drawing.Image)(resources.GetObject("buttonYes.Image")));
            this.buttonYes.Location = new System.Drawing.Point(509, 0);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 75);
            this.buttonYes.TabIndex = 2;
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 75);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(180, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(200, 35);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "W E L O C M E";
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.labelTime);
            this.panelForm.Controls.Add(this.labelInfoCN);
            this.panelForm.Controls.Add(this.labelInfoEN);
            this.panelForm.Controls.Add(this.pictureBox3);
            this.panelForm.Controls.Add(this.pictureBox2);
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 75);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(584, 386);
            this.panelForm.TabIndex = 2;
            // 
            // labelInfoCN
            // 
            this.labelInfoCN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfoCN.Location = new System.Drawing.Point(77, 50);
            this.labelInfoCN.Name = "labelInfoCN";
            this.labelInfoCN.Size = new System.Drawing.Size(444, 195);
            this.labelInfoCN.TabIndex = 4;
            this.labelInfoCN.Text = "智能调酒机器人最初的设计目的是能够根据顾客的口味制作特定的鸡尾酒。既能完美满足不同顾客的口味，又能将调酒师从繁琐的工作中解放出来。\r\n\r\n机器人可以完成给定的鸡尾" +
    "酒任务，准确添加每种成分以确保每次都具有相同的高质量。";
            // 
            // labelInfoEN
            // 
            this.labelInfoEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfoEN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfoEN.Location = new System.Drawing.Point(73, 50);
            this.labelInfoEN.Name = "labelInfoEN";
            this.labelInfoEN.Size = new System.Drawing.Size(440, 195);
            this.labelInfoEN.TabIndex = 3;
            this.labelInfoEN.Text = resources.GetString("labelInfoEN.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(497, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(376, 299);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 75);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(295, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerListener
            // 
            this.timerListener.Enabled = true;
            this.timerListener.Interval = 1000;
            this.timerListener.Tick += new System.EventHandler(this.MainFormListener);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(30, 340);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(18, 20);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "...";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FormMain";
            this.Text = "Intelligent cocktail-making system";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonClassic;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonDesign;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfoEN;
        private System.Windows.Forms.Label labelInfoCN;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Timer timerListener;
        private System.Windows.Forms.Label labelTime;
    }
}

