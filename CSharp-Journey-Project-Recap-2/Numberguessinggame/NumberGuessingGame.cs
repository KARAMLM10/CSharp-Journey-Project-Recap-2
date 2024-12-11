using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Journey_Project_Recap_2.Numberguessinggame
{
    public class NumberGuessingGame
    {
        public NumberGuessingGame() { NumberGuessingGameMethod(); }

        public void NumberGuessingGameMethod()
        {
            Random random = new Random();
            bool playagain = true;
            int min = 1;
            int max = 20;
            int guess;
            int number;
            int guesses;
            string response;

            while (playagain) 
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max);

                while (guess != number)
                {
                    Console.WriteLine("guess a number betwen  " + min + "  " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine("Guess to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Guess to Low!");

                    }
                     guesses++;
                }
                Console.WriteLine("Number " + number);
                Console.WriteLine("You win");
                Console.WriteLine("Guesses " + guesses);
                Console.WriteLine("Would you play again (Y/N) ");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y") { playagain = true; }
                else if (response == "N") { playagain = false; }
            }

            Console.WriteLine("thanks for playing! ... i guess ");
        }

    }
}
