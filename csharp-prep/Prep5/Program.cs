using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int square = SquareNumber(num);
        DisplayWelcome(name, square);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine() ?? "";
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your name: ");
        string userInput = Console.ReadLine() ?? "";
        int num = int.Parse(userInput);
        return num;
    }

    static int SquareNumber(int number){
        int num = number^2;
        return num;
    }

    static void DisplayWelcome(string name, int num){
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}