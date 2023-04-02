using System;

class Blaziken: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Fire Punch", "Fire", 50),
        new Move ("Ice Punch", "Ice", 50),
        new Move ("Thunder Punch", "Electric", 50),
        new Move ("Double Team", "Normal", 0)};

    public Blaziken(): 
    base("Blaziken",
    "Fire",
    80,
    120,
    70,
    80,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetDefense(GetDefense() + (GetDefense()/5));
        SetSpeed(GetSpeed() + (GetSpeed()/5));
    }
}