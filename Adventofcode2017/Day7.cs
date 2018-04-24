using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day7
    {
        List<String> programs = new List<String>();

        public Day7(string file)
        {
            
            String[] lines = File.ReadAllLines(@"..\..\" + file);
            foreach (string program in lines)
                programs.Add(program);

            //Console.WriteLine("programs: ");
            //foreach (string program in programs)
            //    Console.WriteLine(program);
            //Console.WriteLine();
            //Console.WriteLine("holding: ");
            //foreach (string program in holding)
            //    Console.WriteLine(program);
        }

        public int Balance() //FIX!
        {
            Dictionary<string, int> weight = new Dictionary<string, int>();
            Dictionary<string, String[]> programsholding = new Dictionary<string, string[]>();

            foreach (string line in programs)
            {
                string trimmed = line.Replace(",", "");
                trimmed = trimmed.Replace("(", "");
                trimmed = trimmed.Replace(")", "");
                string[] list = trimmed.Split(' ');
                weight.Add(list[0], int.Parse(list[1]));

                if (line.Contains("->"))
                {
                    trimmed = trimmed.Substring(line.IndexOf(">"));
                    programsholding.Add(list[0], trimmed.Split(' '));
                }

                else
                {
                    programsholding.Add(list[0], new string[0]);
                }

            }
            //System.Console.WriteLine("weight: \n");
            //foreach (string key in weight.Keys)
            //    System.Console.WriteLine($"i am {key} and i weight {weight[key]} \n" );

            //System.Console.WriteLine("programsholding: \n");
            //foreach (string key in weight.Keys)
            //{
            //    System.Console.Write($"i am {key} and i hold: ");

            //   foreach (string program in programsholding[key])
            //        System.Console.Write(program + " ");
            //    System.Console.WriteLine();
            //}


            foreach (string key in programsholding.Keys.Where(obj => programsholding[obj].Length != 0))
            {
                int[] tab = new int[programsholding[key].Length];
                for (int i = 0; i < programsholding[key].Length; i++)
                {
                    //System.Console.WriteLine(key + ": ");
                    //System.Console.WriteLine(programsholding[key][i] + " ");
                    tab[i] = Weight(programsholding[key][i]);
                }
                bool flag = FindDifferent(tab, out int index);
                if (flag)
                {

                    int[] weights = new int[programsholding[programsholding[key][index]].Length]; //found the wrong one and check if it holding a stack of balanced programs

                    for (int i = 0; i < programsholding[programsholding[key][index]].Length; i++)
                    {
                        weights[i] = Weight(programsholding[programsholding[key][index]][i]);
                    }
                    string current = programsholding[key][index];
                    int previous_program_place = index;
                    flag = FindDifferent(weights, out index);

                    if (flag == false) //was balanced above
                    {
                        if (previous_program_place == 0)
                        {
                            int good_weight = tab[1];
                            int your_weight = tab[0];
                            // Console.WriteLine("KLUCZ: " + current);
                            return weight[current] - (your_weight - good_weight);
                        }
                        else
                        {
                            int good_weight = tab[previous_program_place - 1];
                            int your_weight = tab[previous_program_place];
                            //Console.WriteLine("KLUCZ: " +current);
                            return weight[current] - (your_weight - good_weight);
                        }
                    }

                }
            }

            return 1; //needs to be here thanks to the compiler

            int Weight(string name) //get weight of all programs above you and you
            {
                int howmuch = weight[name];
                if (programsholding.ContainsKey(name))
                {
                    String[] holding = programsholding[name];
                    foreach (string program in holding)
                        howmuch += Weight(program);
                }
                return howmuch;
            }

            bool FindDifferent(int[] array, out int index)
            {
                if (array.Length == 0)
                {
                    index = int.MinValue;
                    return false;
                }

                int first_char = array[0];
                int second_char = int.MinValue;  //garbage value
                int first_occ = 1;
                int second_occ = 0;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] != first_char)
                    {
                        second_char = array[i];
                        second_occ++;
                    }
                    else first_occ++;
                }

                if (second_occ == 0)
                {
                    index = int.MinValue;
                    return false;
                }

                if (first_occ > second_occ)
                {
                    int place = int.MinValue;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == second_char)
                        {
                            place = i;
                            break;
                        }

                    }
                    index = place;
                    return true;
                }
                else
                {
                    int place = int.MinValue;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == first_char)
                        {
                            place = i;
                            break;
                        }
                    }
                    index = place;
                    return true;
                }
            }
        }

        public string FindBottom()
        {

            List<String> holding = new List<String>();
            List<String> programsholding = new List<String>();

            foreach (string line in programs)
            {
                if (line.Contains("->"))
                {
                    string trimmed = line.Replace(",", "");

                    string[] test = trimmed.Split(' ');
                    programsholding.Add(test[0]);

                    trimmed = trimmed.Substring(trimmed.IndexOf(">") + 1);
                    foreach (string hold in trimmed.Split(' '))
                    {
                        holding.Add(hold);
                    }
                }

            }

            foreach (string name in programsholding)
            {
                if (!holding.Contains(name))
                    return name;
            }

            return "ERROR - NOT FOUND";
        }
    }
}