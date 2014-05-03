namespace PhotoelectricityPro
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainLab = new System.Windows.Forms.Label();
            this.mainTim = new System.Windows.Forms.Timer(this.components);
            this.mainButtStart = new System.Windows.Forms.Button();
            this.mainButtEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainButtIntro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLab
            // 
            this.mainLab.AutoSize = true;
            this.mainLab.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainLab.Location = new System.Drawing.Point(609, 9);
            this.mainLab.Name = "mainLab";
            this.mainLab.Size = new System.Drawing.Size(57, 19);
            this.mainLab.TabIndex = 0;
            this.mainLab.Text = "时间:";
            // 
            // mainTim
            // 
            this.mainTim.Tick += new System.EventHandler(this.mainTim_Tick);
            // 
            // mainButtStart
            // 
            this.mainButtStart.Location = new System.Drawing.Point(613, 31);
            this.mainButtStart.Name = "mainButtStart";
            this.mainButtStart.Size = new System.Drawing.Size(45, 23);
            this.mainButtStart.TabIndex = 1;
            this.mainButtStart.Text = "开始";
            this.mainButtStart.UseVisualStyleBackColor = true;
            this.mainButtStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainButtEnd
            // 
            this.mainButtEnd.Location = new System.Drawing.Point(686, 31);
            this.mainButtEnd.Name = "mainButtEnd";
            this.mainButtEnd.Size = new System.Drawing.Size(45, 23);
            this.mainButtEnd.TabIndex = 1;
            this.mainButtEnd.Text = "结束";
            this.mainButtEnd.UseVisualStyleBackColor = true;
            this.mainButtEnd.Click += new System.EventHandler(this.mainButtEnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            // 
            // mainButtIntro
            // 
            this.mainButtIntro.Location = new System.Drawing.Point(516, 31);
            this.mainButtIntro.Name = "mainButtIntro";
            this.mainButtIntro.Size = new System.Drawing.Size(75, 23);
            this.mainButtIntro.TabIndex = 3;
            this.mainButtIntro.Text = "试验说明";
            this.mainButtIntro.UseVisualStyleBackColor = true;
            this.mainButtIntro.Click += new System.EventHandler(this.mainButtIntro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 131);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 156);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(792, 486);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainButtIntro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainButtEnd);
            this.Controls.Add(this.mainButtStart);
            this.Controls.Add(this.mainLab);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "光电效应试验";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLab;
        private System.Windows.Forms.Timer mainTim;
        private System.Windows.Forms.Button mainButtStart;
        private System.Windows.Forms.Button mainButtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainButtIntro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}