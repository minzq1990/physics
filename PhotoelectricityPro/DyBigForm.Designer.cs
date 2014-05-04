namespace PhotoelectricityPro
{
    partial class DyBigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DyBigForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DyLabe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DyLabelJia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 308);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // DyLabe
            // 
            this.DyLabe.AutoSize = true;
            this.DyLabe.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DyLabe.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DyLabe.ForeColor = System.Drawing.Color.Red;
            this.DyLabe.Location = new System.Drawing.Point(97, 212);
            this.DyLabe.Name = "DyLabe";
            this.DyLabe.Size = new System.Drawing.Size(120, 48);
            this.DyLabe.TabIndex = 1;
            this.DyLabe.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DyLabelJia
            // 
            this.DyLabelJia.AutoSize = true;
            this.DyLabelJia.BackColor = System.Drawing.Color.Silver;
            this.DyLabelJia.Location = new System.Drawing.Point(337, 248);
            this.DyLabelJia.Name = "DyLabelJia";
            this.DyLabelJia.Size = new System.Drawing.Size(11, 12);
            this.DyLabelJia.TabIndex = 2;
            this.DyLabelJia.Text = "+";
            this.DyLabelJia.Click += new System.EventHandler(this.DyLabelJia_Click);
            // 
            // DyBigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 442);
            this.Controls.Add(this.DyLabelJia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DyLabe);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DyBigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电源";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DyLabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DyLabelJia;
    }
}