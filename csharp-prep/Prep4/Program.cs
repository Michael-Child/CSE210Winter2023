using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Console.Write("Enter number: ");
        string userInput = Console.ReadLine() ?? "";
        int num = int.Parse(userInput);
        int sum = 0;
        int count = 0;
        int big_num = 0;

        List<int> numbers = new List<int>();

        while (num != 0){
            sum += num;
            count += 1;

            if(big_num < num){
                big_num = num;
            }

            numbers.Add(num);

        }

        //Using Loops and erasing past information
        Console.WriteLine("Using common methods:");

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(sum/count)}");
        Console.WriteLine($"The largest number is: {big_num}");


        //Using Lists in Loops and saving the past information
        Console.WriteLine("Using a list:");

        int sumOf = 0;
        for (int i = 0; i < numbers.Count; i++){
            sumOf += numbers[i];
        }

        Console.WriteLine($"The sum is: {sumOf}");
        Console.WriteLine($"The average is: {(sumOf/numbers.Count)}");

        int largest_num = 0;
        foreach (int number in numbers){
            if(largest_num < number){
                largest_num = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest_num}");
    }
}