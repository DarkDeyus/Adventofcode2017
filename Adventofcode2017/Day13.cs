using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adventofcode2017
{
    class Day13
    {    
        List<(int, int)> firewall = new List<(int, int)>();

        public Day13(string file)
        {
            string[] list = File.ReadAllLines(@"..\..\" + file);
            foreach (string line in list)
            {
                string parse = line.Replace(":", "");
                string[] parsed = parse.Split(' ');
                firewall.Add((int.Parse(parsed[0]), int.Parse(parsed[1])));
            }
        }

        public int walk()
        {
            int cost = 0;
            foreach ((int, int) pair in firewall)
            {
                int location = pair.Item1;
                int count = location;
                int max = pair.Item2;

                count = count % (2 * (max - 1));
                if (count > max)
                    count = (max - 1) - count % (max - 1);
                if (count == 0)
                    cost += location * max;

            }
            return cost;
        }

        public int undetected()
        {
            int delay = 0;
            while (detected(firewall, delay))
            {
                delay++;
                //Console.WriteLine("Try number " + delay);
            }
            return delay;

            bool detected(List<(int, int)> list, int wait)
            {
                foreach((int,int) pair in list)
                {
                    //Console.WriteLine("My delay is " + wait);
                    int count = pair.Item1;
                    count+= wait;
                    int max = pair.Item2;

                    count = count % (2 * (max - 1));
                    if (count > max)
                        count = (max - 1) - count % (max - 1);
                    if (count == 0)
                        return true;
                }
                return false;
            }
        }
    }
}
