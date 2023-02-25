using System;

class Activity{
    private string _title;
    private string _discription;
    private string _startMessage;
    private string _endMessage;
    private int _duration;

    public Activity(string title,
     string discription,
     string startMessage,
     string endMessage,
     int duration){
        this._title=title;
        this._discription=discription;
        this._startMessage=startMessage;
        this._endMessage=endMessage;
        this._duration=duration;
    }

    public string GetTitle(){
        return this._title;
    }
    public void SetTitle(string title){
        _title = title;
    }

    public string GetDiscription(){
        return this._discription;
    }
    public void SetDiscription(string discription){
        _discription = discription;
    }

    public string GetStartMessage(){
        return this._startMessage;
    }
    public void SetStartMessage(string startMessage){
        _startMessage = startMessage;
    }

    public string GetEndMessage(){
        return this._endMessage;
    }
    public void SetEndMessage(string endMessage){
        _endMessage = endMessage;
    }

    public int GetDuration(){
        return this._duration;
    }
    public void SetDuration(int duration){
        _duration = duration;
    }

    public int Random(int max){
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, max);
        return num;
    }

    public void GetReady(){
        Console.WriteLine("Get ready...");
        for(int a = 0; a < 6; a++){
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
        }
    }

    public void Wait(int sec){
        for(int a = 0; a < sec; a++){
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}