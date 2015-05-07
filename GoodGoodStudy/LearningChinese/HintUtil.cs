using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LearningChinese
{
    public class HintUtil
    {
        private static string _imgPath = string.Empty;
        public static string ImgPath
        {
            get { return HintUtil._imgPath; }
            set { 
                if(!value.EndsWith("\\"))
                {
                    HintUtil._imgPath = value + "\\";
                }else
                {
                    HintUtil._imgPath = value;
                }
            }
        }

        public static Image LoadImage(string imageName)
        {
            Image img  = null;
            try
            {
                img = Image.FromFile(string.Format("{0}{1}{2}", HintUtil._imgPath, imageName, ".png"));
                if (img != null)
                {
                    return img;
                }
            }
            catch { }

            try
            {
                img = Image.FromFile(string.Format("{0}{1}{2}", HintUtil._imgPath, imageName, ".jpg"));
                if (img != null)
                {
                    return img;
                }
            }
            catch { }

            return GetDefaultImage();
        }

        private static Image GetDefaultImage()
        {
            string text = "没有找到提示图片";
            Font font = new Font("SimSun",20);
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int) textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(Color.White);

            //create a brush for the text
            Brush textBrush = new SolidBrush(Color.Red);

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

}


    }
}
