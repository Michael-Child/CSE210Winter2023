using System;

class BreathingActivity: Activity{

    public BreathingActivity(): 
    base("Breathing Activity",
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
    "How long, in seconds, would you like for your session?",
    "Well Done! You have completed the breathing activty.",
     0){}
    
    public void Breath(){
        Console.WriteLine($"Welcome to the {GetTitle()}");
        Console.WriteLine(GetDiscription());
        Console.WriteLine(GetStartMessage());
        string userInput = Console.ReadLine() ?? "";
        SetDuration(int.Parse(userInput));
        GetReady();

        for(int i = 0; i < (GetDuration()/5); i++){
            Console.WriteLine("Breathe in...");
            Wait(3);
            Console.WriteLine("Breathe out...");
            Wait(2);
        }
        Console.WriteLine(GetEndMessage());
    }

}