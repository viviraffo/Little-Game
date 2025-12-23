using System;

namespace LittleGame;

class Program
{
    private static readonly Random RandomGenerator = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("Would you like to play? (Y/N)");
        string? input = Console.ReadLine();

        if (ShouldPlay(input))
        {
            PlayGame();
        }
    }

    private static void PlayGame()
    {
        bool isRunning = true;

        while (isRunning)
        {
            int target = RandomGenerator.Next(1, 7); // Würfeltypisch 1-6
            int roll = RandomGenerator.Next(1, 7);

            Console.WriteLine($"\nRoll a number greater than {target} to win!");
            Console.WriteLine($"You rolled a {roll}");
            
            PrintResult(target, roll);

            Console.WriteLine("\nPlay again? (Y/N)");
            string? response = Console.ReadLine();
            isRunning = ShouldPlay(response);
        }
    }

    private static bool ShouldPlay(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }
        
        return input.Trim().ToUpper() == "Y";
    }

    private static void PrintResult(int target, int roll)
    {
        if (roll > target)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You win!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You lose!");
        }
        Console.ResetColor();
    }
}
