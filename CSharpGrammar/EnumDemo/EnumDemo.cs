/*
 * 1) since Enum value is int in the internal, so of course it could execute bit operation ,like &, | ~
 * 2)the value after | is still an int value , so it may equal to one Enum item or not equal to any item
 * 3)you do not need [Flags]Attribute to do bit operation,Note that [Flags] by itself doesn't change this at all - all it does is enable a nice representation by the .ToString() method:
 * 4)It's recommended to use bit shift operation to assign intial value for enum items
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class EnumDemo
    {
        #region normal
        public enum Colors
        {
            Yellow,
            Green,
            Red,
            Blue
        }

        public void ShowColors()
        {
            Console.WriteLine("For normal enum declartion................");
            Colors myFavoriate = Colors.Green | Colors.Blue;
            Console.WriteLine(@"
public enum Colors
{
    Yellow,
    Green,
    Red,
    Blue
}

Colors myFavoriate = Colors.Green | Colors.Blue;
");
            if(myFavoriate == Colors.Green)
            {
                Console.WriteLine("equals Green");
            }else if(myFavoriate == Colors.Blue)
            {
                Console.WriteLine("equals Blue");
            }else
            {
                Console.WriteLine("who knows");
            }
            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n",myFavoriate.ToString(),(int)myFavoriate));
        }

        #endregion

        #region with initial value 1
        public enum Colors2
        {
            Yellow = 1,
            Green,
            Red,
            Blue
        }

        public void ShowColors2()
        {
            Console.WriteLine("For enum declartion with initial values 1................");
            Colors2 myFavoriate = Colors2.Green | Colors2.Blue;
            Console.WriteLine(@"
public enum Colors2
{
    Yellow = 1,
    Green,
    Red,
    Blue
}

Colors2 myFavoriate = Colors2.Green | Colors2.Blue;
");

            if (myFavoriate == Colors2.Green)
            {
                Console.WriteLine("equals Green");
            }
            else if (myFavoriate == Colors2.Blue)
            {
                Console.WriteLine("equals Blue");
            }
            else
            {
                Console.WriteLine("who knows");
            }
            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n", myFavoriate.ToString(), (int)myFavoriate));
        }
        #endregion

        #region with initial value 0
        public enum Colors3
        {
            Yellow = 0,
            Green,
            Red,
            Blue
        }

        public void ShowColors3()
        {
            Console.WriteLine("For enum declartion with initial values 0................");
            Colors3 myFavoriate = Colors3.Yellow | Colors3.Blue;
            Console.WriteLine(@"
public enum Colors3
{
    Yellow = 0,
    Green,
    Red,
    Blue
}

Colors3 myFavoriate = Colors3.Yellow | Colors3.Blue;
");
            if (myFavoriate == Colors3.Yellow)
            {
                Console.WriteLine("equals Yellow");
            }
            else if (myFavoriate == Colors3.Blue)
            {
                Console.WriteLine("equals Blue");
            }
            else
            {
                Console.WriteLine("who knows");
            }
            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n", myFavoriate.ToString(), (int)myFavoriate));
        }
        #endregion

        #region Values set as 1, 2, 4, 8
        public enum Colors4
        {
            Yellow = 1,
            Green = 2,
            Red = 4,
            Blue = 8
        }

        public void ShowColors4()
        {
            Console.WriteLine("For enum Values set as 1, 2, 4, 8................");
            Colors4 myFavoriate = Colors4.Yellow | Colors4.Blue;
            Console.WriteLine(@"
public enum Colors4
{
    Yellow = 1,
    Green = 2,
    Red = 4,
    Blue = 8
}

Colors4 myFavoriate = Colors4.Yellow | Colors4.Blue;
");
            if (myFavoriate == Colors4.Yellow)
            {
                Console.WriteLine("equals Yellow");
            }
            else if (myFavoriate == Colors4.Blue)
            {
                Console.WriteLine("equals Blue");
            }
            else
            {
                Console.WriteLine("who knows");
            }
            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n", myFavoriate.ToString(), (int)myFavoriate));
        }
        #endregion

        #region Values set as 1, 2, 4, 8 with FlagsAttribute
        [Flags]
        public enum Colors5
        {
            Yellow = 1,
            Green = 2,
            Red = 4,
            Blue = 8
        }

        public void ShowColors5()
        {
            Console.WriteLine("For enum Values set as 1, 2, 4, 8 with FlagsAttribute................");
            Colors5 myFavoriate = Colors5.Yellow | Colors5.Blue;
            Console.WriteLine(@"
public enum Colors5
{
    Yellow = 1,
    Green = 2,
    Red = 4,
    Blue = 8
}

Colors5 myFavoriate = Colors5.Yellow | Colors5.Blue;
");
            if (myFavoriate == Colors5.Yellow)
            {
                Console.WriteLine("equals Yellow");
            }
            else if (myFavoriate == Colors5.Blue)
            {
                Console.WriteLine("equals Blue");
            }
            else
            {
                Console.WriteLine("who knows");
            }
            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n", myFavoriate.ToString(), (int)myFavoriate));
        }
        #endregion

        #region Values checking
        [Flags]
        public enum Colors6
        {
            Yellow = 1,
            Green = 2,
            Red = 4,
            Blue = 8
        }

        public void ShowColors6()
        {
            Console.WriteLine("values checking................");
            Colors6 myFavoriate = Colors6.Yellow | Colors6.Blue;

            Console.WriteLine(@"
public enum Colors6
{
    Yellow = 1,
    Green = 2,
    Red = 4,
    Blue = 8
}

Colors6 myFavoriate = Colors6.Yellow | Colors6.Blue;
");

            if (myFavoriate == Colors6.Yellow)
            {
                Console.WriteLine("equals Yellow");
            }
            else if (myFavoriate == Colors6.Blue)
            {
                Console.WriteLine("equals Blue");
            }
            else
            {
                Console.WriteLine("who knows");
            }

            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n", myFavoriate.ToString(), (int)myFavoriate));

            if((myFavoriate & Colors6.Yellow) == Colors6.Yellow)
            {
                Console.WriteLine("Contains Yellow");
            }

            if ((myFavoriate & Colors6.Blue) == Colors6.Blue)
            {
                Console.WriteLine("Contains Blue");
            }

            if ((myFavoriate & Colors6.Red) == Colors6.Red)
            {
                Console.WriteLine("Contains Red");
            }else
            {
                Console.WriteLine("No Red");
            }

            Console.WriteLine("Check value by has Flag, supported in .NET 4 and later,");

            if (myFavoriate.HasFlag(Colors6.Yellow))
            {
                Console.WriteLine("Contains Yellow");
            }

            if (myFavoriate.HasFlag(Colors6.Blue))
            {
                Console.WriteLine("Contains Blue");
            }

            if (myFavoriate.HasFlag(Colors6.Red))
            {
                Console.WriteLine("Contains Red");
            }
            else
            {
                Console.WriteLine("No Red");
            }     
        }

        #endregion


        #region remove flag
        [Flags]
        public enum Colors7
        {
            Yellow = 1,
            Green = 2,
            Red = 4,
            Blue = 8
        }

        public void ShowColors7()
        {
            Console.WriteLine("remove flag................");
            Colors7 myFavoriate = Colors7.Yellow | Colors7.Blue;
            myFavoriate = myFavoriate & (~Colors7.Blue);
            Console.WriteLine(@"
public enum Colors7
{
    Yellow = 1,
    Green = 2,
    Red = 4,
    Blue = 8
}

Colors7 myFavoriate = Colors7.Yellow | Colors7.Blue;
myFavoriate = myFavoriate & (~Colors7.Blue);
");
            if (myFavoriate == Colors7.Yellow)
            {
                Console.WriteLine("equals Yellow");
            }
            else if (myFavoriate == Colors7.Blue)
            {
                Console.WriteLine("equals Blue");
            }
            else
            {
                Console.WriteLine("who knows");
            }
            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n", myFavoriate.ToString(), (int)myFavoriate));
        }
        #endregion

        #region assgin value by bit shift <<
        [Flags]
        public enum Colors8
        {
            Yellow = 1 << 0,
            Green = 1 << 1,
            Red = 1 << 2,
            Blue = 1 << 3
        }

        public void ShowColors8()
        {
            Console.WriteLine("assgin value by bit shift <<................");
            Colors8 myFavoriate = Colors8.Yellow | Colors8.Blue;
            myFavoriate = myFavoriate & (~Colors8.Blue);
            Console.WriteLine(@"
public enum Colors8
{
    Yellow = 1 << 0,
    Green = 1 << 1,
    Red = 1 << 2,
    Blue = 1 << 3
}

Colors8 myFavoriate = Colors8.Yellow | Colors8.Blue;
myFavoriate = myFavoriate & (~Colors8.Blue);
");
            if (myFavoriate == Colors8.Yellow)
            {
                Console.WriteLine("equals Yellow");
            }
            else if (myFavoriate == Colors8.Blue)
            {
                Console.WriteLine("equals Blue");
            }
            else
            {
                Console.WriteLine("who knows");
            }
            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n", myFavoriate.ToString(), (int)myFavoriate));
        }
        #endregion

        #region assgin value by bit shift << way 2: recommended
        [Flags]
        public enum Colors9
        {
            Yellow = 1 << 0,
            Green = Yellow << 1,
            Red = Green << 1,
            Blue = Red << 1
        }

        public void ShowColors9()
        {
            Console.WriteLine("assgin value by bit shift << way 2: recommended................");
            Colors9 myFavoriate = Colors9.Yellow | Colors9.Blue;
            myFavoriate = myFavoriate & (~Colors9.Yellow);
            Console.WriteLine(@"
public enum Colors9
{
    Yellow = 1 << 0,
    Green = Yellow << 1,
    Red = Green << 1,
    Blue = Red << 1
}

Colors9 myFavoriate = Colors9.Yellow | Colors9.Blue;
 myFavoriate = myFavoriate & (~Colors9.Yellow);
");
            if (myFavoriate == Colors9.Yellow)
            {
                Console.WriteLine("equals Yellow");
            }
            else if (myFavoriate == Colors9.Blue)
            {
                Console.WriteLine("equals Blue");
            }
            else
            {
                Console.WriteLine("who knows");
            }
            Console.WriteLine(string.Format("ToString:{0}, value:{1}\n\n", myFavoriate.ToString(), (int)myFavoriate));
        }
        #endregion
    }
}
