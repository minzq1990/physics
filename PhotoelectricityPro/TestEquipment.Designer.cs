namespace PhotoelectricityPro
{
    partial class TestEquipment
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
            this.pictureBox_one = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox_two = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox_three = new System.Windows.Forms.PictureBox();
            this.pictureBox_four = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_four)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_one
            // 
            this.pictureBox_one.Image = global::PhotoelectricityPro.Properties.Resources.放大的套装;
            this.pictureBox_one.Location = new System.Drawing.Point(12, 22);
            this.pictureBox_one.Name = "pictureBox_one";
            this.pictureBox_one.Size = new System.Drawing.Size(460, 328);
            this.pictureBox_one.TabIndex = 0;
            this.pictureBox_one.TabStop = false;
            this.pictureBox_one.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "撤去光电管光罩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "放入光阑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 20);
            this.button3.TabIndex = 3;
            this.button3.Text = "撤去汞灯灯罩";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox_two
            // 
            this.pictureBox_two.BackColor = System.Drawing.Color.White;
            this.pictureBox_two.Image = global::PhotoelectricityPro.Properties.Resources.光电管入口遮光罩;
            this.pictureBox_two.Location = new System.Drawing.Point(335, 145);
            this.pictureBox_two.Name = "pictureBox_two";
            this.pictureBox_two.Size = new System.Drawing.Size(10, 15);
            this.pictureBox_two.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_two.TabIndex = 4;
            this.pictureBox_two.TabStop = false;
            this.pictureBox_two.Click += new System.EventHandler(this.pictureBox_two_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 20);
            this.button4.TabIndex = 5;
            this.button4.Text = "选择滤光片";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox_three
            // 
            this.pictureBox_three.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_three.Image = global::PhotoelectricityPro.Properties.Resources.汞灯灯罩;
            this.pictureBox_three.Location = new System.Drawing.Point(133, 108);
            this.pictureBox_three.Name = "pictureBox_three";
            this.pictureBox_three.Size = new System.Drawing.Size(24, 31);
            this.pictureBox_three.TabIndex = 6;
            this.pictureBox_three.TabStop = false;
            this.pictureBox_three.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pictureBox_four
            // 
            this.pictureBox_four.BackColor = System.Drawing.Color.White;
            this.pictureBox_four.Image = global::PhotoelectricityPro.Properties.Resources.光电管入口遮光罩;
            this.pictureBox_four.Location = new System.Drawing.Point(268, 145);
            this.pictureBox_four.Name = "pictureBox_four";
            this.pictureBox_four.Size = new System.Drawing.Size(11, 15);
            this.pictureBox_four.TabIndex = 7;
            this.pictureBox_four.TabStop = false;
            this.pictureBox_four.Click += new System.EventHandler(this.pictureBox_four_Click);
            // 
            // TestEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pictureBox_four);
            this.Controls.Add(this.pictureBox_three);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox_two);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_one);
            this.Name = "TestEquipment";
            this.Text = "测试仪器";
            this.Load += new System.EventHandler(this.TestEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_four)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_one;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox_two;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox_three;
        private System.Windows.Forms.PictureBox pictureBox_four;
    }
}