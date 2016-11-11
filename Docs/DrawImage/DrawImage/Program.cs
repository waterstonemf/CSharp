//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Image i = Image.FromFile("meng.png");
            Font f = new Font(new FontFamily("Times New Roman"), 20, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);
            SizeF size = MeasureString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"), f);



            Bitmap b = ResizeImage(i, Math.Max((int)Math.Round(size.Width),i.Width), (int)Math.Round(size.Height) + i.Height + 15);
            string newImageName = DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + ".png";
            b.Save(newImageName);

            Console.WriteLine("Done");
            Console.Read();
        }


        public static SizeF MeasureString(string s , Font f)
        {
            var temp = new Bitmap(1, 1);
            SizeF size = new SizeF();
            using (var g = Graphics.FromImage(temp))
            {
               size =  g.MeasureString(s, f);
            }

            return size;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Font f = new Font(new FontFamily("Times New Roman"), 20, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var g = Graphics.FromImage(destImage))
            {
                g.Clear(Color.White);


                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                   // g.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                   g.DrawImageUnscaled(image, 0, 0);
                }
            }

            using (var g = Graphics.FromImage(destImage))
            {
                string s = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
                
                g.DrawString(s, f, new SolidBrush(Color.Red), 0f, image.Height + 10 );
            }


            return destImage;
        }
    }
}
