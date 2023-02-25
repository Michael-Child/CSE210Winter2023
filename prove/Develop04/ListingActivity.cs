using System;

class ListingActivity: Activity{

    private List<string> _StartMessageList = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};    

    private List<string> _UI = new List<string>();
    public ListingActivity(): 
    base("Listing Activity",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
    "How long, in seconds, would you like for your session?",
    "Well done!!",
     0){}

    public void List(){
        Console.WriteLine($"Welcome to the {GetTitle()}");
        Console.WriteLine(GetDiscription());
        Console.WriteLine(GetStartMessage());
        string userInput = Console.ReadLine() ?? "";
        SetDuration(int.Parse(userInput));
        GetReady();
        Console.WriteLine("List as many responses you can to the following promt:");
        Console.Write(" --- ");
        SetStartMessage(_StartMessageList[Random(_StartMessageList.Count())]);
        Console.Write(GetStartMessage());
        Console.WriteLine(" --- ");
        Console.WriteLine("You may begin in:");
        CountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration()/2);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime){
            userInput = Console.ReadLine() ?? "";
            _UI.Add(userInput);
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_UI.Count()} items");
        Console.WriteLine(GetEndMessage());
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the Reflection Activity.");
    }  
}