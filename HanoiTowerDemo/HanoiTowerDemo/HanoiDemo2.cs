using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerDemo
{
    public class HanoiDemo2
    {

        public const char TOWER_A = 'A';
        public const char TOWER_B = 'B';
        public const char TOWER_C = 'C';

        public readonly int DISK_COUNT = 6;

        //disks on tower A
        private Stack<int> _da = null;
        //disks on tower B
        private Stack<int> _db = null;
        //disks on tower C
        private Stack<int> _dc = null;

        private int _step = 0;


        public HanoiDemo2() : this(3)
        {
        }

        public HanoiDemo2(int n)
        {
            this.DISK_COUNT = n;
            this._da = new Stack<int>(DISK_COUNT);
            this._db = new Stack<int>(DISK_COUNT);
            this._dc = new Stack<int>(DISK_COUNT);


            for (int i = DISK_COUNT; i > 0; i--)
            {
                this._da.Push(i);
            }
        }


        public void Demo()
        {
            // Console.WriteLine("Initial State:");
            Console.WriteLine("Hanoi tower demo. Press any key to start...");
            PrintAllTowers();

            Console.CursorVisible = false;
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hanoi tower demo. In Progress...");
            PrintAllTowers();

            Hanoi(TOWER_A, TOWER_C, DISK_COUNT);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Hanoi tower demo. Done! total {this._step} steps      ");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts">start tower</param>
        /// <param name="te">end tower</param>
        /// <param name="n">the count of disks to move from start tower to end tower</param>
        public void Hanoi(char ts, char te, int n)
        {
            if (n == 1)
            {
                Move(ts, te);
                return;
            }

            char tt = GetTempTower(ts, te);

            //Stack<int> startDisk = GetTowerDisks(ts);
            //Hanoi(ts, tt, statDisk.Count);
            Hanoi(ts, tt, n - 1);
            Move(ts, te);
            //Stack<int> tempDisk = GetTowerDisks(tt);
            Hanoi(tt, te, n - 1);
        }


        public char GetTempTower(char ts, char te)
        {
            char tempTower = '0';
            switch (ts)
            {
                case TOWER_A:
                    switch (te)
                    {
                        case TOWER_B:
                            tempTower = TOWER_C;
                            break;

                        default:
                            tempTower = TOWER_B;
                            break;
                    }
                    break;

                case TOWER_B:
                    switch (te)
                    {
                        case TOWER_A:
                            tempTower = TOWER_C;
                            break;

                        default:
                            tempTower = TOWER_A;
                            break;
                    }

                    break;

                case TOWER_C:
                    switch (te)
                    {
                        case TOWER_A:
                            tempTower = TOWER_B;
                            break;

                        default:
                            tempTower = TOWER_A;
                            break;
                    }

                    break;

                default:
                    new ArgumentException($"Not Supported Tower: {ts}");
                    break;
            }

            return tempTower;
        }

        public void Move(char ts, char te)
        {
            Stack<int> startDisks = GetTowerDisks(ts);
            Stack<int> endDisks = GetTowerDisks(te);

            int xs = GetTowerX(ts);
            int xe = GetTowerX(te);

            int disk = startDisks.Peek();

            MarkNumber(xs, DISK_COUNT + 3, ts, -1, ConsoleColor.Green);

            System.Threading.Thread.Sleep(200);

            this._step++;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Hanoi tower demo. In Progress...{this._step}");

            disk = startDisks.Pop();
            PrintSingleTower(xs,DISK_COUNT + 3,ts);

            // PrintAllTowers();

            //PrintStep(disk, ts, te,startDisks,endDisks);


            endDisks.Push(disk);
            MarkNumber(xe, DISK_COUNT + 3, te,-1,ConsoleColor.Yellow);
            System.Threading.Thread.Sleep(100);
            PrintSingleTower(xe, DISK_COUNT +3 , te);
            System.Threading.Thread.Sleep(100);



        }

        public Stack<int> GetTowerDisks(char tower)
        {
            Stack<int> disks = null;
            switch (tower)
            {
                case TOWER_A:
                    disks = this._da;
                    break;
                case TOWER_B:
                    disks = this._db;
                    break;
                case TOWER_C:
                    disks = this._dc;
                    break;
                default:
                    throw new ArgumentException($"Not Supported Tower: {tower}");
            }

            return disks;
        }


        public void PrintAllTowers()
        {
            int y = 3;

            PrintSingleTower(4, y + DISK_COUNT, TOWER_A);
            PrintSingleTower(22, y+ DISK_COUNT, TOWER_B);
            PrintSingleTower(40, y+ DISK_COUNT, TOWER_C);

            //Console.ReadLine();

           // System.Threading.Thread.Sleep(2000);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y">the y position to print ---------</param>
        /// <param name="tower"></param>
        public void PrintSingleTower(int x, int y, char tower)
        {
            MarkNumber(x, y, tower, -1, Console.ForegroundColor);
        }


        public void MarkNumber(int x, int y, char tower, int disk, ConsoleColor c )
        {
            //print the --------- firstly(this is a trick here. print --------- firstly, do not need to consider the different disks on each tower)
            Console.SetCursorPosition(x - 4, y);
            Console.WriteLine("---------");

            //print the tower name
            Console.CursorLeft = x;
            Console.WriteLine(tower);

            //reset the cusror top to original position
            Stack<int> disks = GetTowerDisks(tower);
            int yStart = y;

            for (int i = disks.Count; i > 0; i--)
            {
                Console.SetCursorPosition(x, --yStart);

                if(disk != -1 && disk == disks.ElementAt(i - 1))
                {
                    Console.ForegroundColor = c;
                }

                Console.WriteLine(disks.ElementAt(i - 1));

                Console.ResetColor() ;
            }

            for (int i = disks.Count; i < DISK_COUNT; i++)
            {
                Console.SetCursorPosition(x, --yStart);
                Console.WriteLine(" ");
            }
        }



        public int GetTowerX(char tower)
        {
            int x = 0;

            switch(tower)
            {
                case TOWER_A:
                    x = 4;
                    break;

                case TOWER_B:
                    x = 4 + 18;
                    break;

                case TOWER_C:
                    x = 4 + 18 + 18;
                    break;
            }

            return x;
        }
    }
}
