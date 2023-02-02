using System;

class Program
{
    static void Main(string[] args)
    {
        string variable = display_menu();
        Console.WriteLine($"{variable}");
    }
    static string display_menu(){
        Console.WriteLine("Write something to be saved inside a variable: ");
        string userInput = Console.ReadLine() ?? "";
        return userInput;
    }    

}