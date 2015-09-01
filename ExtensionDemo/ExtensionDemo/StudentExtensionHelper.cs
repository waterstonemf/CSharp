using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    public static class StudentExtensionHelper
    {
        public static int GetMyScore(this Student stu)
        {
            return stu.Score;
        }
    }
}
