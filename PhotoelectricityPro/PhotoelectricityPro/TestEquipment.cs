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
    public partial class TestEquipment : Form
    {
        private Timer time = new Timer();

        public TestEquipment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox_two.Image = null;
            //this.BackgroundImage = Image.FromFile("C:\\Users\\Sky\\Desktop\\pic\\56798c28795f6063cab757d236568b30_副本_副本_副本.jpg");
        }

        private void TestEquipment_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_two_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox_three.Image = null;
        }

        private void pictureBox_four_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            time.Interval = 100;//100毫秒执行一次
            time.Tick += new EventHandler(time_Tick);
            time.Start();//启动定时器
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (this.pictureBox_four.Location.X <= this.pictureBox_two.Location.X - 5)
            {
                this.pictureBox_four.Location = new Point(this.pictureBox_four.Location.X + 1, this.pictureBox_four.Location.Y);
            }
            else {
                this.pictureBox_four.Image = null;
                time.Stop();
            }
            
        }
    }
}
