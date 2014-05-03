using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PhotoelectricityPro
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homeForm hf = new homeForm();
            Application.Run(hf); //运行窗体一
            //如果窗体一 this.Close() 被关闭 则运行窗体二 ，记主窗体
            if (hf.DialogResult.ToString() == DialogResult.None.ToString()) 
            {
                mainForm mf = new mainForm();
                Application.Run(mf);
            }
            
             
        }
    }
}
