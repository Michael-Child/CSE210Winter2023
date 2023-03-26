using System;

class Goal
{
    private string _title;
    private string _name;
    private string _description;
    private int _points;
    private bool _record;
    public Goal(string title, 
     string name,
     string description,
     int points,
     bool record){
        this._title=title;
        this._name=name;
        this._description=description;
        this._points=points;
        this._record=record;
    }public virtual string GetTitle(){
        return this._title;
    }public virtual void SetTitle(string title){
        _title = title;
    }public virtual string GetName(){
        return this._name;
    }public virtual void SetName(string name){
        _name = name;
    }public virtual string GetDescription(){
        return this._description;
    }public virtual void SetDescription(string description){
        _description = description;
    }public virtual int GetPoints(){
        return this._points;
    }public virtual void SetPoints(int points){
        _points = points;
    }public virtual bool GetRecord(){
        return this._record;
    }public virtual void SetRecord(bool record){
        _record = record;
    }public virtual void DisplayX(){
        if(GetRecord() == true){
            Console.Write("[X]");
        }
        else{
            Console.Write("[ ]");
        }
    }public virtual void SetGoal(){
        Console.WriteLine("What is the name of your goal? ");
        string UI = Console.ReadLine() ?? "";
        SetName(UI);

        Console.WriteLine("What is a short description of it? ");
        UI = Console.ReadLine() ?? "";
        SetDescription(UI);

        Console.WriteLine("What is the amount of points associated with this goal? ");
        UI = Console.ReadLine() ?? "";
        int point = int.Parse(UI);
        SetPoints(point);
    }
    public virtual void list(){
        DisplayX();
        Console.WriteLine($" {GetName()} ({GetDescription()})");
    }
    public virtual void load(string fileName){
        Console.WriteLine("The goals are: ");
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines){
            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
    }}
    public virtual void save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine($"{GetTitle()}: {GetName()} {GetDescription()} {GetPoints()} {GetRecord()}");
    }}
}