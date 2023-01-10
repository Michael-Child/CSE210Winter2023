using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter_grade;
        if (grade > 90){
            // Console.WriteLine("A");
            letter_grade = "A";
        }
        else if (grade > 80){
            // Console.WriteLine("B");
            letter_grade = "B";
        }
        else if (grade > 70){
            // Console.WriteLine("C");
            letter_grade = "C";
        }
        else if (grade > 60){
            // Console.WriteLine("D");
            letter_grade = "D";
        }
        else{
            // Console.WriteLine("F");
            letter_grade = "F";
        }

        Console.WriteLine("Your grade: ");
        Console.WriteLine(letter_grade);

        if (grade > 70){
            Console.WriteLine("Well done! You've passed!");
        }
        else{
            Console.WriteLine("Well...Study more...");
        } 
    }
}