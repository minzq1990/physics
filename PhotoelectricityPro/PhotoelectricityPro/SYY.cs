//试验仪大图
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
    public partial class SYY : Form
    {
        public mainForm mf;
        public static int K = 0;
        public SYY(mainForm mf )
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void SYY_Load(object sender, EventArgs e)
        {

        }

        private void SyyLableJia_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.label1.Text) ;
            int k = i + 1;
            SYY.K = k;
            if (k < 10)
            {
                this.label1.Text = "000" + k.ToString();
            }
            else {
                this.label1.Text = "00" + k.ToString();
            }

            mf.setMainLabel2(k);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SyyLabeJian_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(this.label1.Text);
            int k = i - 1;
            SYY.K = k;
            if (k < 0) {
                k = 0;
            }
            if (k < 10)
            {
                this.label1.Text = "000" + k.ToString();
            }
            else
            {
                this.label1.Text = "00" + k.ToString();
            }
            mf.setMainLabel2(k); //  
            

        }

        private void SyyLableJia_MouseDown(object sender, MouseEventArgs e)
        {
            /*
                System.Threading.Thread.Sleep(1000);
                int i = Convert.ToInt32(this.label1.Text);
                int k = i + 10;
                if (k > 99)
                {
                    k = 99;
                }
               // System.Threading.Thread.Sleep(1000);
                this.label1.Text = "00" + k.ToString();
               // MessageBox.Show(k.ToString());
             
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
