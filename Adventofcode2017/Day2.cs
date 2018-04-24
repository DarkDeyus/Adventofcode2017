using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day2
    {
        public int[,] Tab1;
        public int[][] Tab;
        public int which;
        public Day2(int[][] tab)
        {
            Tab = tab;
            which = 0;
        }
        public Day2(int[,] tab)
        {
            Tab1 = tab;
            which = 1;
        }
        public int checksum()
        {
            int checksum = 0;
            if (which == 0)
            {
                foreach (var tab in Tab)
                {
                    checksum += tab.Max() - tab.Min();
                }
            }
            else
            {
                int min = int.MaxValue;
                int max = int.MinValue;
                for (int i=0; i<Tab1.GetLength(0); i++)
                {
                    for (int j=0; j<Tab1.GetLength(1); j++)
                    {
                        if (Tab1[i, j] < min)
                            min = Tab1[i, j];
                        if (Tab1[i, j] > max)
                            max = Tab1[i, j];
                    }
                    checksum += (max - min);
                    min= int.MaxValue;
                    max = int.MinValue;
                }
            }
            return checksum;
        }

        public int newchecksum()
        {
            int checksum = 0;
            if (which == 0)
            {
                foreach (var tab in Tab)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        for (int j = i + 1; j < tab.Length; j++)
                        {
                            if (tab[i] % tab[j] == 0 || tab[j] % tab[i] == 0)
                            {
                                if (tab[i] > tab[j])
                                    checksum += tab[i] / tab[j];
                                else checksum += tab[j] / tab[i];
                            }
                        }
                    }

                }
            }
            else
            {

                for (int i = 0; i < Tab1.GetLength(0); i++)
                {
                    for (int j = 0; j < Tab1.GetLength(1); j++)
                    {
                        for (int k = j + 1; k < Tab1.GetLength(1); k++)
                        {
                            if (Tab1[i, j] % Tab1[i, k] == 0 || Tab1[i, k] % Tab1[i, j] == 0)
                            {
                                int a = Tab1[i, j];
                                int b = Tab1[i, k];
                                if (Tab1[i, j] > Tab1[i, k])
                                    checksum += Tab1[i, j] / Tab1[i, k];
                                else checksum += Tab1[i, k] / Tab1[i, j];
                            }
                        }
                    }


                }
            }
            return checksum;
        }
    }
   
}
