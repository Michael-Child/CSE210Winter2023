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

        int guess = 0;

        while (guess != num)
        {
            if (guess >= num){
                Console.WriteLine("Lower");
            }
            else if (guess <= num){
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You guessed it!");

    }
}