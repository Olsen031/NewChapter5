using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int counter1 = 1;
            int counter2 = 1;
            int num;

            while(counter1 != 11)
            {
                while(counter2 != 11)
                {
                    num = counter2 * counter1;
                    Write(num + " ");
                    counter2++;
                }
                WriteLine();
                counter2 = 1;
                counter1++;
            }
        }
    }
}
