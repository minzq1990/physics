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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MainLable1 = new System.Windows.Forms.Label();
            this.MainLabel2 = new System.Windows.Forms.Label();
            this.MainLabel3 = new System.Windows.Forms.Label();
            this.getResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLab
            // 
            this.mainLab.AutoSize = true;
            this.mainLab.Font = new System.Drawing.Font("宋体", 12F);
            this.mainLab.Location = new System.Drawing.Point(11, 9);
            this.mainLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLab.Name = "mainLab";
            this.mainLab.Size = new System.Drawing.Size(48, 16);
            this.mainLab.TabIndex = 0;
            this.mainLab.Text = "时间:";
            // 
            // mainTim
            // 
            this.mainTim.Tick += new System.EventHandler(this.mainTim_Tick);
            // 
            // mainButtStart
            // 
            this.mainButtStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainButtStart.Location = new System.Drawing.Point(595, 6);
            this.mainButtStart.Margin = new System.Windows.Forms.Padding(2);
            this.mainButtStart.Name = "mainButtStart";
            this.mainButtStart.Size = new System.Drawing.Size(75, 23);
            this.mainButtStart.TabIndex = 1;
            this.mainButtStart.Text = "开始";
            this.mainButtStart.UseVisualStyleBackColor = true;
            this.mainButtStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainButtEnd
            // 
            this.mainButtEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainButtEnd.Location = new System.Drawing.Point(674, 6);
            this.mainButtEnd.Margin = new System.Windows.Forms.Padding(2);
            this.mainButtEnd.Name = "mainButtEnd";
            this.mainButtEnd.Size = new System.Drawing.Size(75, 23);
            this.mainButtEnd.TabIndex = 1;
            this.mainButtEnd.Text = "结束";
            this.mainButtEnd.UseVisualStyleBackColor = true;
            this.mainButtEnd.Click += new System.EventHandler(this.mainButtEnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 10);
            this.label1.TabIndex = 2;
            // 
            // mainButtIntro
            // 
            this.mainButtIntro.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainButtIntro.Location = new System.Drawing.Point(491, 6);
            this.mainButtIntro.Margin = new System.Windows.Forms.Padding(2);
            this.mainButtIntro.Name = "mainButtIntro";
            this.mainButtIntro.Size = new System.Drawing.Size(100, 23);
            this.mainButtIntro.TabIndex = 3;
            this.mainButtIntro.Text = "试验说明";
            this.mainButtIntro.UseVisualStyleBackColor = true;
            this.mainButtIntro.Click += new System.EventHandler(this.mainButtIntro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 341);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 88);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhotoelectricityPro.Properties.Resources.缩小的套装;
            this.pictureBox2.Location = new System.Drawing.Point(255, 56);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 202);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 322);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 147);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // MainLable1
            // 
            this.MainLable1.AutoSize = true;
            this.MainLable1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainLable1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainLable1.ForeColor = System.Drawing.Color.Red;
            this.MainLable1.Location = new System.Drawing.Point(48, 381);
            this.MainLable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainLable1.Name = "MainLable1";
            this.MainLable1.Size = new System.Drawing.Size(58, 21);
            this.MainLable1.TabIndex = 7;
            this.MainLable1.Text = "0000";
            // 
            // MainLabel2
            // 
            this.MainLabel2.AutoSize = true;
            this.MainLabel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainLabel2.ForeColor = System.Drawing.Color.Red;
            this.MainLabel2.Location = new System.Drawing.Point(575, 381);
            this.MainLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainLabel2.Name = "MainLabel2";
            this.MainLabel2.Size = new System.Drawing.Size(53, 16);
            this.MainLabel2.TabIndex = 8;
            this.MainLabel2.Text = "0.000";
            this.MainLabel2.Click += new System.EventHandler(this.MainLabel2_Click);
            // 
            // MainLabel3
            // 
            this.MainLabel3.AutoSize = true;
            this.MainLabel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainLabel3.ForeColor = System.Drawing.Color.Red;
            this.MainLabel3.Location = new System.Drawing.Point(647, 381);
            this.MainLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainLabel3.Name = "MainLabel3";
            this.MainLabel3.Size = new System.Drawing.Size(53, 16);
            this.MainLabel3.TabIndex = 9;
            this.MainLabel3.Text = "0.000";
            // 
            // getResult
            // 
            this.getResult.Font = new System.Drawing.Font("宋体", 12F);
            this.getResult.Location = new System.Drawing.Point(360, 6);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(126, 23);
            this.getResult.TabIndex = 10;
            this.getResult.Text = "显示测试结果";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Visible = false;
            this.getResult.Click += new System.EventHandler(this.getResult_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 10);
            this.label2.TabIndex = 11;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 10);
            this.label3.TabIndex = 12;
            this.label3.Text = "+";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 10);
            this.label4.TabIndex = 13;
            this.label4.Text = "-";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 10);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 10);
            this.label6.TabIndex = 15;
            this.label6.Text = "+";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 10);
            this.label7.TabIndex = 16;
            this.label7.Text = "-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 10);
            this.label8.TabIndex = 17;
            this.label8.Text = "+";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(630, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 10);
            this.label9.TabIndex = 18;
            this.label9.Text = "-";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(773, 480);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.MainLabel3);
            this.Controls.Add(this.MainLabel2);
            this.Controls.Add(this.MainLable1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainButtIntro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainButtEnd);
            this.Controls.Add(this.mainButtStart);
            this.Controls.Add(this.mainLab);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "光电效应试验";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label MainLable1;
        private System.Windows.Forms.Label MainLabel2;
        private System.Windows.Forms.Label MainLabel3;
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}