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
        public int flag = -1; //0：手动模式;1自动模式 ;-1初始化
        public SYY(mainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }


        //点击测量仪大图电压的+号
        private void SyyLableJia_Click(object sender, EventArgs e)
        {
            if (this.mf.modelFlag == -1)
            {
                MessageBox.Show("请先选择实验模式");
                return;
            }
            double u = Convert.ToDouble(this.label1.Text);
            u = u * 1000;
            u = u + 1;
            u = u / 1000;
            this.label1.Text = u.ToString();
            mf.setMainLabel2(u.ToString());
            this.ModifyANum(1);
        }

        //点击测量仪大图电压的-号
        private void SyyLabeJian_Click(object sender, EventArgs e)
        {
            if (this.mf.modelFlag == -1)
            {
                MessageBox.Show("请先选择实验模式");
                return;
            }
            double u = Convert.ToDouble(this.label1.Text);
            u = u * 1000;
            u = u - 1;
            u = u / 1000;
            this.label1.Text = u.ToString();  //试验仪的电压值          
            mf.setMainLabel2(u.ToString()); // 
            this.ModifyANum(0);
        }

        //电流表的示数处理
        private void ModifyANum(int jiaOrJian) {
           // MessageBox.Show(Convert.ToString(this.mf.trueU));
            string isTrueU = (((this.mf.trueU) * 1000 - 5) / 1000).ToString();
            string l2 = "0";
            l2 = this.SyyLabe2.Text;
            double l22 = Convert.ToDouble(l2);
            
            if (l22 != 0)
            {
                l22 = l22 * 1000;
            }
            else {

                this.label1.Text = isTrueU;
                this.mf.setMainLabel2 (isTrueU); //电压表
                this.mf.setMainLablel3("0.000");
                MessageBox.Show("电流表已经调到零A");
                Button getResult = this.mf.getGetResult();
                getResult.Visible = true;
                return;
            }
            
           // MessageBox.Show(isTrueU);
            if (jiaOrJian == 1) { //按加的按钮调用的该函数  
                l22 = l22 + (l22 / 5);
                if (l22 > 999)
                {
                    l22 = 999;
                }
                l22 = l22 / 1000;
               
                if (isTrueU == this.label1.Text)
                {
                    this.label1.Text = isTrueU;
                    this.SyyLabe2.Text = "0.000";
                    this.mf.setMainLabel2(isTrueU);
                    this.mf.setMainLablel3("0.000");
                }
                else
                {
                    this.SyyLabe2.Text = l22.ToString("f3");
                    this.mf.setMainLablel3(l22.ToString("f3")); 
                }
            }

            if (jiaOrJian == 0) //按加的按钮调用的该函数 
            {    
                l22 = l22 - (l22 / 5);
                if (l22 > 999)
                {
                    l22 = 999;
                }
                l22 = l22 / 1000;

                if (isTrueU == this.label1.Text)
                {
                    this.label1.Text = isTrueU;
                    this.SyyLabe2.Text = "0.000";
                    this.mf.setMainLabel2(isTrueU);
                    this.mf.setMainLablel3("0.000");
                }else{
                    this.SyyLabe2.Text = l22.ToString("f3");
                    this.mf.setMainLablel3(l22.ToString("f3"));
                }
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
     

        public void setDataFromMainForm(string u,string a) {
            this.label1.Text = u;
            this.SyyLabe2.Text = a;
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

        //手动模式
        private void SyyBuShou_Click(object sender, EventArgs e)
        {
            this.flag = 0; //手动模式
            this.mf.setModeFlag(this.flag);
            this.SelecShouAndZiButtonColor(flag);
            this.Close();
        }
        //自动模式
        private void SyyBuZi_Click(object sender, EventArgs e)
        {
            this.flag = 1; //自动模式
            this.mf.setModeFlag(this.flag);
            this.SelecShouAndZiButtonColor(flag); //设置该按钮的颜色
            this.Close();
        }

        //选择手动和自动的 按钮字体的颜色
        private void SelecShouAndZiButtonColor(int flag) {
            if (flag == 0) //手动模式
            {
                this.SyyBuShou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                this.SyyBuZi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                MessageBox.Show("手动模式已选定");
            }
            if (flag == 1) //自动模式
            {
                this.SyyBuShou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                this.SyyBuZi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                MessageBox.Show("自动模式已选定");
            }        
        }

        private void SYY_Load(object sender, EventArgs e)
        {

        }

       


    }
}
