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
}