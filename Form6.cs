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
     public partial class Form6 : Form
    {
     
        
        int[] d = new int[] { 0, 0, 0, 0 };
        int MyAngle = 0; int MyAngle1 = 0;
        string path;
        public string IMAGEFILE;
        public const string IMAGEFILE1 = "C:/Users/Spock/Documents/Visual Studio 2013/Projects/WindowsFormsApplication1/WindowsFormsApplication1/nnnd.png";
        int Lx;
        int Ly; int k = 0; we1 w; gamecontrol gc; int shunxu=0;
        private Thread th1;
        //  public delegate void UserRequest(object sender, MyEventArgs e);
        //  public event UserRequest OnUserRequest;

         public Form6()
          {   
            InitializeComponent();
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            Form.CheckForIllegalCrossThreadCalls = false;
            d[0] = panel1.Height / 2; d[1] = 0; d[2] = panel1.Height / 2; d[3] = panel1.Width;
            Lx = pictureBox3.Width;
            Ly = this.ClientRectangle.Height - pictureBox3.Height / 2;
            path = Application.StartupPath;
            IMAGEFILE = path + "/dp.jpg";
            Graphics g2;
            this.Show();
            g2 = panel1.CreateGraphics();
            Pen p2 = new Pen(Color.Red, 6); //声明一个画笔
            g2.DrawLine(p2, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
            Graphics g3;
            this.Show();
            g3 = panel2.CreateGraphics();
            Pen p3 = new Pen(Color.Red, 6); //声明一个画笔
            g3.DrawLine(p3, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
  
            this.Show();
 
            w = new we1(1); 
            w.map_load(panel1,panel2,pictureBox2,pictureBox3,pictureBox4,pictureBox5);
            w.BRecoder(d[1], d[0], d[3], d[2]);
            

        }
        public void thOpr1()
        {
          
            w.BRecoder(d[1], d[0], d[3], d[2]);
            w.launch(2 * (pictureBox3.Width) / 5, 600, this, 0, k);


        }


        private void Form6_KeyPress(object sender, KeyPressEventArgs e)
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
                if (e.KeyChar == 'y')
                {

                    MyAngle1 = MyAngle1 + 5;
                    d = gc.broad(this.panel2, MyAngle1);
                    w.BRecoder(d[1], d[0], d[3], d[2]);
                }

                if (e.KeyChar == 'h')
                {
                    MyAngle1 = MyAngle1 - 6;
                    d = gc.broad(this.panel2, MyAngle1);
                    w.BRecoder(d[1], d[0], d[3], d[2]);
                }
            }
     
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (shunxu == 1)
            {
                shunxu = 2;
                th1 = new Thread(new ThreadStart(thOpr1));
                th1.Start();

            }
        }


        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
           
                gc = new gamecontrol(IMAGEFILE, panel1.Height / 2, 0, panel1.Height / 2, panel1.Width);

                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(pictureBox6.Image);
                MyAngle = MyAngle + 10;
                pictureBox6.Image = gc.RotateImg(gc.GetSourceImg(IMAGEFILE), MyAngle);

                double angle = (double)MyAngle;
                k--;
                shunxu = 1;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gc = new gamecontrol(IMAGEFILE, panel1.Height / 2, 0, panel1.Height / 2, panel1.Width);

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(pictureBox6.Image);
            MyAngle = MyAngle - 10;
            pictureBox6.Image = gc.RotateImg(gc.GetSourceImg(IMAGEFILE), MyAngle);

            double angle = (double)MyAngle;
            ;
            k++;
            shunxu = 1;
        }




    }


}


