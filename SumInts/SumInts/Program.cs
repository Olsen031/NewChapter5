using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            string inputString;

            do
            {
                WriteLine("Enter a number (Enter 999 to terminate the program)");
                inputString = ReadLine();
                num = Convert.ToInt32(inputString);
                sum = sum + num;

            } while (num != 999);
            sum = sum - 999;
            Write("The sum of all the integers entered is: " + sum);

        }
    }
}
