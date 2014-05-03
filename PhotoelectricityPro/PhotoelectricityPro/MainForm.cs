//主页面
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //hello lao da
            //hello xiaoqiang
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainTim.Enabled = true;
            mainTim.Interval = 1000;
            this.mainLab.Text = Convert.ToString(DateTime.Now.ToLocalTime());
        }

        private void mainTim_Tick(object sender, EventArgs e)
        {
            this.mainLab.Text = Convert.ToString(DateTime.Now.ToLocalTime());
        }

        private void mainButtEnd_Click(object sender, EventArgs e)
        {
            this.mainTim.Enabled = false;
        }

        private void mainButtIntro_Click(object sender, EventArgs e)
        {
            instrucForm inf = new instrucForm();
            inf.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SYY sy = new SYY();
            sy.Show();
        }
    }
}
