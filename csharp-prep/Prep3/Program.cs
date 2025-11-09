using System;
using System.Data;
using System.Globalization;

class Program

{
    static void Main(string[] args)
    {
        
        const int minValue = 1;
        const int maxValue = 10;

        // computer give us the magic number
        var rng = new Random();
        int number = rng.Next(minValue, maxValue + 1);
        Console.Write("What is your guess : ");
        string guess = Console.ReadLine();
        int attempts = 0;
        int guessit = int.Parse(guess);
        attempts++;
        
        while (guessit != number)
        {
            Console.WriteLine("Try again");
            guess = Console.ReadLine();
            guessit = int.Parse(guess);
            attempts++;
        }

        Console.WriteLine("Good job" + "  " + guessit + " " + "Was the Magic Number");
        Console.WriteLine("Attempts :" + " " + attempts);

    }

} 