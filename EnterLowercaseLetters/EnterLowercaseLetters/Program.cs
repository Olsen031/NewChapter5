using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char singleLetterInput;

            do
            {
                WriteLine("Enter a lower case letter >>>>>");
                input = ReadLine();
                singleLetterInput = Convert.ToChar(input);
                if (singleLetterInput >= 'a' && singleLetterInput <= 'z')
                {
                    WriteLine("Ok");
                }
                else
                    WriteLine("Not a lower case letter");
                WriteLine("Enter an ! to quit");

            } while (input != "!");

        }
    }
}
