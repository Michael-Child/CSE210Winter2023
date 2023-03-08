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
    }public string GetTitle(){
        return this._title;
    }public void SetTitle(string title){
        _title = title;
    }public string GetName(){
        return this._name;
    }public void SetName(string name){
        _name = name;
    }public string GetDescription(){
        return this._description;
    }public void SetDescription(string description){
        _description = description;
    }public int GetPoints(){
        return this._points;
    }public void SetPoints(int points){
        _points = points;
    }public virtual bool GetRecord(){
        return this._record;
    }public void SetRecord(bool record){
        _record = record;
    }public void DisplayX(){
        if(_record == true){
            Console.Write("[X]");
        }
        else{
            Console.Write("[ ]");
        }
    }public void SetGoal(){
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
}