using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day6
    {
        int number_of_stacks;
        List<int> stacks = new List<int>();

        public Day6(string memory)
        {
            foreach (string number in memory.Split(' '))
                stacks.Add(int.Parse(number));
            number_of_stacks = stacks.Count;
        }

        public int distribute()
        {
            List<int> memory = new List<int>(stacks);
            string combination = string.Empty;
            List<string> list = new List<string>();   
            int count = 0;
            int index;
            int value;
            while(true)
            {
                foreach (int number in memory)
                    combination += number.ToString();
                if (list.Contains(combination))
                    return count;
                else list.Add(combination);

                value = memory.Max();
                index = memory.IndexOf(value);
                memory[index] = 0;
                while(value >0)
                {
                    index++;
                    index = index % number_of_stacks;
                    memory[index]++;
                    value--;
                }
                
                count++;
                combination = string.Empty;
            }
        }

        public int newdistribute()
        {
            List<int> memory = new List<int>(stacks);
            string combination = string.Empty;
            List<string> list = new List<string>();

            int index;
            int value;
            while (true)
            {
                foreach (int number in memory)
                    combination += number.ToString();
                if (list.Contains(combination))
                {
                    list.Add(combination);
                    return list.LastIndexOf(combination) - list.IndexOf(combination);


                }
                else list.Add(combination);

                value = memory.Max();
                index = memory.IndexOf(value);
                memory[index] = 0;
                while (value > 0)
                {
                    index++;
                    index = index % number_of_stacks;
                    memory[index]++;
                    value--;
                }

                combination = string.Empty;
            }
        }
    }
}
