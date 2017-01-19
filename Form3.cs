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
    public partial class Form3 : Form
    {
        int lockd = 0; Bitmap bitmap; Bitmap bitmap1;
     
        int flag = 0; int re = 0;
        public Form3()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            string p = Application.StartupPath + "/ing.png"; string p1 = Application.StartupPath + "/reka.png";
            bitmap = new Bitmap(p);   
            bitmap1 = new Bitmap(p1);
        }
        public Form3( int t)
        {
            InitializeComponent();
             
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            lockd = 1; flag = 1;
            string p = Application.StartupPath + "/ing.png"; string p1 = Application.StartupPath + "/reka.png";
            bitmap = new Bitmap(p);
            bitmap1 = new Bitmap(p1);
            pictureBox1.Image = bitmap;
        }
        public Form3(int t,int y)
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;

            flag = 1;
            string p = Application.StartupPath + "/ing.png"; string p1 = Application.StartupPath + "/reka.png";
            bitmap = new Bitmap(p);
            bitmap1 = new Bitmap(p1);
           
            pictureBox1.Image = bitmap;
        }
        public Form3(int t, int y,int z)
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;

            flag = 1;
            string p = Application.StartupPath + "/ing.png"; string p1 = Application.StartupPath + "/reka.png";
            bitmap = new Bitmap(p);
            bitmap1 = new Bitmap(p1);
            pictureBox1.Image = bitmap;
            pictureBox2.Image = bitmap1;
            re++;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(lockd==0&&flag==0)
            {
            Form6 f6 = new Form6();
            f6.Show();
            //this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lockd == 0|re==1)
            {
                Form1 f1 = new Form1();

                f1.Show();
              //  this.Hide();
            }
            if (lockd == 1)
            {
                Form6 f6 = new Form6();
                f6.Show();
              //  this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
