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

namespace WindowsFormsApplication1
{
    class we1
    {
        int Flag = 0; 

        int[,] R1 = { { 0, 0 }, { 0, 0 } }; double[,] R2 = { { 0, 0 }, { 0, 0 } };
        int x, y; int guan;
        float k, d; double kv, kc,kr, bc, bx, by; public int jieshu;
        Panel panel1;
        Panel panel2;
        PictureBox  pp1;
        PictureBox pp2;
        PictureBox pp3;
        PictureBox pp4;
        public we1(int g)
        {
            guan = g;
        }
        public void map_load(Panel p1,Panel p2, PictureBox pb1,  PictureBox pb2,  PictureBox pb3, PictureBox pb4 )
        {
            panel1 = p1; panel2 = p2;
            pp1 = pb1; pp2 = pb2;
            pp3 = pb3; pp4 = pb4;
        }

        public void launch(int a, int c, Form f1, int dri, float xie)          //-1
        {
            int i = f1.ClientRectangle.Height;
            int n = f1.ClientRectangle.Width;
            d = f1.ClientRectangle.Height;
            k = xie;
            x = a;
            y = c;
            ///volecity(v);
            while (true)
            {
                objectd(x, y);
                target(x, y);
                if (jieshu == 1 | jieshu == 2)
                {
                     
                    break;
                }
                if (Flag == 0 && dri == 0)
                {
                    x++;
                    y = (int)(k * x + d);
                    ARecoder(x, y);
                }
                if (Flag == 1 && dri == 0)
                {
                    x--;
                    y = (int)(k * x + d);
                    ARecoder(x, y);
                }

                if (dri == 1)
                {
                    y--;
                }
                if (dri == -1)
                {
                    x++;
                }
                Frame_bounce(x, y, f1);

                Pen p = Pens.Black;//声明一个画笔
                Brush b = new SolidBrush(Color.Black);
                Graphics g;
                g = f1.CreateGraphics();


                Rectangle r = new Rectangle(x, y, 10, 10);
                broadob(f1);
                g.DrawEllipse(p, r);
                g.FillEllipse(b, r);

                System.Threading.Thread.Sleep(6);
                g.Clear(Color.White);



            }
            if (jieshu == 1&&guan==0)
            {
                f1.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }

            if (jieshu == 2&&guan==0)
            {
                f1.Hide();
                Form3 f3 = new Form3(1, 1);
                f3.ShowDialog();
            }
            if (jieshu == 1&& guan==1)
            {
                f1.Hide(); //MessageBox.Show("s");
                Form3 f3 = new Form3(1,1,2);
                f3.ShowDialog();

            }
            if (jieshu == 2&&guan==1)
            {
                f1.Hide();
                Form3 f3 = new Form3(1);
                f3.ShowDialog();
            }


        }
        public void volecity()
        {
            Form2 f2 = new Form2();
            // f2.Show();
            // v = f2.chuandi();
            //f2.Close()
        }
        public void ARecoder(int x, int y)
        {
            R1[0, 0] = R1[1, 0];
            R1[0, 1] = R1[1, 1];
            R1[1, 0] = x;
            R1[1, 1] = y;
        }
        public void BRecoder(int x, int y, int z, int n)
        {
            R2[0, 0] = x;
            R2[0, 1] = y;
            R2[1, 0] = z;
            R2[1, 1] = n;
        }
        public void Frame_bounce(int x, int y, Form f1)
        {
            //int[] a = new int[2];
            int i = f1.ClientRectangle.Height;
            int n = f1.ClientRectangle.Width;
            if (i <= y)
            {
                if (R1[1, 0] > R1[0, 0])
                {
                    Flag = 0;
                    k = -(R1[1, 1] - R1[0, 1]) / (R1[1, 0] - R1[0, 0]);
                    d = R1[1, 1] - k * R1[1, 0];
                    //MessageBox.Show("point");
                }
                else
                {
                    Flag = 1;
                    k = -(R1[1, 1] - R1[0, 1]) / (R1[1, 0] - R1[0, 0]);
                    d = R1[1, 1] - k * R1[1, 0];
                    //MessageBox.Show("point");
                }

            }
            if (n <= x)
            {
                if (R1[1, 1] < R1[0, 1])
                {
                    Flag = 1;
                    k = -(R1[1, 1] - R1[0, 1]) / (R1[1, 0] - R1[0, 0]);
                    d = R1[1, 1] - k * R1[1, 0];
                }
                else
                {
                    //MessageBox.Show("y");
                    Flag = 1;
                    k = -(R1[1, 1] - R1[0, 1]) / (R1[1, 0] - R1[0, 0]);
                    d = R1[1, 1] - k * R1[1, 0];
                }

            }
            if (y <= 0)
            {
                if (R1[0, 0] < R1[1, 0])
                {
                    Flag = 0;
                    k = -(R1[1, 1] - R1[0, 1]) / (R1[1, 0] - R1[0, 0]);
                    d = R1[1, 1] - k * R1[1, 0];
                }
                else
                {
                    Flag = 1;
                    k = -(R1[1, 1] - R1[0, 1]) / (R1[1, 0] - R1[0, 0]);
                    d = R1[1, 1] - k * R1[1, 0];
                }

            }
            if (x <= 0)
            {
                if (R1[1, 1] > R1[0, 1])
                {
                    Flag = 0;
                    k = -(R1[1, 1] - R1[0, 1]) / (R1[1, 0] - R1[0, 0]);
                    d = R1[1, 1] - k * R1[1, 0];
                }
                else
                {
                    //MessageBox.Show("y");
                    Flag = 0;
                    k = -(R1[1, 1] - R1[0, 1]) / (R1[1, 0] - R1[0, 0]);
                    d = R1[1, 1] - k * R1[1, 0];
                }

            }
            if (x == n && i == y)
            {
                Flag = 2;
            }

            if (x == n && y == 0)
            {
                Flag = 3;
            }
            if (x == 0 && y == 0)
            {
                Flag = 1;
            }
            if (x == 0 && i == y)
            {
                Flag = 0;
            }

        }


        public void objectd(int x, int y)
        {
            if (pp1.Location.X < x && x < pp1.Location.X + pp1.Width && pp1.Location.Y< y && y < pp1.Location.Y + pp1.Height)
            {
                if (MessageBox.Show("失败", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    jieshu = 2;

                }
            }

            if (pp2.Location.X < x && x < pp2.Location.X + pp2.Width && pp2.Location.Y < y && y < pp2.Location.Y + pp2.Height)
            {
                if (MessageBox.Show("失败", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    jieshu = 2;

                }
            }
            if (pp3.Location.X < x && x < pp3.Location.X + pp3.Width && pp3.Location.Y < y && y < pp3.Location.Y + pp3.Height)
            {
              
                if (MessageBox.Show("失败", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    jieshu = 2;

                }
            }
        }
        public void target(int x, int y)
        {
            if (pp4.Location.X < x && x < pp4.Location.X + pp4.Width && pp4.Location.Y < y && y < pp4.Location.Y + pp4.Height && guan == 1)
            {
                //   MessageBox.Show("success");  //jieshu = 1;
                if (MessageBox.Show("通关！", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    jieshu = 1;

                }

            }

            if (pp4.Location.X < x && x < pp4.Location.X + pp4.Width && pp4.Location.Y < y && y < pp4.Location.Y + pp4.Height && guan==0)
            {
                //   MessageBox.Show("success");  //jieshu = 1;
                if (MessageBox.Show("成功！", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    jieshu = 1;

                }

            }
        }
        public void broadob(Form f2)
        {

            if (panel1.Location.X < x && x < panel1.Location.X + panel1.Width && panel1.Location.Y < y && y < panel1.Location.Y + panel1.Height)
            {
                float px = x - panel1.Location.X;
                float py = y - panel1.Location.Y; double u = ((py - R2[1, 1]) / (R2[0, 1] - R2[1, 1])) - ((px - R2[1, 0]) / (R2[0, 0] - R2[1, 0]));
                if (u > 0)
                {

                    broad_bounce();


                    //MessageBox.Show("ye");
                }
                else
                {

                    Graphics g1 = panel1.CreateGraphics();
                    Rectangle r1 = new Rectangle((int)px, (int)py, 10, 10);
                    Pen p1 = Pens.Black;//声明一个画笔
                    Brush b1 = new SolidBrush(Color.Black);
                    g1.DrawEllipse(p1, r1);
                    g1.FillEllipse(b1, r1);
                    System.Threading.Thread.Sleep(3);
                    g1.Clear(Color.White);
                }
                Graphics g6;
                g6= panel1.CreateGraphics();
                Pen p6 = new Pen(Color.Red, 6); //声明一个画笔
                g6.DrawLine(p6, (int)R2[0, 0], (int)R2[0, 1], (int)R2[1, 0], (int)R2[1, 1]);
               

            }
            if (panel2.Location.X < x && x < panel2.Location.X + panel2.Width && panel2.Location.Y < y && y < panel2.Location.Y + panel2.Height && guan==1)
            {
                // MessageBox.Show("y");
                float px = x- panel2.Location.X;
                float py = y - panel2.Location.Y; double u = ((py - R2[1, 1]) / (R2[0, 1] - R2[1, 1])) - ((px - R2[1, 0]) / (R2[0, 0] - R2[1, 0]));
                if (u >0)
                {

                    broad_bounce();


                    //MessageBox.Show("ye");
                }
                else
                {
                    //MessageBox.Show("y");
                    Graphics g2 = panel2.CreateGraphics();
                    Rectangle r2 = new Rectangle((int)px, (int)py, 10, 10);
                    Pen p2 = Pens.Black;//声明一个画笔
                    Brush b2 = new SolidBrush(Color.Black);
                    g2.DrawEllipse(p2, r2);
                    g2.FillEllipse(b2, r2);
                    System.Threading.Thread.Sleep(3);
                    g2.Clear(Color.White);
                }
                Graphics g9;
                g9 = panel2.CreateGraphics();
                Pen p9 = new Pen(Color.Red, 6); //声明一个画笔
                g9.DrawLine(p9, (int)R2[0, 0], (int)R2[0, 1], (int)R2[1, 0], (int)R2[1, 1]);
               
            }
            
               

        }
        public void broad_bounce()
        {
            kv = -(R2[0, 0] - R2[1, 0]) / (R2[0, 1] - R2[1, 1]);
            kc = (R2[0, 1] - R2[1, 1]) / (R2[0, 0] - R2[1, 0]);
            kr=  R1[0, 0] - R1[1, 0];
            if(kr==0)
            {
                x = R1[0, 0];
                y = R1[0, 1];
                Flag =Math.Abs(Flag-1);
            }
            else
            {
            bc = R1[1, 1] - kv * R1[1, 0];
            bx = (kv * R1[0, 0] + 2 * bc + kc * R1[0, 0] - 2 * R1[0, 1]) / (kc - kv);
            by = kc * (bx - R1[0, 0]) + R1[0, 1];
            x = (int)bx;
            y = (int)by;
            if ((bx - R1[1, 0]) != 0)
                k = (float)((by - R1[1, 1]) / (bx - R1[1, 0]));
            d = (float)by - k * (float)bx;
            Flag = 0;
            }
        }

    }

}
