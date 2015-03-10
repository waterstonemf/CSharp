using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberScreenRollingDown
{
    class PrintInfo
    {
                private int _left = 0;
        public int Left
        {
            get { return this._left; }
            set { this._left = value; }
        }

        private int _top = 0;
        public int Top
        {
            get { return this._top; }
            set { this._top = value; }
        }


        private int _content = 0;
        public int Content
        {
            get{return this._content;}
            set{this._content = value;}
        }

        public PrintInfo(int left,int top, int content)
        {
            this._left = left;
            this._top = top;
            this._content = content;
        }



    }
}
