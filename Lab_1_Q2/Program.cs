using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 25;
            int guess;
            int attempts = 0;

            Console.WriteLine("Guess the secret number between 1 and 50.");

            do
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low");
                } 
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    Console.WriteLine("Total attempts: " + attempts);
                }

            } while (guess != secretNumber);
        }
    }
}