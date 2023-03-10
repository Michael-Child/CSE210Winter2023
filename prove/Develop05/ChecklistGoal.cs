using System;

class ChecklistGoal: Goal{
    private int _completionGoal;
    private int _completion;
    private int _bonus;
    public ChecklistGoal(int bonus, int completionGoal, int completion): 
    base("Checklist Goal",
    "Goal name",
    "Description of goal",
    0,
    false){
        this._bonus=bonus;
        this._completionGoal=completionGoal;
        this._completion=completion;
    }public override bool GetRecord(){
        if(_completionGoal <= _completion){
            SetRecord(true);
            return true;
        }
        else{return false;}
    }public int GetBonus(){
        return this._bonus;
    }public void SetBonus(int bonus){
        _bonus = bonus;
    }public int GetCompletionGoal(){
        return this._completionGoal;
    }public void SetCompletionGoal(int completionGoal){
        _completionGoal = completionGoal;
    }public int GetCompletion(){
        return this._completion;
    }public void SetCompletion(int completion){
        _completion = completion;
    }public override void SetGoal(){
        SetGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string UI = Console.ReadLine() ?? "";
        int point = int.Parse(UI);
        SetCompletionGoal(point);

        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        UI = Console.ReadLine() ?? "";
        point = int.Parse(UI);
        SetBonus(point);
    }
    public override void save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine($"{GetTitle}: {DisplayX} {GetName} {GetDescription} {GetPoints} {GetRecord} {GetBonus} {GetCompletion} {GetCompletionGoal} ");
    }}
    public virtual void list(){
        Console.WriteLine($"{DisplayX} {GetName} ({GetDescription}) --- Currently completed: {GetCompletion}/{GetCompletionGoal}");
    }
}