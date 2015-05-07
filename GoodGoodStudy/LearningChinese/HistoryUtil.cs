using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningChinese
{
    public class HistoryUtil
    {
        private static List<int> History = new List<int>();

        private static int CurrentPosition = 0;

        public static void Add(int index)
        {
            if(History.Count >= 10000)
            {
                History.Clear();
            }

            int count = History.Count;
            if(count == 0)
            {
                History.Add(index);
                CurrentPosition = 0;
            }else
            {
                int lastIndex = History.ElementAt(count - 1);
                if(index != lastIndex)
                {
                    History.Add(index);
                    CurrentPosition = History.Count - 1;
                }
            }
        }


        public static int Previous
        {
            get { 
                if(History.Count == 0)
                {
                    return -1;
                }
                else if (History.Count == 1)
                {
                    return History.ElementAt(0);
                    
                }else
                {
                    CurrentPosition--;
                    if(CurrentPosition < 0)
                    {
                        CurrentPosition = History.Count - 1;
                    }
                    return History.ElementAt(CurrentPosition);
                }
            }
        }

        public static int Last
        {
            get
            {
                if (History.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return History.ElementAt(History.Count -1 );
                }
            }
        }

        public static int Count
        {
            get { return History.Count; }
        }
    }
}
