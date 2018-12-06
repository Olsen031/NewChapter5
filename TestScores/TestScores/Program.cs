using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int total = 0;
            int score = 0;
            int sentinalValue = 999;
            double average;
            int counter = 0;

            WriteLine("Enter 999 to stop entering values and figure your average");

            while (score != sentinalValue)
            {
                Write("Enter a value between 0 and 100 >>>>> ");
                input = ReadLine();
                score = Convert.ToInt32(input);
                if (score >= 0 && score <= 100)
                {
                    total = total + score;

                    counter++;
                }
                else if (score != 999)
                    WriteLine("You entered an incorrect value, try again");
                else
                    WriteLine();

            }
            average = total / counter;
            WriteLine("You entered {0} test scores and your overall average is: {1}", counter, average);
        }
    }
}
