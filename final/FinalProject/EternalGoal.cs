using System;

class EternalGoal: Goal{
    public EternalGoal(): 
    base("Eternal Goal",
    "Goal name",
    "Description of goal",
    0,
    false){}

    public override bool GetRecord(){
        return false;
    }

    public override void save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine($"{GetTitle()}: {GetName()} {GetDescription()} {GetPoints()}");
    }}}