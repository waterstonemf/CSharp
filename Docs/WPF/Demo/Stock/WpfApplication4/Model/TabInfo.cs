using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4.Model
{
    internal class TabInfo
    {
        private string _code = string.Empty;
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        private bool _loaded = false;
        public bool Loaded
        {
            get { return this._loaded; }
            set { this._loaded = value; }
        }

        public TabInfo(string code) : this(code,false)
        {

        }

        public TabInfo(bool load):this(string.Empty,load)
        {

        }

        public TabInfo(string code, bool load)
        {
            this._code = code;
            this._loaded = load;
        }
    }
}
