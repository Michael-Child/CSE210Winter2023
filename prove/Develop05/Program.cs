using System;

class Program
{
    static int totalpoint = 0;
    static void Main(string[] args)
    {
        int UI = 0;
        while(UI != 6){
            display();
            string response = Console.ReadLine() ?? "";
            UI = int.Parse(response);
            if(UI == 1){
                ;
            }
            else if(UI == 2){
                ;
            }
            else if(UI == 3){
                ;
            }
            else if(UI == 4){
                ;
            }
            else if(UI == 5){
                ;
            }
            else if(UI == 6){}
            else{
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    static void display(){
        Console.WriteLine($"You have {totalpoint} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }  
}