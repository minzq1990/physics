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
        private SYY syy = null;
        DyBigForm dy = null;
        public mainForm()
        {
            InitializeComponent();
            syy = new SYY(this);
            dy = new DyBigForm(this);
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
            this.setMainLabel2(0);
            this.setMainLabel1(0);
        }

        //设置主页面 电压值
        public void setMainLabel2(int k)
        {

            if (k < 10)
            {
                this.MainLabel2.Text = "000" + k.ToString();

            }
            else
            {
                this.MainLabel2.Text = "00" + k.ToString();

            }
            //this.MainLabel2.Text = k.ToString();
        }

        public void setMainLabel1(int k)
        {

            if (k < 10)
            {

                this.MainLable1.Text = "000" + k.ToString();

            }
            else
            {
                this.MainLable1.Text = "00" + k.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            syy.ShowDialog(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            dy.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TestEquipment dy = new TestEquipment();
            dy.Show();
        }
    }
}
