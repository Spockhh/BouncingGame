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
    

    class gamecontrol
    {

       
        int[] d = new int[] { 0, 0, 0, 0 };
        public gamecontrol( string IMAGEFILE,int x,int y,int z,int n)
        {

            Image img;

            FileStream fs;


            fs = new FileStream(IMAGEFILE, FileMode.Open, FileAccess.Read);

            img = Bitmap.FromStream(fs);

            fs.Close(); d[0] = x;d[1] = y;d[2] = z;d[3] = n;
            //f1.pictureBox3.Image = img;

        }

        #region 图片旋转函数


        /// <summary>  

        /// 以逆时针为方向对图像进行旋转  

        /// </summary>  

        /// <param name="b">位图流</param>  

        /// <param name="angle">旋转角度[0,360](前台给的)</param>  

        /// <returns></returns>  

        public Image RotateImg(Image b, int angle)
        {

            angle = angle % 360;


            //弧度转换  

            double radian = angle * Math.PI / 180.0;

            double cos = Math.Cos(radian);

            double sin = Math.Sin(radian);


            //原图的宽和高  

            int w = b.Width;

            int h = b.Height;

            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));

            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));


            //目标位图  

            Bitmap dsImage = new Bitmap(W, H);

            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(dsImage);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


            //计算偏移量  

            Point Offset = new Point((W - w) / 2, (H - h) / 2);


            //构造图像显示区域：让图像的中心与窗口的中心点一致  

            Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);

            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);


            g.TranslateTransform(center.X, center.Y);

            g.RotateTransform(360 - angle);


            //恢复图像在水平和垂直方向的平移  

            g.TranslateTransform(-center.X, -center.Y);

            g.DrawImage(b, rect);


            //重至绘图的所有变换  

            g.ResetTransform();


            g.Save();

            g.Dispose();

            //保存旋转后的图片  

            b.Dispose();

           // dsImage.Save("FocusPoint.png", System.Drawing.Imaging.ImageFormat.Jpeg);

            return dsImage;

        }


        public Image RotateImg(string filename, int angle)
        {

            return RotateImg(GetSourceImg(filename), angle);

        }


        public Image GetSourceImg(string filename)
        {

            Image img;



            img = Bitmap.FromFile(filename);


            return img;

        }
        public int[] broad(Panel p1,int angle)
        {
            
            double radian = angle * Math.PI / 180.0;

            double cos = Math.Cos(radian);

            double sin = Math.Sin(radian);
            int y1= (int)(( p1.Height / 2) -(p1.Width/2)*sin);
            int x1=(int)((p1.Width)-(p1.Width/2-(p1.Width/2)*cos));
            int y2= (int)(( p1.Height / 2) +(p1.Width/2)*sin);
            int x2=(int)(p1.Width/2-(p1.Width/2)*cos);
            Graphics g2; 
            //this.Show();
            g2 = p1.CreateGraphics(); g2.Clear(Color.White);
            Pen p2 = new Pen(Color.Red, 6); //声明一个画笔
            g2.DrawLine(p2, x1,y1,x2,y2);
            d[0] = y1;
            d[1] = x1; 
            d[2] = y2;
            d[3] = x2;
            return d;
          
        }

    }
}
        #endregion 图片旋转函数 


    
    
