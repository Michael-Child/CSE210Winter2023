using System;

class Venusaur: Pokemon{
    static List<Move> _moves = new List<Move>{
        new Move ("Vine Whip", "Grass", 50),
        new Move ("Sludge", "Poison", 50),
        new Move ("Cut", "Normal", 50),
        new Move ("Petal Dance", "Normal", 0)};

    public Venusaur(): 
    base("Venusaur",
    "Grass",
    100,
    82,
    83,
    80,
    //Moves 
    _moves){}

    public override void DoThe4thMove(){
        SetSpeed(GetSpeed()+(GetSpeed()/4));
    }
}