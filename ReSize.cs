using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Starbuy_Desktop;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Starbuy_Desktop
{
    class ReSize
    {
        static int height, width;
        static double propWidth, propHeight;
        public ReSize(int h, int w)
        {
            height = h;
            width = w;
            propWidth = (double)width / 1386;
            propHeight = (double)height / 786;
        }

        public static Image pictureCrossBox(PictureBox p,Image i)
        {
            //MessageBox.Show(height.ToString() + "  " + width.ToString() + " " + p.Height.ToString() + " " + p.Width.ToString());
            int heightOriginal = p.Height;
            int widthOriginal = p.Width;
            p.Height =  p.Height * height/786;
            p.Width = p.Width * width/1386 ;
            double locationX = p.Location.X * propWidth;// + widthOriginal - p.Width;
            double locationY = p.Location.Y * propHeight;// + heightOriginal - p.Height;
           /* var destRect = new Rectangle((int)locationX, (int)locationY, p.Width, p.Height);
            var destImage = new Bitmap(width, height);

                destImage.SetResolution(1080,1920);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(, destRect, 0, 0, p.Image.Width, p.Image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }

                */
            //MessageBox.Show(height.ToString() + " " + locationX.ToString() + "  " + locationY.ToString() + " " + p.Height.ToString() + " " + p.Width.ToString());
            p.Location = new Point((int)locationX,(int)locationY);
            return destImage;
            //MessageBox.Show(p.Location.X.ToString() + "  " + p.Location.Y.ToString() + " " + p.Height.ToString() + " " + p.Width.ToString()); 
        }

        public static void labelResize(Label l)
        {
            //MessageBox.Show(height.ToString() + "  " + width.ToString() + " " + l.Height.ToString() + " " + l.Width.ToString());
            l.Height = l.Height * height / 786;
            l.Width = l.Width * width / 1386;
            //MessageBox.Show(l.Font.Size.ToString());
            double novaFonte = (l.Font.Size * propWidth);
            String font = l.Font.FontFamily.ToString();
            l.Font = new Font(font, (int)novaFonte);
            //
            //MessageBox.Show(l.Font.Size.ToString());
            double locationX = l.Location.X * propWidth;// + widthOriginal - p.Width;
            double locationY = l.Location.Y * propHeight;// + heightOriginal - p.Height;
            //MessageBox.Show(height.ToString() + " " + locationX.ToString() + "  " + locationY.ToString() + " " + l.Height.ToString() + " " + l.Width.ToString());
            l.Location = new Point((int)locationX, (int)locationY);
           // MessageBox.Show(height.ToString() + " " + locationX.ToString() + "  " + locationY.ToString() + " " + l.Height.ToString() + " " + l.Width.ToString());

        }

        public static void textBoxResize(TextBox t)
        {
            //MessageBox.Show(height.ToString() + "  " + width.ToString() + " " + t.Height.ToString() + " " + t.Width.ToString());
            t.Height = t.Height * height / 786;
            t.Width = t.Width * width / 1386;
            //MessageBox.Show(t.Font.Size.ToString());
            double novaFonte = (t.Font.Size * propWidth);
            String font = t.Font.FontFamily.ToString();
            t.Font = new Font(font, (int)novaFonte);
            //MessageBox.Show(t.Font.Size.ToString());
            double locationX = t.Location.X * propWidth;// + widthOriginal - p.Width;
            double locationY = t.Location.Y * propHeight;// + heightOriginal - p.Height;
            //MessageBox.Show(height.ToString() + " " + locationX.ToString() + "  " + locationY.ToString() + " " + t.Height.ToString() + " " + t.Width.ToString());
            t.Location = new Point((int)locationX, (int)locationY);

        }

        public static void buttonResize(Button b)
        {
            //MessageBox.Show(height.ToString() + "  " + width.ToString() + " " + b.Height.ToString() + " " + b.Width.ToString());
            b.Height = b.Height * height / 786;
            b.Width = b.Width * width / 1386;
            //MessageBox.Show(b.Font.Size.ToString());
            double novaFonte = (b.Font.Size * propWidth);
            String font = b.Font.FontFamily.ToString();
            b.Font = new Font(font, (int)novaFonte);
            //MessageBox.Show(b.Font.Size.ToString());
            double locationX = b.Location.X * propWidth;// + widthOriginal - p.Width;
            double locationY = b.Location.Y * propHeight;// + heightOriginal - p.Height;
            //MessageBox.Show(height.ToString() + " " + locationX.ToString() + "  " + locationY.ToString() + " " + b.Height.ToString() + " " + b.Width.ToString());
            b.Location = new Point((int)locationX, (int)locationY);
        }

        public static void groupBoxResize(GroupBox g)
        {
            g.Height = g.Height * height / 786;
            g.Width = g.Width * width / 1386;
            double locationX = g.Location.X * propWidth;// + widthOriginal - p.Width;
            double locationY = g.Location.Y * propHeight;// + heightOriginal - p.Height;
            //MessageBox.Show(height.ToString() + " " + locationX.ToString() + "  " + locationY.ToString() + " " + g.Height.ToString() + " " + g.Width.ToString());
            g.Location = new Point((int)locationX, (int)locationY);
        }

        public static void maskedResize(MaskedTextBox m)
        {
            m.Height = m.Height * height / 786;
            m.Width = m.Width * width / 1386;
            //MessageBox.Show(t.Font.Size.ToString());
            double novaFonte = (m.Font.Size * propWidth);
            String font = m.Font.FontFamily.ToString();
            m.Font = new Font(font, (int)novaFonte);
            //MessageBox.Show(t.Font.Size.ToString());
            double locationX = m.Location.X * propWidth;// + widthOriginal - p.Width;
            double locationY = m.Location.Y * propHeight;// + heightOriginal - p.Height;
            m.Location = new Point((int)locationX, (int)locationY);
        }

        public static void panelResize(Panel p)
        {
            p.Height = p.Height * height / 786;
            p.Width = p.Width * width / 1386;
            double locationX = p.Location.X * propWidth;// + widthOriginal - p.Width;
            double locationY = p.Location.Y * propHeight;// + heightOriginal - p.Height;
            //MessageBox.Show(height.ToString() + " " + locationX.ToString() + "  " + locationY.ToString() + " " + g.Height.ToString() + " " + g.Width.ToString());
            p.Location = new Point((int)locationX, (int)locationY);
        }
    }
}
