using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Starbuy_Desktop;

namespace Starbuy_Desktop
{
    class ReSize
    {
        static int height, width;
        public ReSize(int h, int w)
        {
            height = h;
            width = w;
        }

        public static void pictureCrossBox(PictureBox p)
        {
            MessageBox.Show(height.ToString() + "  " + width.ToString() + " " + p.Height.ToString() + " " + p.Width.ToString());
            int heightOriginal = p.Height;
            int widthOriginal = p.Width;
            p.Height =  p.Height * height / 786;
            p.Width = p.Width * width/1386 ;
            double propWidth = (double)width/1386;
            double propHeight = (double)height/786 ;
            MessageBox.Show(propWidth.ToString());
            MessageBox.Show(p.Location.X.ToString());
            double locationX = p.Location.X * propWidth;// + widthOriginal - p.Width;
            double locationY = p.Location.Y * propHeight;// + heightOriginal - p.Height;
            MessageBox.Show(height.ToString() + " " + locationX.ToString() + "  " + locationY.ToString() + " " + p.Height.ToString() + " " + p.Width.ToString());
            p.Location = new Point((int)locationX,(int)locationY);
            MessageBox.Show(p.Location.X.ToString() + "  " + p.Location.Y.ToString() + " " + p.Height.ToString() + " " + p.Width.ToString()); 
            
        }
    }
}
