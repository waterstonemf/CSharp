using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WindowWidth = 150;

                Disk[] disks = { new Disk(1), new Disk(2), new Disk(3), new Disk(4), new Disk(5), new Disk(6), new Disk(7) };

                Rod rod1 = new Rod(1, "I");
                rod1.SetSize(21, 15);
                rod1.Print(20, 30);

                Rod rod2 = new Rod(2, "II");
                rod1.SetSize(21, 15);
                rod1.Print(45, 30);

                Rod rod3 = new Rod(3, "III");
                rod1.SetSize(21, 15);
                rod1.Print(70, 30);


                for (int i = 2; i >= 0; i--)
                {
                    rod1.PutDisk(disks[i]);
                }

                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.BackgroundColor = ConsoleColor.Gray;
                //Console.Write("    -|_");
            }
            catch (Exception e)
            {
                PrintUtil.Fatal(e.ToString());
            }

            Console.Read();
        }
    }
}
