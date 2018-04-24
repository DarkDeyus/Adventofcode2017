using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day4
    {
        public List<string> passphrases = new List<string>();

        public Day4(string list)
        {
            foreach (string password in list.Split('\n'))
                passphrases.Add(password);
        }
        public Day4(string file, int w)
        {
            


            string[] input = File.ReadAllLines(@"..\..\" + file);
            foreach(string password in input)
            {
                passphrases.Add(password);
                
            }

            
        }
        public int check()
        {
            int valid = 0;
            int flag = 1;
            List<string> words = new List<string>();
            foreach(string password in passphrases)
            {
                foreach (string word in password.Split(' '))
                {

                    if (words.Contains(word))
                    {
                        flag = -1;
                        break;
                    }
                    else words.Add(word);
                        
                }
                if (flag==1)
                    valid++;
                flag = 1;
                words.Clear();
            }
            return valid;
        }

        public int checkanagrams()
        {
            int valid = 0;
            int flag = 1;
            List<string> words = new List<string>();
            foreach (string password in passphrases)
            {

                foreach (string word in password.Split(' '))
                {
                    char[] tab = word.ToArray();
                    Array.Sort(tab);
                    string sorted = new string(tab);

                    if (words.Contains(sorted))
                    {
                        flag = -1;
                        break;
                    }
                    else words.Add(sorted);

                }
                if (flag == 1)
                    valid++;
                flag = 1;
                words.Clear();
            }
            return valid;
        }
    }

    
}
