using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Adventofcode2017
{
    class Day18
    {
        List<String> instructions = new List<String>();

        public Day18(string file)
        {
            string[] list = File.ReadAllLines(@"..\..\" + file);
            foreach (string line in list)
                instructions.Add(line);
        }

        public Int64 Play()
        {
            Int64 sound = Int64.MinValue;
            int i = 0;
            Dictionary<String, Int64> registers = new Dictionary<String, Int64>();
            while( i<instructions.Count)
            {
                String[] parts = instructions[i].Split(' ');                
                switch(parts[0])
                {
                    case ("snd"):
                        if (Int64.TryParse(parts[1], out Int64 value4))
                            sound = value4;
                        else
                            sound = registers[parts[1]];
                        break;

                    case ("set"):
                        if (!registers.ContainsKey(parts[1]))
                            registers.Add(parts[1], 0);
                        if (Int64.TryParse(parts[2], out Int64 set))
                            registers[parts[1]] = set;
                        else
                            registers[parts[1]] = registers[parts[2]];
                        break;

                    case ("add"):
                        if (!registers.ContainsKey(parts[1]))
                            registers.Add(parts[1], 0);
                        if (Int64.TryParse(parts[2], out Int64 add))
                            registers[parts[1]] += add;
                        else
                            registers[parts[1]] += registers[parts[2]];
                        break;

                    case ("mul"):
                        if (!registers.ContainsKey(parts[1]))
                            registers.Add(parts[1], 0);
                        if (Int64.TryParse(parts[2], out Int64 mul))
                            registers[parts[1]] *= mul;
                        else
                            registers[parts[1]] *= registers[parts[2]];
                        break;

                    case ("mod"):
                        if (!registers.ContainsKey(parts[1]))
                            registers.Add(parts[1], 0);
                        if (Int64.TryParse(parts[2], out Int64 mod))
                            registers[parts[1]] %= mod;
                        else
                            registers[parts[1]] %= registers[parts[2]];
                        break;

                    case ("rcv"):

                        if (Int64.TryParse(parts[1], out Int64 rcv))
                        {
                            if (rcv != 0)
                                return sound;
                        }
                        else
                        {
                            if (registers[parts[1]] != 0)
                                return sound;
                        }                       
                        break;

                    case ("jgz"):
                        if ((Int64.TryParse(parts[1],out Int64 cond) ? cond:registers[parts[1]]) > 0)
                        {
                            if (Int64.TryParse(parts[2], out Int64 jgz))
                                i += ((int)jgz-1);
                            else
                                i += ((int)registers[parts[2]]-1);
                        }
     
                        break;
                        
                }
                i++;
            }
            return sound; //error
        }
    }
}
