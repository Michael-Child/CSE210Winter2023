using System;

class Program
{
    static void Main(string[] args){
        Scripture scripture = new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Console.WriteLine($"{scripture.GetAuthor()} {scripture.GetChapter()}: {scripture.GetStartVerse()} - {scripture.GetEndVerse()} {scripture.GetWords()}");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string done = Console.ReadLine() ?? "";

        while(done !=  "quit"){
            scripture.randomized();

            display(scripture);
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            done = Console.ReadLine() ?? "";
        }

    }

    static void display(Scripture scripture){
        Console.WriteLine($"{scripture.GetAuthor()} {scripture.GetChapter()}: {scripture.GetStartVerse()} - {scripture.GetEndVerse()} {scripture.DisplayReplacedWords()}");
    }
}