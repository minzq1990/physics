namespace PhotoelectricityPro
{
    partial class homeForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeLab = new System.Windows.Forms.Label();
            this.homeBu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // homeLab
            // 
            resources.ApplyResources(this.homeLab, "homeLab");
            this.homeLab.Name = "homeLab";
            // 
            // homeBu
            // 
            this.homeBu.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.homeBu, "homeBu");
            this.homeBu.Name = "homeBu";
            this.homeBu.UseVisualStyleBackColor = false;
            this.homeBu.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.homeBu);
            this.Controls.Add(this.homeLab);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "homeForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.homeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label homeLab;
        private System.Windows.Forms.Button homeBu;
    }
}

