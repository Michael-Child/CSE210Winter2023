using System;

class Blastiose: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Water Pulse", "Water", 50),
        new Move ("Bite", "Dark", 50),
        new Move ("Rock Tomb", "Ground", 50),
        new Move ("Iron Defense", "Normal", 0)};

    public Blastiose(): 
    base("Blastiose",
    "Water",
    100,
    83,
    100,
    78,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetDefense(GetDefense() + (GetDefense()/4));
    }
}