using System;

class Points: Goal{

    private int _points = 0;
    public Points(): 
    base("Will be void",
    "Will be void",
    "Will be void",
    0,
    false){}

    public override string GetTitle(){
        return "";
    }public override string GetName(){
        return "";
    }public override string GetDescription(){
        return "";
    }public override int GetPoints(){
        return _points;
    }public override void SetPoints(int points){ //Add numbers
        _points += points;
    }public override bool GetRecord(){
        return false;
    }
    public override void save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine($"{GetPoints()}");
    }}
    
}