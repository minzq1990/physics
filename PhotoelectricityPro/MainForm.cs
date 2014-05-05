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
        public SYY syy = null;  //试验仪
        public DyBigForm dy = null; //电源大图
        public Filter fi = null; //滤光片大图
        public double trueU = 0;
        public TestEquipment te = null;//测试仪器大图

        int startX;     //获取鼠标起始点的X坐标
        int startY;    //获取鼠标起始点的Y坐标
        int endX;
        int endY;
        Graphics g;  //定义Graphics对象实例

        public double[,] inputUAndV = new Double[5, 5] {  //截止频率与入射光波频率关系
                                        //波长  频率    截止电压（手动）  截止电压（自动）         电流（自己瞎填写的）
                                        {365,   8.214,  1.824 + 0.005,          1.822 + 0.005,                  0.921},
                                        {405,   7.408,  1.451 + 0.005,          1.451 + 0.005,                  0.875},
                                        {436,   6.879,  1.232 + 0.005,          1.231 + 0.005,                  0.801},
                                        {546,   5.491,  0.682 + 0.005,          0.677 + 0.005,                  0.459},
                                        {577,   5.196,  0.524 + 0.005,          0.520 + 0.005,                  0.314}
                                    };
        public string DYNumber = ""; //电源的示数
        public int modelFlag = -1 ; //实验的模式
        public int pictureIndex = -1;
        public mainForm()
        {
            InitializeComponent();
            syy = new SYY(this); //试验仪的初始化
            dy = new DyBigForm(this); //电源大图的初始化
            fi = new Filter(this); //滤光片大图
            te = new TestEquipment(this); //实验仪器大图
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
            //表的示数显示
            this.setMainLabel2("0.000");
            this.setMainLabel1(0);
            //给变量 电源值赋值
            this.DYNumber = this.MainLable1.Text;
           
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            //g = this.CreateGraphics();               //创建Graphics对象实例
            //Pen p = new Pen(Color.Red, 4);      //设置画笔颜色和宽度
            //g.DrawLine(p, startX, startY, e.X, e.Y);  //绘制直线

        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
           // startX = e.X;       //为变量赋值
           // startY = e.Y;
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
          //  g = this.CreateGraphics();               //创建Graphics对象实例
         //   Pen p = new Pen(Color.Red, 4);      //设置画笔颜色和宽度
          //  g.DrawLine(p, startX, startY, e.X, e.Y);  //绘制直线
   
        }

        //设置主页面 试验仪的电压值
        public void setMainLabel2(string k)
        {
                this.MainLabel2.Text =   k;
        }

        public void setMainLablel3(string k) {
            this.MainLabel3.Text = k;
        }

        public void setMainLabel1(int k)
        {

            if (k < 10)
            {

                this.MainLable1.Text = "000" + k.ToString();
                this.DYNumber = "000" + k.ToString();
            }
            else
            {
                this.MainLable1.Text = "00" + k.ToString();
                this.DYNumber = "00" + k.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.DYNumber) == 0) {
                MessageBox.Show("请先接通电源，建议电源5V");
                return;
            }
            if (Convert.ToInt32(this.DYNumber) < 5 )
            {
                MessageBox.Show("电源应不低于5V");
                return;
            }
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
            if (this.modelFlag == -1) {
                MessageBox.Show("请点击试验仪选择实验模式");
                return;
            }
            te.ShowDialog(); 
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
           // startX = e.X;       //为变量赋值
          //  startY = e.Y;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
           // g = this.CreateGraphics();               //创建Graphics对象实例
          //  Pen p = new Pen(Color.Red, 4);      //设置画笔颜色和宽度
           // g.DrawLine(p, startX, startY, e.X, e.Y);  //绘制直线

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
          //  startX = e.X;       //为变量赋值
           // startY = e.Y;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
           // g = this.CreateGraphics();               //创建Graphics对象实例
           // Pen p = new Pen(Color.Red, 4);      //设置画笔颜色和宽度
           // g.DrawLine(p, startX, startY, e.X, e.Y);  //绘制直线

        }

        //实验模式赋值
        public void setModeFlag(int flag) {
            this.modelFlag = flag;
        }

        //选择完滤光片之后 获得图片的索引值
        public void getPicIndexMainForm(int picIndex) 
        {
            //MessageBox.Show(picIndex.ToString());
            //this.MainLabel2.Text = picIndex.ToString();
            double u = this.inputUAndV[picIndex - 1,2];
            double a = this.inputUAndV[picIndex-1,4];
            this.trueU = u;
            this.pictureIndex = picIndex;
            this.MainLabel2.Text = u.ToString(); //主窗口显示电压值
            this.MainLabel3.Text = a.ToString();//主窗口显示电流
            this.syy.setDataFromMainForm(u.ToString(),a.ToString());
        }

        private void getResult_Click(object sender, EventArgs e)
        {

        }

        private void getResult_Click_1(object sender, EventArgs e)
        {
            Result result = new Result(this);
            //显示结果
            result.ShowDialog();
        }

        public Button getGetResult() {
            return getResult;
        }

        private void MainLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            startX = 141;       //为变量赋值
            startY = 310;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            startX = 96;       //为变量赋值
            startY = 310;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            endX = 240;       //为变量赋值
            endY = 131;
            g = this.CreateGraphics();               //创建Graphics对象实例
            Pen p = new Pen(Color.Red, 4);      //设置画笔颜色和宽度
            g.DrawLine(p, startX, startY, endX, endY);  //绘制直线
        }

        private void label5_Click(object sender, EventArgs e)
        {
            endX = 240;       //为变量赋值
            endY = 177;
            g = this.CreateGraphics();               //创建Graphics对象实例
            Pen p = new Pen(Color.Red, 4);      //设置画笔颜色和宽度
            g.DrawLine(p, startX, startY, endX, endY);  //绘制直线
        }

        private void label6_Click(object sender, EventArgs e)
        {
            startX = 497;       //为变量赋值
            startY = 131;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            endX = 630;       //为变量赋值
            endY = 322;
            g = this.CreateGraphics();               //创建Graphics对象实例
            Pen p = new Pen(Color.Red, 4);      //设置画笔颜色和宽度
            g.DrawLine(p, startX, startY, endX, endY);  //绘制直线
        }

        private void label7_Click(object sender, EventArgs e)
        {
            startX = 499;       //为变量赋值
            startY = 177;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            endX = 558;       //为变量赋值
            endY = 322;
            g = this.CreateGraphics();               //创建Graphics对象实例
            Pen p = new Pen(Color.Red, 4);      //设置画笔颜色和宽度
            g.DrawLine(p, startX, startY, endX, endY);  //绘制直线
        }
    }
}
