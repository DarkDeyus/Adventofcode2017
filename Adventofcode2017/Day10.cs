using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day10
    {
        int[] numberlist;
        int size;
        public Day10(int max_number)
        {
            size = max_number;
            numberlist= new int[max_number+1];
            for (int i = 0; i <= max_number; i++)
                numberlist[i] = i;
        }

        public int KnotHash(string instructions) 
        {
            int[] list = new int[size + 1];
            numberlist.CopyTo(list, 0);

            int position = 0;
            int skip_size = 0;
            int ammount = 0;
            string[] operations = instructions.Split(',');

            foreach(string operation in operations)
            {
                ammount = int.Parse(operation);

                for (int i = 0; i < ammount / 2; i++) //swap main
                {
                    int temp = list[(position + i)%(size+1)];
                    list[(position + i) % (size + 1)] = list[(position + ammount - i - 1) % (size + 1)];
                    list[(position + ammount - i - 1) % (size + 1)] = temp;

                }

                position += ammount + skip_size;
                position = position % (size+1);

                skip_size++;

                //for (int i = 0; i <= size; i++)
                //    Console.Write(list[i] + " ");
                //Console.WriteLine();

                //Console.WriteLine("My position is : " + position);
            }

            return list[0] * list[1];
        }

        public string KnotHashHex(string instructions)
        {
            int[] list = new int[size + 1];
            numberlist.CopyTo(list, 0);

            int position = 0;
            int skip_size = 0;
            int length;

            char[] temporal = instructions.ToCharArray();
            length = temporal.Length;
            int[] operation = new int[length + 5];

            for (int i = 0; i < length; i++)
            {
                operation[i] = (int)temporal[i];
            }

            //append this to the end of the given sequence
            operation[length] = 17;
            operation[length + 1] = 31;
            operation[length + 2] = 73;
            operation[length + 3] = 47;
            operation[length + 4] = 23;

            for (int j = 0; j < 64; j++)
            {
                foreach (int value in operation)
                {
                    for (int i = 0; i < value / 2; i++) //swap main
                    {
                        int temp = list[(position + i) % (size + 1)];
                        list[(position + i) % (size + 1)] = list[(position + value - i - 1) % (size + 1)];
                        list[(position + value - i - 1) % (size + 1)] = temp;

                    }

                    position += (value + skip_size);
                    position = position % (size + 1);
                    skip_size++;
                }
            }           

            //sparse hash
            int[] sparse = new int[16];
            for (int i = 0; i < 16; i++)
            {
                int value = list[i*16];
                for (int j = 1; j < 16; j++)
                {
                    value = value ^ list[i*16 + j];
                }
                sparse[i] = value;
            }

            //to hash
            string hash = string.Empty;
            for (int i = 0; i < 16; i++)
            {
                string dec = sparse[i].ToString("x2");
                hash = hash + dec;
            }
            return hash;
        }

    }
}
