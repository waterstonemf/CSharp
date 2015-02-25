using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTower
{
    public class Rod
    {
        private const int DEFAULT_HEIGHT = 20;
        private const int DEFAULT_WIDTH = 20;
        private const ConsoleColor DEFAULT_COLOR = ConsoleColor.Yellow;
        public int Index { get; set; }
        public string Description { get; set; }
        public ConsoleColor Color { get; set; }
        public int BaseX { get; set; }
        public int BaseY { get; set; }
       
        private int _width = 0;
        //horizental character for printing rod/disk
        private const string H_CHAR = "-";
        //vertical character for printing rod/disk
        private const string V_CHAR = "|";

        public int Width
        {
            get
            {
                if (this._width <= 0)
                {
                    this._width = DEFAULT_WIDTH;
                }
                return this._width;
            }
            set
            {
                if (value > 0)
                {
                    this._width = value;
                }
            }
        }

        private int _height = 0;
        public int Height
        {
            get
            {
                if (this._height <= 0)
                {
                    this._height = DEFAULT_HEIGHT;
                }
                return this._height;
            }

            set
            {
                if (value > 0)
                {
                    this._height = value;
                }
            }
        }

        public Stack<Disk> Disks { get; set; }

        public Rod(int index, string desc)
        {
            this.Index = index;
            this.Description = desc;
            this.Disks = new Stack<Disk>();
        }

        public void SetSize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void PutDisk(Disk disk)
        {
            foreach (Disk d in this.Disks)
            {
                if (d.Index <= disk.Index)
                {
                    throw new ArgumentException(string.Format("Wrong Action: trying to put disk {0} above existing smaller{1}",disk.Index,d.Index));
                }
            }
            PrintDisk(disk);
            this.Disks.Push(disk);

        }

        private void PrintDisk(Disk disk)
        {
            PrintUtil.ForgoundColor = ConsoleColor.White;

            int left = BaseX - disk.Width / 2;
            int top = BaseY - 1;

            foreach (Disk d in this.Disks)
            {
                top -= (d.Height);
            }

            PrintUtil.Print("[" + disk.Index.ToString(), left, top);
            left = BaseX + disk.Width / 2;
            PrintUtil.Print("]", left, top);
        }


        private void PrintDiskRectangle(Disk disk)
        {
            PrintUtil.ForgoundColor = ConsoleColor.White;

            int left = BaseX - disk.Width / 2;
            int top = BaseY - 1;

            foreach (Disk d in this.Disks)
            {
                top -= d.Height - 1;
            }

            //bottom-left part
            for (
                int i = 0; i < disk.Width / 2; i++)
            {
                PrintUtil.Print("-", left, top);
                left += 1;
            }

            left++;

            //bottom-right part
            for (int i = 0; i < disk.Width / 2; i++)
            {
                
                PrintUtil.Print("-", left, top);
                left += 1;
            }

            //left line
            top -= 1;
            left = BaseX - disk.Width / 2;
            PrintUtil.Print(V_CHAR, left, top);

            //right line
            left = BaseX + disk.Width / 2;
            PrintUtil.Print(V_CHAR, left, top);


            top -= 1;
            left = BaseX - disk.Width / 2;
            //top-left part
            for (int i = 0; i < disk.Width / 2; i++)
            {
                PrintUtil.Print(H_CHAR, left, top);
                left += 1;
            }

            left++;

            //bottom-right part
            for (int i = 0; i < disk.Width / 2; i++)
            {

                PrintUtil.Print(H_CHAR, left, top);
                left += 1;
            }

        }

        public void Print(int baseX, int baseY)
        {
            this.BaseX = baseX;
            this.BaseY = baseY;

            PrintUtil.ForgoundColor = ConsoleColor.Yellow;

            for (int i = 0; i < Width; i++)
            {
                PrintUtil.Print( H_CHAR, baseX - Width / 2 +i, baseY);
            }

            for (int i = 1; i <= Height; i++)
            {
                PrintUtil.Print(V_CHAR, baseX, baseY - i);
            }

        }

    }
}
