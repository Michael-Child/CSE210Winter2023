using System;

class Program{
    static void Main(string[] args){
        int num = 0;
        BreathingActivity B = new BreathingActivity();
        ReflectingActivity R = new ReflectingActivity();
        ListingActivity L = new ListingActivity();
        while(num != 4){
            menu();
            string userInput = Console.ReadLine() ?? "";
            num = int.Parse(userInput);
            if(num == 1){
                B.Breath();
            }
            else if(num == 2){
                R.Reflect();
            }
            else if(num == 3){
                L.List();
            }
            else{
                Console.WriteLine("Menu Options:");
            }
        }
    }

    static void menu(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflecting activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }
}