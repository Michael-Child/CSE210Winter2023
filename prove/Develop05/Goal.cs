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

    List<Goal> GoalList = new List<Goal>{};

    public void list(){
        int i = 0;
        foreach(var g in GoalList){
            // if(GoalList[i]is(ChecklistGoal)){
            //     Console.WriteLine($"{i+1}. {GoalList[i].DisplayX} {GoalList[i].GetName()} ({GoalList[i].GetDescription()}) -- Currently completed: {GoalList[i].GetCompletion()}/{GoalList[i].GetCompletionGoal()}");
            // }else{
                Console.WriteLine($"{i+1}. {GoalList[i].DisplayX} {GoalList[i].GetName()} ({GoalList[i].GetDescription()})");
        }
    }

    public void load(string fileName){
        Console.WriteLine("The goals are: ");
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines){
            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }

    public void save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            for(int i = 0; i < GoalList.Count(); i++){
                // if(GoalList[i]is(ChecklistGoal)){
                //     outputFile.WriteLine($"{i+1}. {GoalList[i].DisplayX} {GoalList[i].GetName()} ({GoalList[i].GetDescription()}) -- Currently completed: {GoalList[i].GetCompletion()}/{GoalList[i].GetCompletionGoal()}");
                // }else{
                    outputFile.WriteLine($"{i+1}. {GoalList[i].DisplayX} {GoalList[i].GetName()} ({GoalList[i].GetDescription()})");
    
    }}}
}