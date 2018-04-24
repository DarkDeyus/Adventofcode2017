using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{ 
    class Day5
    {
        List<int> memory = new List<int>();
        int size;
        public Day5(string memoryList)
        {
            foreach (string slot in memoryList.Split(' '))
                memory.Add(int.Parse(slot));

            size = memory.Count ; 
        }
        
        public int checkloop()
        {
            List<int> space = new List<int>(memory);
            int i = 0;
            int count = 0;
            while(i >= 0 && i<size)
            {
                space[i]++;
                i = i + space[i] - 1;
                count++;
               
            }
            return count;
        }

        public int newcheckloop()
        {
            List<int> space = new List<int>(memory);
            int i = 0;
            int count = 0;
            while (i >= 0 && i < size)
            {
                
                if (space[i] >= 3)
                {
                    space[i]--; 
                    i = i + space[i] + 1;
                }
                else
                {
                    space[i]++;
                    i = i + space[i] - 1;
                }
                count++;
               
            }
            return count;
        }

    }
}
