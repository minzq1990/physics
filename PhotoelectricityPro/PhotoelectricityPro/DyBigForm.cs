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
    public partial class DyBigForm : Form
    {
        public mainForm mf;
        public DyBigForm(mainForm mf )
        {
            InitializeComponent();
            this.mf = mf;

        }

        private void DyBigForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // 加电压
        private void SyyLableJia_Click(object sender, EventArgs e)
        {

             
            int i = Convert.ToInt32(this.DyLabe.Text) ;
            int k = i + 1;
            if (k >= 100) {
                k = 99;
            }
            if (k < 10)
            {
                this.DyLabe.Text = "000" + k.ToString();
            }
            else {
                this.DyLabe.Text = "00" + k.ToString();
            }

            mf.setMainLabel1(k); 
        }

        private void SyyLableJian_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.DyLabe.Text);
            int k = i - 1;
            if (k <= 0) {
                k = 0;
            }
            if (k < 10)
            {
                this.DyLabe.Text = "000" + k.ToString();
            }
            else
            {
                this.DyLabe.Text = "00" + k.ToString();
            }

            mf.setMainLabel1(k); 
        }
    }
}
