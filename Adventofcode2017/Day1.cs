using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day1
    {
        public string Captcha;

       public Day1(string captcha)
        {
            Captcha = captcha;
        }

        public int Solve()
        {
            int sum = 0;
            for (int i=0; i<Captcha.Length-1; i++)
            {
                if (Captcha[i] == Captcha[i + 1])
                    sum += (Captcha[i] - '0');
            }
            if (Captcha[0] == Captcha[Captcha.Length - 1])
                sum += (Captcha[0] - '0');
            return sum;
        }

        public int newSolve()
        {
            string circular = Captcha + Captcha;
            int sum = 0;
            int distance = Captcha.Length / 2;
            for (int i = 0; i < Captcha.Length; i++)
            {
                if (circular[i] == circular[i + distance])
                    sum += (Captcha[i] - '0');
            }

            return sum;
        }
    }  
 
}
