using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTower
{
    public class Disk
    {
        private const int BASE_WIDTH = 6;
        private const int BASE_HEIGHT = 1;

        private int _index = 1;
        public int Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        public int Height { get {
            return BASE_HEIGHT;
        } }

        public int Width {
            get {
                return BASE_WIDTH + (this._index - 1) * 2;
            }
        }

        public Disk(int index)
        {
            this._index = index;
        }
    }
}
