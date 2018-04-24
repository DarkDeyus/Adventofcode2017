using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adventofcode2017
{
    class Day12
    {
        Dictionary<int, List<int>> connected = new Dictionary<int, List<int>>();

        public Day12(string file)
        {
            string[] input = File.ReadAllLines(@"..\..\" + file);

            foreach(string pipes in input)
            {
                string line = pipes.Replace(",", "");
                string[] parts = line.Split(' ');
                List<int> connectedTo = new List<int>();

                for (int i = 2; i < parts.Length; i++)
                {
                    connectedTo.Add(int.Parse(parts[i]));
                }
                connected.Add(int.Parse(parts[0]), connectedTo);
            }
        }

        public int Numberofprograms(int number)
        {
            List<int> alreadyAdded = new List<int>();

            Fill(number, ref alreadyAdded);

            return alreadyAdded.Count;


            void Fill(int num, ref List<int> add)
            {
                if(!(add.Contains(num)))
                {
                    add.Add(num);
                    foreach (int what in connected[num])
                    {
                        Fill(what,ref add);
                    }

                }
                return;
            }
        }

        public int Numberofgroups()
        {
            int groups = 0;
            List<int> numbers = new List<int>(connected.Keys);
            List<int> current_group = new List<int>();
            
            while(numbers.Count != 0)
            {
                Fill(numbers[0], ref current_group);
                numbers = numbers.Except(current_group).ToList();
                groups++;
                current_group = new List<int>();
            }

            return groups;

            void Fill(int num, ref List<int> add)
            {
                if (!(add.Contains(num)))
                {
                    add.Add(num);
                    foreach (int what in connected[num])
                    {
                        Fill(what, ref add);
                    }

                }
                return;
            }
        }
    }
}
