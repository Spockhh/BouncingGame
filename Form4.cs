using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            Text();
        }
        public void Text()
        {
            int i = 0;  string fn=  Application.StartupPath +" /guiz.txt";
            using (FileStream fs = new FileStream(fn, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs, Encoding.Default))
                {
                    string text = string.Empty;
                    while (!reader.EndOfStream)
                    {
                        text = reader.ReadLine();
                        richTextBox1.Text = text;


                    }
                }
            }
            return;
        }
          
        
        }
    }

