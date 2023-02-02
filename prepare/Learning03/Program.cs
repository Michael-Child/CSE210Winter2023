using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(0, 0);
        fraction.SetTop(1);
        fraction.SetBottom(1);
        display(fraction);
        
        fraction.SetTop(5);
        fraction.SetBottom(1);
        display(fraction);
        
        Fraction fraction2 = new Fraction(0, 0);
        fraction2.SetTop(3);
        fraction2.SetBottom(4);
        display(fraction2);

        fraction2.SetTop(1);
        fraction2.SetBottom(3);
        display(fraction2);
    }

    static void display(Fraction fraction){
        Console.WriteLine($"1. Fraction: {fraction.GetFractionString(fraction)}");
        Console.WriteLine($"2. Decimal: {fraction.GetDecimalValue(fraction)}");
        Console.WriteLine("");
    }
      
}