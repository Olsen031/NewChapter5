using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {

            int min = 1;
            int max = 101;
            string input;
            int userInput;

            Random ranNumber = new Random();
            int randomNumber;
            randomNumber = ranNumber.Next(min, max);

            Write("Please enter a number between 1 and 100 >>>>");
            input = ReadLine();
            userInput = Convert.ToInt32(input);

            do
            {
                if(userInput < randomNumber)
                {
                    WriteLine("The number you entered was too low, please guess again >>>>");
                    input = ReadLine();
                    userInput = Convert.ToInt32(input);
                }
                else
                {
                    WriteLine("The number you entered was too high, please guess again >>>>");
                    input = ReadLine();
                    userInput = Convert.ToInt32(input);
                }
            } while (userInput != randomNumber);

            WriteLine("Congrats, you guessed the right number, it was {0}", randomNumber);


        }
    }
}
