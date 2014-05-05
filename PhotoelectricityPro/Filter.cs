//选择滤光镜窗体
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
    public partial class Filter : Form
    {
        public int picFlag = -1; //初始化
        public mainForm mf = null; //主窗口
         
        public Filter(mainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

       

        private void Filter_Load(object sender, EventArgs e)
        {

        }
        //pic1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.picFlag = 1;
            MessageBox.Show("滤光片已经选择成功，请调试测试仪");
            this.setPicIndexMainForm(this.picFlag);
            this.Close();
        }
        //pic2
        private void pic2_Click(object sender, EventArgs e)
        {
            this.picFlag = 2;
            MessageBox.Show("滤光片已经选择成功，请调试测试仪");
            this.setPicIndexMainForm(this.picFlag);
        }
        //pic3
        private void pic3_Click(object sender, EventArgs e)
        {
            this.picFlag = 3;
            MessageBox.Show("滤光片已经选择成功，请调试测试仪");
            this.setPicIndexMainForm(this.picFlag);
        }
        //pic4
        private void pic4_Click(object sender, EventArgs e)
        {
            this.picFlag = 4;
            MessageBox.Show("滤光片已经选择成功，请调试测试仪");
            this.setPicIndexMainForm(this.picFlag);
        }
        //pic5
        private void pic5_Click(object sender, EventArgs e)
        {
            this.picFlag = 5;
            MessageBox.Show("滤光片已经选择成功，请调试测试仪");
            this.setPicIndexMainForm(this.picFlag);
        }

        //将选择好滤光片的图片索引传递给主窗口
        private void setPicIndexMainForm(int picIndex) {
            this.mf.getPicIndexMainForm(picIndex);
        }
    }
}
