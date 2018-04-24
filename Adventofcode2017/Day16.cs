using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Adventofcode2017
{
    class Day16
    {
        int size;
        string[] start; 
        public Day16(int size)
        {
            this.size=size;
            start = new string[size];
            for (int i = 0; i < size; i++)
            {
                start[i] = ((char)('a' + i)).ToString();
            }

        }

        public string Dance(string list)
        {
            string[] permutation = new string[size];
            start.CopyTo(permutation, 0);

            string instruction = File.ReadAllText(@"..\..\" + list);

            string[] instructions = instruction.Split(',');

            foreach (string command in instructions)
            {
                string[] what = command.Remove(0, 1).Split('/');

                switch (command[0])
                {
                    case 's':
                        int index = int.Parse(what[0]);
                        string[] current = new string[size];                       
                        int j = 0;
                        for(int i=size-index; i< size; i++)
                        {
                            current[j] = permutation[i];
                            j++;
                        }
                        for (int i = 0; i < size - index; i++)
                        {
                            current[j] = permutation[i];
                            j++;
                        }
                        permutation = current;

                        break;

                    case 'p':
                        int index0=0;
                        int index1=0;

                        for (int i = 0; i < size; i++)
                        {
                            if (permutation[i] == what[0])
                                index0 = i;

                            if (permutation[i] == what[1])
                                index1 = i;
                        }

                        string tmp = permutation[index1];
                        permutation[index1] = permutation[index0];
                        permutation[index0] = tmp;
                        break;

                    case 'x':
                        string temp = permutation[int.Parse(what[1])];
                        permutation[int.Parse(what[1])] = permutation[int.Parse(what[0])];
                        permutation[int.Parse(what[0])] = temp;
                        break;

                }

            }
            return String.Concat(permutation);
        }

        public string Billiondances(string list)
        {
            Dictionary < string, string[]> dancepositions= new Dictionary<string, string[]>();
            string[] permutation = new string[size];
            start.CopyTo(permutation, 0);

            string instruction = File.ReadAllText(@"..\..\" + list);

            string[] instructions = instruction.Split(',');

            for (int k=0; k<1000000000; k++)
            {
                string copy = permutation.ToString();
                Console.WriteLine("try number {0} ", k);
                if (dancepositions.ContainsKey(copy)) //not enough, find a cycle
                {
                    
                }
                else
                {
                    
                    //Console.WriteLine("try number {0} ", k);
                    foreach (string command in instructions)
                    {
                        string[] what = command.Remove(0, 1).Split('/');

                        switch (command[0])
                        {
                            case 's':
                                int index = int.Parse(what[0]);
                                string[] current = new string[size];
                                int j = 0;
                                for (int i = size - index; i < size; i++)
                                {
                                    current[j] = permutation[i];
                                    j++;
                                }
                                for (int i = 0; i < size - index; i++)
                                {
                                    current[j] = permutation[i];
                                    j++;
                                }
                                permutation = current;

                                break;

                            case 'p':
                                int index0 = 0;
                                int index1 = 0;

                                for (int i = 0; i < size; i++)
                                {
                                    if (permutation[i] == what[0])
                                        index0 = i;

                                    if (permutation[i] == what[1])
                                        index1 = i;
                                }

                                string tmp = permutation[index1];
                                permutation[index1] = permutation[index0];
                                permutation[index0] = tmp;
                                break;

                            case 'x':
                                string temp = permutation[int.Parse(what[1])];
                                permutation[int.Parse(what[1])] = permutation[int.Parse(what[0])];
                                permutation[int.Parse(what[0])] = temp;
                                break;

                        }

                    }
                    dancepositions.Add(copy, permutation);
                }
            }

            return String.Concat(permutation);
        }
    }
}
