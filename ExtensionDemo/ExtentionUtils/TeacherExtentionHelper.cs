using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionDemo;

namespace ExtentionUtils
{
    public static class TeacherExtentionHelper
    {
        public static string GetMyName(this Teacher t)
        {
            return t.Name;
        }
    }
}
