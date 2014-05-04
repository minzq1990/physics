using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoelectricityPro
{
    public partial class Result : Form
    {
        private mainForm mf;

        public Result()
        {
            InitializeComponent();
        }

        public Result(mainForm mf) {
            this.mf = mf;
            InitializeComponent();
            if(mf.pictureIndex == 1) {
                this.label4.Text = "365";
            }
            else if (mf.pictureIndex == 2) {
                this.label4.Text = "405";
            }
            else if (mf.pictureIndex == 3) {
                this.label4.Text = "436";
            }
            else if (mf.pictureIndex == 4) {
                this.label4.Text = "546";
            }
            else if (mf.pictureIndex == 5) {
                this.label4.Text = "577";
            }
            if(mf.modelFlag == 0) {
                this.label5.Text = "手动测量";
            } else {
                this.label5.Text = "自动测量";
            }
            
            this.label6.Text = mf.trueU.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
