using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day9
    {
        public string Groups;

        public Day9(string list)
        {
            Groups = list;
        }

        public Day9(string file,int a)
        {
            Groups = File.ReadAllText(@"..\..\" + file);
        }

        public int Calculate()
        {
            int value = 0;
            int count = 0;
            bool garbage = false;
            char[] list = Groups.ToCharArray();

            for (int i=0; i<list.Length; i++)
            {
                switch(list[i])
                {
                    case ('{'):
                        if (!garbage)
                            value++;
                        break;

                    case ('}'):
                        if (!garbage)
                        {
                            count += value;
                            value--;
                        }
                        break;

                    case ('<'):
                        garbage = true;
                        break;

                    case ('>'):
                        garbage = false;
                        break;

                    case ('!'):
                        i++;
                        break;

                    default:
                        break;

                }
            }

            return count;
        }

        public int Garbageammount()
        {
            int count = 0;
            bool garbage = false;
            char[] list = Groups.ToCharArray();

            for (int i = 0; i < list.Length; i++)
            {
                switch (list[i])
                {

                    case ('<'):
                        if (garbage)
                            count++;
                        garbage = true;
                        break;

                    case ('>'):
                        garbage = false;
                        break;

                    case ('!'):
                        i++;
                        break;

                    default:
                        if (garbage)
                            count++;
                        break;
                }
            }

            return count;
        }
    }
}
