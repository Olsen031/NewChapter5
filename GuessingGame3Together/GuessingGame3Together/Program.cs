using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame3Together
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            int againLower = 1;
            int againHigher = 10;
            int counter = 0;
            string guessString;
            int guess = 9000;
      
            string result = null;
          
            

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            while (guess != randomNumber)
            {
                Write("Choose a number between 1-10 >>> ");
                guessString = ReadLine();
                guess = Convert.ToInt32(guessString);

                if (guess <= 10 && guess >= 1)
                {
                    if (randomNumber == guess)
                    {
                        result = "Congradulations on the guess of " + randomNumber;
                    }
                    else if (guess < randomNumber)
                    {
                        result = "You guessed " + guess + " to low";
                        if (guess <= againLower)
                        {
                            result = "What?! " + guessString + "Why? You have the chronic dumb";
                        }
                        againLower = guess;
                    }
                }
                else if (guess > randomNumber)
                {
                    result = "You guessed " + guess + " to high";
                    if (guess >= againHigher)
                    {
                        result = "What ?! " + guess + "Why? You have the chronic dumb";
                    }
                    againHigher = guess;
                }
                else if (guess < min || guess >= max)
                {
                    result = "Out of bounds";
                }
                DisplayString(result);
                counter = counter + 1;
            }
            result = "You guessed " + guess + " in " + counter + " tries";

        }

        static void DisplayString(string result)
        {
            WriteLine(result);
        }
    }
}
