using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int[] d = new int[] { 0, 0, 0, 0 };
        int MyAngle = 0; int MyAngle1 = 0;
        string path;
        public  string IMAGEFILE;
        public const string IMAGEFILE1 = "C:/Users/Spock/Documents/Visual Studio 2013/Projects/WindowsFormsApplication1/WindowsFormsApplication1/nnnd.png";
        int Lx;
        int Ly; int k = 0; we1 w; gamecontrol gc;int shunxu=0;
       private Thread th1;

        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            Form.CheckForIllegalCrossThreadCalls = false;
             d[0] = panel1.Height / 2; d[1] = 0; d[2] = panel1.Height / 2; d[3] = panel1.Width;
             path=Application.StartupPath;
             IMAGEFILE = path + "/dp.jpg";
             Graphics g2;
             this.Show();
             g2 = panel1.CreateGraphics();
             Pen p2 = new Pen(Color.Red, 6); //声明一个画笔
             g2.DrawLine(p2, 0, panel1.Height / 2, panel1.Width,  panel1.Height / 2);
             w = new we1(0);
             w.map_load(panel1, panel1, pictureBox4, pictureBox1, pictureBox1, pictureBox2);
             w.BRecoder(d[1], d[0], d[3], d[2]); 
      
        }
        public void paint()
        {
            Graphics g2;
            g2 = panel1.CreateGraphics();
            Pen p2 = new Pen(Color.Red, 6); //声明一个画笔
            g2.DrawLine(p2, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
        }
        public void thOpr1()
        {
            
            w.BRecoder(d[1], d[0], d[3], d[2]);
            w.launch(2 * (pictureBox5.Width) / 5, 600, this, 0, k);
        
                 
        }
 

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (shunxu == 2)
           {
            if (e.KeyChar == 'w')  
            {
                MyAngle1 = MyAngle1 + 5;
                d = gc.broad(this.panel1, MyAngle1);
                w.BRecoder(d[1], d[0], d[3], d[2]);
            }

            if (e.KeyChar == 's')
            {
                MyAngle1 = MyAngle1 - 6;
                d = gc.broad(this.panel1, MyAngle1);
                w.BRecoder(d[1], d[0], d[3], d[2]);
            }
           }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (shunxu == 1)
            {shunxu =2;
            th1 = new Thread(new ThreadStart(thOpr1));
            th1.Start();
            }

        }

     

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gc = new gamecontrol(IMAGEFILE, panel1.Height / 2, 0, panel1.Height / 2, panel1.Width);

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(pictureBox1.Image);
            MyAngle = MyAngle + 10;
            pictureBox5.Image = gc.RotateImg(gc.GetSourceImg(IMAGEFILE), MyAngle);

            double angle = (double)MyAngle;
            
            k--;
                  shunxu = 1;
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            gc = new gamecontrol(IMAGEFILE, panel1.Height / 2, 0, panel1.Height / 2, panel1.Width);

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(pictureBox1.Image);
            MyAngle = MyAngle - 10;
            pictureBox5.Image = gc.RotateImg(gc.GetSourceImg(IMAGEFILE), MyAngle);

            double angle = (double)MyAngle;
            ;
            k++;
                  shunxu = 1;
            
        }

        

       
    }

  
}
