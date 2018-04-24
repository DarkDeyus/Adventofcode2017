using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adventofcode2017
{
    class Day14
    {
        string hashbase;

        public Day14(string input)
        {
            hashbase = input;
        }

        public int Calculatespace()
        {
            int used = 0;
            Day10 hasher = new Day10(255);
            for (int i=0; i<128; i++)
            {
                String hashed = hasher.KnotHashHex(hashbase + "-" + i);
                
                StringBuilder sb = new StringBuilder();
                foreach (char c in hashed.ToCharArray())
                {
                    sb.Append(Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2));
                }
                string binary = sb.ToString();
                sb.Clear();
                foreach(char c in binary)
                {
                    used += c - '0';
                }
            }
            return used;
        }

        public int Numberofregions()
        {
            int regions = 0;
            Day10 hasher = new Day10(255);
            int[,] usage = new int[128,128];
            for (int i = 0; i < 128; i++)
            {
                String hashed = hasher.KnotHashHex(hashbase + "-" + i);
                //Console.WriteLine("{0} contains {1} elements", i, hashed.Length);
                StringBuilder sb = new StringBuilder();
                foreach (char c in hashed.ToCharArray())
                {
                    //Console.WriteLine("{0} contains {1} elements",i,hashed.ToCharArray().Length);
                    sb.Append(Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')); // MUST CONVERT WITH 4 CHARACTERS
                }
                string binary = sb.ToString();                

                for (int j = 0; j < 128; j++)
                {
                    usage[i, j] = binary[j] - '0';
                }
                sb.Clear();              
            } //filing the array

            for (int k = 0; k < 128; k++)
            {
                for (int j = 0; j < 128; j++) 
                    if (usage[k,j]==1)
                    {
                        FindNeighbour(ref usage, k, j);
                        regions++;
                    }
            }

            //for(int a=0; a<128; a++)
            //{
            //    for (int b = 0; b < 128; b++)
            //        Console.Write("{0} ", usage[a, b]);
            //    Console.WriteLine();
            //}
            return regions;
        }

        

        void FindNeighbour(ref int[,] arr,int x, int y)
        {
            if(x>=0 && x<128 && y>=0 && y < 128 && arr[x,y]==1)
            {
                arr[x, y] = 0;
                FindNeighbour(ref arr, x+1, y);
                FindNeighbour(ref arr, x, y+1);
                FindNeighbour(ref arr, x-1, y);
                FindNeighbour(ref arr, x, y-1);
            }
        }
    }
}
