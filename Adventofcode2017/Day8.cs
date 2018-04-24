using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day8
    {
        List<String> instructions = new List<String>();
        Dictionary<String,int> registerlist = new Dictionary<String,int>();

        public Day8(string file)
        {
            string[] list = File.ReadAllLines(@"..\..\" + file);
            foreach (string line in list)
                instructions.Add(line);
        }

        public int ExecuteCommands()
        {
            Dictionary<String, int> registers = new Dictionary<String, int>(registerlist);
            bool condition = false;
            foreach (String instruction in instructions)
            {
                // register commmand value if register sign value
                //    0        1        2   3    4       5    6
                String[] parts = instruction.Split(' ');
               

                if (!registers.ContainsKey(parts[0])) ///register 1
                    registers.Add(parts[0], 0);

                if (!registers.ContainsKey(parts[4])) //register 2
                    registers.Add(parts[4], 0);
                
                switch (parts[5]) //sign , check condition
                {
                    case (">"):
                        condition = (registers[parts[4]] > int.Parse(parts[6])) ? true : false;
                        break;
                    case ("<"):
                        condition = (registers[parts[4]] < int.Parse(parts[6])) ? true : false;
                        break;
                    case (">="):
                        condition = (registers[parts[4]] >= int.Parse(parts[6])) ? true : false;
                        break;
                    case ("<="):
                        condition = (registers[parts[4]] <= int.Parse(parts[6])) ? true : false;
                        break;
                    case ("=="):
                        condition = (registers[parts[4]] == int.Parse(parts[6])) ? true : false;
                        break;
                    case ("!="):
                        condition = (registers[parts[4]] != int.Parse(parts[6])) ? true : false;
                        break;
                }

                if(condition)
                {
                    switch (parts[1])
                    {
                        case ("inc"):
                            registers[parts[0]] += int.Parse(parts[2]);
                            break;
                        case ("dec"):
                            registers[parts[0]] -= int.Parse(parts[2]);
                            break;

                    }
                }


            }
            return registers.Values.Max();
        }

        public int FindMax()
        {
            Dictionary<String, int> registers = new Dictionary<String, int>(registerlist) ;
            int max = 0;
            bool condition = false;
            foreach (String instruction in instructions)
            {
                // register commmand value if register sign value
                //    0        1        2   3    4       5    6
                String[] parts = instruction.Split(' ');


                if (!registers.ContainsKey(parts[0])) ///register 1
                    registers.Add(parts[0], 0);

                if (!registers.ContainsKey(parts[4])) //register 2
                    registers.Add(parts[4], 0);

                switch (parts[5]) //sign , check condition
                {
                    case (">"):
                        condition = (registers[parts[4]] > int.Parse(parts[6])) ? true : false;
                        break;
                    case ("<"):
                        condition = (registers[parts[4]] < int.Parse(parts[6])) ? true : false;
                        break;
                    case (">="):
                        condition = (registers[parts[4]] >= int.Parse(parts[6])) ? true : false;
                        break;
                    case ("<="):
                        condition = (registers[parts[4]] <= int.Parse(parts[6])) ? true : false;
                        break;
                    case ("=="):
                        condition = (registers[parts[4]] == int.Parse(parts[6])) ? true : false;
                        break;
                    case ("!="):
                        condition = (registers[parts[4]] != int.Parse(parts[6])) ? true : false;
                        break;
                }

                if (condition)
                {
                    switch (parts[1])
                    {
                        case ("inc"):
                            registers[parts[0]] += int.Parse(parts[2]);
                            if (max < registers[parts[0]])
                                max = registers[parts[0]];
                            break;
                        case ("dec"):
                            registers[parts[0]] -= int.Parse(parts[2]);
                            if (max < registers[parts[0]])
                                max = registers[parts[0]];
                            break;

                    }
                }


            }
            return max;
        }
    }
}
