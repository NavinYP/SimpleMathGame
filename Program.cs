using System;

namespace SimpleMathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.TestBench();

                       
        }

        static void TestBench()
        {
            int testNumber = 10;

            if (testNumber == 11)
            {
                Console.WriteLine("The number is 10");
            } else
            {
                Console.WriteLine("The number is not 10");
            }
        }

        static void Game()
        {
            var rand = new Random();

            for (int i = 1; i < 5; i++)
            {
                int firstNumber = rand.Next(100);
                int secondNumber = rand.Next(100);

                int sumOfNumbers = firstNumber + secondNumber;

                Console.WriteLine($"What is the sum of {firstNumber} and {secondNumber} : ");

                string userInput = Console.ReadLine();

                try
                {
                    int userInputInt = Int32.Parse(userInput);
                    if (userInputInt == sumOfNumbers)
                    {
                        Console.WriteLine("You are correct!");
                    }
                    else
                    {
                        Console.WriteLine("You are incorrect!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.");
                }



            }
        }
    }
}
