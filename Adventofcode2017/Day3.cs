using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventofcode2017
{
    class Day3
    {
        public int middle_x = 0;
        public int middle_y = 0;
        public int number;

        public Day3(int value)
        {
            number = value;
        }

        public int calculateDistance()
        {
            int square = 1;
            int dist = 0;
            int x;
            int y;

            if (number == 1)
                return 0;

            while (System.Math.Pow(square + 2, 2) < number)
            {
                square += 2;
                dist++;
            }
            //if(number == System.Math.Pow(square + 2, 2))
            //{
            //    x = dist + 1;
            //    y = -dist - 1;

            //    return System.Math.Abs(middle_x - x) + System.Math.Abs(middle_y - y);
            //}

            if(number > System.Math.Pow(square, 2) && number <= System.Math.Pow(square, 2) + square + 1 )
            {
                x = dist + 1;
                y = -dist + number - (int)System.Math.Pow(square, 2) - 1;
                return System.Math.Abs(middle_x - x) + System.Math.Abs(middle_y - y);
            }

            if (number > System.Math.Pow(square, 2) + square + 1 && number <= System.Math.Pow(square, 2) + 2 * (square + 1)) 
            {
                y = dist + 1;
                x = dist - number + (int)System.Math.Pow(square, 2) + square + 2;
                return System.Math.Abs(middle_x - x) + System.Math.Abs(middle_y - y);
            }

            if (number > System.Math.Pow(square, 2) + 2*(square + 1) && number <= System.Math.Pow(square, 2) + 3 * (square + 1))
            {
                y = dist - number + (int)System.Math.Pow(square, 2) + 2 * square + 3 ;
                x = -dist - 1;
                return System.Math.Abs(middle_x - x) + System.Math.Abs(middle_y - y);
            }

            else
            {
                y = -dist - 1;
                x = dist + 1 - (int)System.Math.Pow(square + 2, 2) + number;
                return System.Math.Abs(middle_x - x) + System.Math.Abs(middle_y - y);
            }

        }

        public int newcalculateDistance()
        {
            int[,] spiral = new int[21, 21] ;
            int element = 1;
            int size = 2;
 
            int x = 11, y = 11;
            spiral[10, 10] = 1; //start
            while(true)
            {
                for (int i = 0; i < size; i++) 
                {
                    y--;
                    spiral[x, y] = spiral[x - 1, y - 1] + spiral[x - 1, y] + spiral[x - 1, y + 1] +
                                   spiral[x + 1, y - 1] + spiral[x + 1, y] + spiral[x + 1, y + 1] +
                                   spiral[x, y - 1] + spiral[x, y + 1];

                    element = spiral[x, y];
                    if (element > number)
                        return element;
                    
                } //right edge

                for (int i = 0; i < size; i++)
                {
                    x--;
                    spiral[x, y] = spiral[x - 1, y - 1] + spiral[x - 1, y] + spiral[x - 1, y + 1] +
                                   spiral[x + 1, y - 1] + spiral[x + 1, y] + spiral[x + 1, y + 1] +
                                   spiral[x, y - 1] + spiral[x, y + 1];

                    element = spiral[x, y];
                    if (element > number)
                        return element;
                } //top edge

                for (int i = 0; i < size; i++)
                {
                    y++;
                    spiral[x, y] = spiral[x - 1, y - 1] + spiral[x - 1, y] + spiral[x - 1, y + 1] +
                                   spiral[x + 1, y - 1] + spiral[x + 1, y] + spiral[x + 1, y + 1] +
                                   spiral[x, y - 1] + spiral[x, y + 1];

                    element = spiral[x, y];
                    if (element > number)
                        return element;
                } //left edge

                for (int i = 0; i < size; i++)
                {
                    x++;
                    spiral[x, y] = spiral[x - 1, y - 1] + spiral[x - 1, y] + spiral[x - 1, y + 1] +
                                   spiral[x + 1, y - 1] + spiral[x + 1, y] + spiral[x + 1, y + 1] +
                                   spiral[x, y - 1] + spiral[x, y + 1];

                    element = spiral[x, y];
                    if (element > number)
                        return element;
                } //bottom edge

                x++;
                y++;
                size += 2;

            }

        }
    }
}
