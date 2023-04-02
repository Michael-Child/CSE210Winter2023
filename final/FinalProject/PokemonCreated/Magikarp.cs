using System;

class Magikarp: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Splash", "Water", 0),
        new Move ("Splash", "Water", 0),
        new Move ("Splash", "Water", 0),
        new Move ("Splash", "Water", 0)};

    public Magikarp(): 
    base("Magikarp",
    "Water",
    20,
    10,
    55,
    80,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetAttackPower(GetAttackPower()*2);
    }
}