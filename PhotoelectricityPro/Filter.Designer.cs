namespace PhotoelectricityPro
{
    partial class Filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter));
            this.filter_365 = new System.Windows.Forms.PictureBox();
            this.filter_405 = new System.Windows.Forms.PictureBox();
            this.filter_436 = new System.Windows.Forms.PictureBox();
            this.filter_546 = new System.Windows.Forms.PictureBox();
            this.filter_577 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.filter_365)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_405)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_436)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_546)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_577)).BeginInit();
            this.SuspendLayout();
            // 
            // filter_365
            // 
            this.filter_365.Image = ((System.Drawing.Image)(resources.GetObject("filter_365.Image")));
            this.filter_365.Location = new System.Drawing.Point(41, 28);
            this.filter_365.Name = "filter_365";
            this.filter_365.Size = new System.Drawing.Size(101, 87);
            this.filter_365.TabIndex = 0;
            this.filter_365.TabStop = false;
            this.filter_365.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // filter_405
            // 
            this.filter_405.Image = ((System.Drawing.Image)(resources.GetObject("filter_405.Image")));
            this.filter_405.Location = new System.Drawing.Point(200, 28);
            this.filter_405.Name = "filter_405";
            this.filter_405.Size = new System.Drawing.Size(100, 87);
            this.filter_405.TabIndex = 1;
            this.filter_405.TabStop = false;
            // 
            // filter_436
            // 
            this.filter_436.Image = ((System.Drawing.Image)(resources.GetObject("filter_436.Image")));
            this.filter_436.Location = new System.Drawing.Point(350, 34);
            this.filter_436.Name = "filter_436";
            this.filter_436.Size = new System.Drawing.Size(100, 81);
            this.filter_436.TabIndex = 2;
            this.filter_436.TabStop = false;
            // 
            // filter_546
            // 
            this.filter_546.Image = ((System.Drawing.Image)(resources.GetObject("filter_546.Image")));
            this.filter_546.Location = new System.Drawing.Point(42, 182);
            this.filter_546.Name = "filter_546";
            this.filter_546.Size = new System.Drawing.Size(100, 89);
            this.filter_546.TabIndex = 3;
            this.filter_546.TabStop = false;
            // 
            // filter_577
            // 
            this.filter_577.Image = ((System.Drawing.Image)(resources.GetObject("filter_577.Image")));
            this.filter_577.Location = new System.Drawing.Point(200, 182);
            this.filter_577.Name = "filter_577";
            this.filter_577.Size = new System.Drawing.Size(100, 89);
            this.filter_577.TabIndex = 4;
            this.filter_577.TabStop = false;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.filter_577);
            this.Controls.Add(this.filter_546);
            this.Controls.Add(this.filter_436);
            this.Controls.Add(this.filter_405);
            this.Controls.Add(this.filter_365);
            this.Name = "Filter";
            this.Text = "滤光片";
            ((System.ComponentModel.ISupportInitialize)(this.filter_365)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_405)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_436)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_546)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter_577)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox filter_365;
        private System.Windows.Forms.PictureBox filter_405;
        private System.Windows.Forms.PictureBox filter_436;
        private System.Windows.Forms.PictureBox filter_546;
        private System.Windows.Forms.PictureBox filter_577;
    }
}