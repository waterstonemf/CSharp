using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningChinese
{
    public class Dictionary
    {
        public string ImgPath { get; set; }
        public List<string> NormalList { get; set; }
        public List<string> NewList { get; set; }
        public LoadModelType LoadModel { get; set; }  //0: normal, 1: new 
    }


    public enum LoadModelType { Nomal = 0, New = 1}
}
