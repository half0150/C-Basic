using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice game");
            Console.WriteLine("Enter the number of dices you wanna use:");

            int numberOfDice;
            while (!int.TryParse(Console.ReadLine(), out numberOfDice) || numberOfDice <= 0)
            {
                Console.WriteLine("Ivalid input. Please enter a whole number:");
            }

            int rollsNeeded = RollForSixes(numberOfDice);

            Console.WriteLine($"It took {rollsNeeded} throws to hit clean sixes with {numberOfDice} dices.");
        }

        static int RollForSixes(int numberOfDice)
        {
            Random random = new Random();
            int rolls = 0;

            while (true)
            {
                rolls++;
                bool allSixes = true;
                for (int i = 0; i < numberOfDice; i++)
                {
                    if (random.Next(1, 7) != 6)
                    {
                        allSixes = false;
                        break;
                    }
                }
                if (allSixes)
                    break;
            }

            return rolls;
        }
    }
}
