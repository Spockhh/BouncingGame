using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent(); 
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Form1 f1 = new Form1();
           // Form1 f1 = new Form1();
            f1.Show();
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }


    }
}
