using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
   class Day15
    {
        int startA;
        int startB;
        int factorA;
        int factorB;
        int divider;

        public Day15(int startA, int startB, int factorA, int factorB, int divider)
        {
            this.startA = startA;
            this.startB = startB;
            this.factorA = factorA;
            this.factorB = factorB;
            this.divider = divider;
        }

        public int Findpairs(int max_tries=40000000)
        {
            int pairs = 0;
            ulong A = (ulong)startA;
            ulong B = (ulong)startB;

            for(int i=0; i<max_tries; i++)
            {
                A = (A * (ulong)factorA) % (ulong)divider;
                B = (B * (ulong)factorB) % (ulong)divider;

                if ((A << 48) == (B << 48))
                    pairs++;
            }
            return pairs;
        }

        public int Betterpairs(int max_tries=5000000)
        {
            int pairs = 0;
            ulong A = (ulong)startA;
            ulong B = (ulong)startB;

            for (int i = 0; i < max_tries; i++)
            {
                while ((A= ((A * (ulong)factorA) % (ulong)divider)) % 4 != 0) ;
                while ((B = ((B * (ulong)factorB) % (ulong)divider)) % 8 != 0) ;

                if ((A << 48) == (B << 48))
                    pairs++;
            }
            return pairs;
        }
    }
}
