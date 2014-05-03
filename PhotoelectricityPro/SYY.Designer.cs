namespace PhotoelectricityPro
{
    partial class SYY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SYY));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SyyLabe2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SyyLabeJian = new System.Windows.Forms.Label();
            this.SyyLableJia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 303);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SyyLabe2
            // 
            this.SyyLabe2.AutoSize = true;
            this.SyyLabe2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SyyLabe2.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SyyLabe2.Location = new System.Drawing.Point(346, 233);
            this.SyyLabe2.Name = "SyyLabe2";
            this.SyyLabe2.Size = new System.Drawing.Size(73, 29);
            this.SyyLabe2.TabIndex = 1;
            this.SyyLabe2.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(165, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "0000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SyyLabeJian
            // 
            this.SyyLabeJian.AutoSize = true;
            this.SyyLabeJian.BackColor = System.Drawing.Color.Pink;
            this.SyyLabeJian.Location = new System.Drawing.Point(167, 289);
            this.SyyLabeJian.Name = "SyyLabeJian";
            this.SyyLabeJian.Size = new System.Drawing.Size(13, 17);
            this.SyyLabeJian.TabIndex = 2;
            this.SyyLabeJian.Text = "-";
            this.SyyLabeJian.Click += new System.EventHandler(this.SyyLabeJian_Click);
            // 
            // SyyLableJia
            // 
            this.SyyLableJia.AutoSize = true;
            this.SyyLableJia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SyyLableJia.Location = new System.Drawing.Point(221, 289);
            this.SyyLableJia.Name = "SyyLableJia";
            this.SyyLableJia.Size = new System.Drawing.Size(17, 17);
            this.SyyLableJia.TabIndex = 3;
            this.SyyLableJia.Text = "+";
            this.SyyLableJia.Click += new System.EventHandler(this.SyyLableJia_Click);
            this.SyyLableJia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SyyLableJia_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(425, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(245, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "V";
            // 
            // SYY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(583, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SyyLableJia);
            this.Controls.Add(this.SyyLabeJian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SyyLabe2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SYY";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实验仪";
            this.Load += new System.EventHandler(this.SYY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SyyLabe2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SyyLabeJian;
        private System.Windows.Forms.Label SyyLableJia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}