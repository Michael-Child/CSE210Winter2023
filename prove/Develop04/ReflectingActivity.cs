using System;

class ReflectingActivity: Activity{
    private List<string> _StartMessageList = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};    
    private List<string> _EndMessageList = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};

    private List<string> _FirstUI = new List<string>();
    private List<string> _SecondUI = new List<string>();
    public ReflectingActivity(): 
    base("Reflecting Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    "How long, in seconds, would you like for your session?",
    "Well done!!",
     0){}

    public void Reflect(){
        Console.WriteLine($"Welcome to the {GetTitle()}");
        Console.WriteLine(GetDiscription());
        Console.WriteLine(GetStartMessage());
        string userInput = Console.ReadLine() ?? "";
        SetDuration(int.Parse(userInput));
        GetReady();

        SetStartMessage(_StartMessageList[Random(_StartMessageList.Count())]);
        Console.Write(" --- ");
        Console.WriteLine(GetStartMessage());
        Console.Write(" --- ");

        Console.WriteLine("When you have something in mind. press enter to continue.");
        Thread.Sleep(5000);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration()/2);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime){
            userInput = Console.ReadLine() ?? "";
            _FirstUI.Add(userInput);
            currentTime = DateTime.Now;
        }

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        for(int a = 0; a < 5; a++){
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(GetDuration()/2);
        currentTime = DateTime.Now;
        int i = 0;
        while(currentTime < futureTime){
            Console.WriteLine(_EndMessageList[i]);
            userInput = Console.ReadLine() ?? "";
            _SecondUI.Add(userInput);
            currentTime = DateTime.Now;
        }
        Console.WriteLine(GetEndMessage());
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the Reflection Activity.");
    }

      
}