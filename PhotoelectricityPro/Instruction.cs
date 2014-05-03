//说明页面
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PhotoelectricityPro
{
    public partial class instrucForm : Form
    {
        public instrucForm()
        {
            InitializeComponent();
        }

        private void Instruction_Load(object sender, EventArgs e)
        {
            object filepath = System.Windows.Forms.Application.StartupPath + "\\new_2.txt";
            abc(filepath.ToString());
             
        }

        private void abc(string file) {

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        this.richTextBox1.Text += line;
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
         

    }
}
