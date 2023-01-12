using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int num = int.Parse(userInput);
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string userInput = Console.ReadLine();
        int guess = int.Parse(userInput);

        while (guess != num)
        {
            if (guess >= num){
                Console.WriteLine("Lower");
            }
            else if (guess <= num){
                Console.WriteLine("Higher");
            }

            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);
        }

        Console.WriteLine($"You guessed it! {num}");

    }
}