using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberScreenRollingDown
{
    class PrintColumn
    {
        private int _col = 0;
        public int Col
        {
            get { return this._col; }
            set { this._col = value; }
        }

        public PrintColumn(int col)
        {
            this._col = col;
        }
    }
}
