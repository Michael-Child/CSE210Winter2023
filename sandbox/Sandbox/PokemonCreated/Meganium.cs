using System;

class Meganium: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Razor Leaf", "Grass", 50),
        new Move ("Take Down", "Normal", 50),
        new Move ("Bulldoze", "Ground", 50),
        new Move ("Sunny Day", "Normal", 0)};

    public Meganium(): 
    base("Meganium",
    "Grass",
    100,
    82,
    100,
    80,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetHP(GetHP()+(GetHP()/4));
    }
}
