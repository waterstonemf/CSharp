using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerDemo
{
   public class HanoiDemo
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

        private int _step = 1;


        public HanoiDemo() : this(3)
        {
        }

        public HanoiDemo(int n)
        {
            this.DISK_COUNT = n;
            this._da = new Stack<int>(DISK_COUNT);
            this._db = new Stack<int>(DISK_COUNT);
            this._dc = new Stack<int>(DISK_COUNT);


            for(int i = DISK_COUNT; i>0; i--)
            {
                this._da.Push(i);
            }
        }


        public void Demo()
        {
            Console.WriteLine("Initial State:");
            PrintAllTowers();

            Hanoi(TOWER_A, TOWER_C, DISK_COUNT);
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
            Hanoi(ts, tt, n-1);
            Move(ts, te);
            //Stack<int> tempDisk = GetTowerDisks(tt);
            Hanoi(tt, te, n-1);
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
            //could not have this check. for example, first move disk 1, no matter to B or C, this condition does not match
            //if(startDisks.Count != 1)
            //{
            //   throw new Exception($"{startDisks.Count} Disks on Tower {ts}, could not move directly!");
            //}

            int disk = startDisks.Pop();

            PrintStep(disk, ts, te);
            
            Stack<int> endDisks = GetTowerDisks(te);
            endDisks.Push(disk);

            PrintAllTowers();
        }

        public Stack<int> GetTowerDisks(char tower)
        {
            Stack<int> disks = null;
            switch(tower)
            {
                case TOWER_A:
                    disks =  this._da;
                    break;
                case TOWER_B:
                    disks =  this._db;
                    break;
                case TOWER_C:
                    disks = this._dc;
                    break;
                default:
                    throw new ArgumentException($"Not Supported Tower: {tower}");
            }

            return disks;
        }


        public void PrintStep(int disk, char ts, char te)
        {
            if ((Console.CursorTop + DISK_COUNT + 2 + 2) >= Console.BufferHeight)
            {
                Console.Clear();
            }


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{this._step++}]: Move {disk} {ts}-->{te}");
            Console.ResetColor();
            Console.WriteLine();
        }

        public void PrintAllTowers()
        {
            int y = Console.CursorTop;
            int maxDiskCount = Math.Max(Math.Max(this._da.Count, this._db.Count), this._dc.Count);


            if ((y+maxDiskCount + 2) >= Console.BufferHeight)
            {
                Console.Clear();
                y = 0;
            }

            PrintSingleTower(4, y+ maxDiskCount, TOWER_A);
            PrintSingleTower(22, y+ maxDiskCount, TOWER_B);
            PrintSingleTower(40, y+ maxDiskCount, TOWER_C);

            //must have this step to move the cursor down. because PrintSingleTower will move the cursor up: print ------ firstly, and then print nubers up
            Console.CursorTop = y + maxDiskCount + 2;

            //Console.ReadLine();

            System.Threading.Thread.Sleep(2000);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y">the y position to print ---------</param>
        /// <param name="tower"></param>
        public void PrintSingleTower(int x, int y, char tower)
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
                Console.WriteLine(disks.ElementAt(i-1));
            }

            

        }
    }
}
