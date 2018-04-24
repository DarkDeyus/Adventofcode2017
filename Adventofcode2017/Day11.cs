using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day11
    {
        public string listofsteps;

        public Day11(string file)
        {
            listofsteps = File.ReadAllText(@"..\..\" + file);
        }
        

        public int Return()
        {
            //            \   n    /
            //             \      /
            //           nw +----+  ne
            //             /      \
            //         ---+        +---
            //             \      /
            //          sw  +----+  se
            //             /      \
            //            /   s    \

            int n = 0;
            int ne = 0;
            int se = 0;
            int s = 0;
            int sw = 0;
            int nw = 0;

            string[] steps = listofsteps.Split(',');
            
            foreach(string step in steps)
            {
                switch (step)
                {
                    case ("n"):
                        n++;
                        break;
                    case ("ne"):
                        ne++;
                        break;
                    case ("se"):
                        se++;
                        break;
                    case ("s"):
                        s++;
                        break;
                    case ("sw"):
                        sw++;
                        break;
                    case ("nw"):
                        nw++;
                        break;
                }

            }

            while ((ne > 0) && (sw > 0))
            {
                ne--;
                sw--;
            }

            while ((nw > 0) && (se > 0))
            {
                nw--;
                se--;
            }

            while ((sw > 0) && (se > 0))
            {
                s++;
                sw--;
                se--;
            }

            while ((nw > 0) && (ne > 0))
            {
                n++;
                nw--;
                ne--;
            }

            while ((n > 0) && (s > 0))
            {
                n--;
                s--;
            }

            return  n + ne + se + s + sw + nw;
        }

        public int Findfurtest()
        {
            int x = 0;
            int y = 0;
            int max = 0;

            string[] steps = listofsteps.Split(',');

            foreach (string step in steps)
            {
                switch (step)
                {
                    case ("n"):
                        x = x + 2;
                        break;
                    case ("ne"):
                        x++;
                        y++;
                        break;
                    case ("se"):
                        x++;
                        y--;
                        break;
                    case ("s"):
                        x=x-2;
                        break;
                    case ("sw"):
                        x--;
                        y--;
                        break;
                    case ("nw"):
                        x--;
                        y++;
                        break;
                }
                if (((Math.Abs(x) + Math.Abs(y)) / 2) > max)
                    max = (Math.Abs(x) + Math.Abs(y)) / 2;

            }

            return max;
        }
    }
}
